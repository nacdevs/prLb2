namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(182, 42);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(35, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(334, 42);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(35, 13);
            this.apellido.TabIndex = 3;
            this.apellido.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(182, 77);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 5;
            this.email.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(182, 112);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(35, 13);
            this.password.TabIndex = 7;
            this.password.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Celular:";
            // 
            // celular
            // 
            this.celular.AutoSize = true;
            this.celular.Location = new System.Drawing.Point(182, 144);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(41, 13);
            this.celular.TabIndex = 9;
            this.celular.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sexo:";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(182, 170);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(41, 13);
            this.sexo.TabIndex = 11;
            this.sexo.Text = "label12";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label celular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sexo;
    }
}