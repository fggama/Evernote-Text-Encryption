using EvernoteSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextEncryption
{
    public partial class Form1 : Form
    {
        private ENNote _note;
        private ENNotebook _noteBook;
        private ENNoteRef _noteRef;
        public Form1()
        {
            InitializeComponent();
            _cifrado = "";
            _plain = "";
            
            /* Modifique los valores de los 'Recursos' (propiedades del proyecto) para:
             *** Nota
             *** Contrasenia
             *** Token
             *** StoreUrl
             */

            tbNota.Text = Properties.Resources.ResourceManager.GetString("Nota");
            tbContrasenia.Text = Properties.Resources.ResourceManager.GetString("Contrasenia");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ENSession.SetSharedSessionDeveloperToken(Properties.Resources.ResourceManager.GetString("Token"),
                Properties.Resources.ResourceManager.GetString("StoreUrl"));
        }

        private void butLeer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (ENSession.SharedSession.IsAuthenticated == false)
                    ENSession.SharedSession.AuthenticateToEvernote();
                if (!ENSession.SharedSession.IsAuthenticated)
                    throw new Exception("No autenticado");
                
                string textToFind = "";
                
                List<ENNotebook> myNotebookList = ENSession.SharedSession.ListNotebooks();
                cbMostrar.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                _plain = "";
                _cifrado = "";
                string texto_nota = "";
                
                foreach (ENNotebook en in myNotebookList)
                {
                    List<ENSessionFindNotesResult> myResultsList = ENSession.SharedSession.FindNotes(ENNoteSearch.NoteSearch(textToFind), en,
                    ENSession.SearchScope.All, ENSession.SortOrder.RecentlyUpdated, 500);

                    foreach (ENSessionFindNotesResult note in myResultsList)
                    {
                        if (note.Title.Equals(tbNota.Text))
                        {
                            _noteBook = en;
                            _noteRef = note.NoteRef;
                            _note = ENSession.SharedSession.DownloadNote(note.NoteRef);
                            texto_nota += _note.TextContent;
                        }
                    }
                    Application.DoEvents();
                }
                if (texto_nota.Length > 0)
                {
                    _plain = StringCipher.Decrypt(texto_nota, tbContrasenia.Text);
                    _cifrado = texto_nota;
                    textBox1.Text = _cifrado;
                    textBox2.Text = _plain;
                    cbMostrar.Enabled = true;
                    cbMostrar.Checked = true;
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Leer Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Cursor = Cursors.Default;
        }
       
        private void butActualizar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("???", "Actualizar Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Se actualizará la Nota de Evernote, desea continuar?", "Actualizar Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Cursor = Cursors.WaitCursor;
            try
            {
                if (ENSession.SharedSession.IsAuthenticated == false)
                    ENSession.SharedSession.AuthenticateToEvernote();
                if (!ENSession.SharedSession.IsAuthenticated)
                    throw new Exception("No autenticado");

                string encryptedstring = StringCipher.Encrypt(textBox2.Text, tbContrasenia.Text);
                if (_note != null)
                {
                    ENNote replace = new ENNote();
                    replace.Content = ENNoteContent.NoteContentWithString(encryptedstring);
                    replace.Title = _note.Title;
                    if (_note.TagNames != null)
                        replace.TagNames = _note.TagNames;

                    ENSession.SharedSession.UploadNote(replace, ENSession.UploadPolicy.Replace, _noteBook, _noteRef);
                }
                textBox1.Text = encryptedstring;
                MessageBox.Show("Nota actualizada!", "Actualizar Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualizar Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked)
                textBox2.ForeColor = Color.Black;
            else
                textBox2.ForeColor = Color.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private string _plain;
        private string _cifrado;
        private void textBox2_Enter(object sender, EventArgs e) 
        {
            if (_plain.Length == 0)
                _plain = textBox2.Text;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (_plain.Length > 0 && _plain != textBox2.Text)
            {
                try
                {
                    textBox1.Text = StringCipher.Encrypt(textBox2.Text, tbContrasenia.Text);
                    _plain = textBox2.Text;
                    cbMostrar.Enabled = true;
                    cbMostrar.Checked = true;
                    butActualizar.Focus();
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message + "\r\nRestaurar valor anterior?", "Cifrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        textBox2.Text = _plain;
                    textBox2.Focus();
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (_cifrado.Length == 0)
                _cifrado = textBox1.Text;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (_cifrado.Length > 0 && _cifrado != textBox1.Text)
            {
                try
                {
                    textBox2.Text = StringCipher.Decrypt(textBox1.Text, tbContrasenia.Text);
                    _cifrado = textBox1.Text;
                    cbMostrar.Enabled = true;
                    cbMostrar.Checked = true;
                    butActualizar.Focus();

                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message + "\r\nRestaurar valor anterior?", "Descifrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        textBox1.Text = _cifrado;
                    textBox1.Focus();
                }
            }
        }
    }
}
