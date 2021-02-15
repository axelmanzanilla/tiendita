namespace Tiendita
{
    partial class Actualizar
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
            this.correo = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(159, 99);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(252, 20);
            this.correo.TabIndex = 53;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(291, 256);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(120, 29);
            this.btn_Aceptar.TabIndex = 52;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Correo:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(159, 73);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(252, 20);
            this.apellido.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(159, 47);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(252, 20);
            this.nombre.TabIndex = 47;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(159, 204);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(252, 20);
            this.pass.TabIndex = 55;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // repass
            // 
            this.repass.Location = new System.Drawing.Point(159, 230);
            this.repass.Name = "repass";
            this.repass.Size = new System.Drawing.Size(252, 20);
            this.repass.TabIndex = 57;
            this.repass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(159, 125);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(252, 20);
            this.direccion.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Código Postal:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(159, 151);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(252, 20);
            this.codigo.TabIndex = 61;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Actualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codigo;
    }
}