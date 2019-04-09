namespace WindowsFormsApp2
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
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.comboAreaCode = new System.Windows.Forms.ComboBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(103, 53);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(100, 20);
            this.textFirst.TabIndex = 0;
            this.textFirst.Text = "Nombre";
            this.textFirst.TextChanged += new System.EventHandler(this.textFirst_TextChanged);
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(209, 53);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(119, 20);
            this.textLast.TabIndex = 1;
            this.textLast.Text = "Apellido";
            this.textLast.TextChanged += new System.EventHandler(this.textLast_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(102, 91);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(226, 20);
            this.textEmail.TabIndex = 2;
            this.textEmail.Text = "Direccion de correo electronico";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(102, 133);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(226, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "Contraseña";
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // comboAreaCode
            // 
            this.comboAreaCode.FormattingEnabled = true;
            this.comboAreaCode.Location = new System.Drawing.Point(102, 171);
            this.comboAreaCode.Name = "comboAreaCode";
            this.comboAreaCode.Size = new System.Drawing.Size(80, 21);
            this.comboAreaCode.TabIndex = 4;
            this.comboAreaCode.Text = "+1";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(188, 171);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(140, 20);
            this.textPhone.TabIndex = 5;
            this.textPhone.Text = "Número de celular";
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Sexo (opcional)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrarse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crear una direccion de correo electronico Yahoo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.12F);
            this.linkLabel1.Location = new System.Drawing.Point(102, 114);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quiero usar mi direccion actual de correo electronico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.comboAreaCode);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.ComboBox comboAreaCode;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}

