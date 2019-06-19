namespace TextEncryption
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butLeer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butActualizar = new System.Windows.Forms.Button();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(287, 149);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // butLeer
            // 
            this.butLeer.BackColor = System.Drawing.Color.DarkKhaki;
            this.butLeer.FlatAppearance.BorderSize = 0;
            this.butLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.butLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLeer.Image = ((System.Drawing.Image)(resources.GetObject("butLeer.Image")));
            this.butLeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLeer.Location = new System.Drawing.Point(31, 66);
            this.butLeer.Name = "butLeer";
            this.butLeer.Size = new System.Drawing.Size(112, 23);
            this.butLeer.TabIndex = 1;
            this.butLeer.Text = "leer Nota";
            this.butLeer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.butLeer, "Recupera la Nota desde Evernote");
            this.butLeer.UseVisualStyleBackColor = false;
            this.butLeer.Click += new System.EventHandler(this.butLeer_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(190, 176);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(287, 145);
            this.textBox2.TabIndex = 3;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // butActualizar
            // 
            this.butActualizar.BackColor = System.Drawing.Color.DarkKhaki;
            this.butActualizar.FlatAppearance.BorderSize = 0;
            this.butActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.butActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butActualizar.Image = ((System.Drawing.Image)(resources.GetObject("butActualizar.Image")));
            this.butActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butActualizar.Location = new System.Drawing.Point(31, 230);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(112, 29);
            this.butActualizar.TabIndex = 4;
            this.butActualizar.Text = "actualizar Nota";
            this.butActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.butActualizar, "Actualiza la Nota con el Texto cifrado");
            this.butActualizar.UseVisualStyleBackColor = false;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Enabled = false;
            this.cbMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMostrar.Location = new System.Drawing.Point(80, 303);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(99, 17);
            this.cbMostrar.TabIndex = 6;
            this.cbMostrar.Text = "Mostrar texto >>";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.cbMostrar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.tbContrasenia);
            this.panel1.Controls.Add(this.cbMostrar);
            this.panel1.Controls.Add(this.tbNota);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butLeer);
            this.panel1.Controls.Add(this.butActualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 334);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nota";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(80, 6);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(81, 20);
            this.tbNota.TabIndex = 10;
            this.tbNota.Text = "Contraseñas";
            this.toolTip1.SetToolTip(this.tbNota, "Nombre de la Nota en Evernote");
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(80, 28);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.Size = new System.Drawing.Size(81, 20);
            this.tbContrasenia.TabIndex = 11;
            this.tbContrasenia.Text = "Veloci R4pt0r";
            this.toolTip1.SetToolTip(this.tbContrasenia, "Contraseña para el cifrado/descifrado de la Nota");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(487, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cifrar Texto Nota Evernote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butLeer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

