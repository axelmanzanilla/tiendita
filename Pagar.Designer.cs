﻿namespace Tiendita
{
    partial class Pagar
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tarjetas = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.importe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.folio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(145, 22);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(255, 20);
            this.nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(145, 48);
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Size = new System.Drawing.Size(255, 20);
            this.direccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarjeta:";
            // 
            // tarjetas
            // 
            this.tarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tarjetas.FormattingEnabled = true;
            this.tarjetas.Location = new System.Drawing.Point(145, 74);
            this.tarjetas.Name = "tarjetas";
            this.tarjetas.Size = new System.Drawing.Size(255, 21);
            this.tarjetas.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(406, 74);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importe:";
            // 
            // importe
            // 
            this.importe.Location = new System.Drawing.Point(145, 101);
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Size = new System.Drawing.Size(255, 20);
            this.importe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asegurese de ver que están correctos los datos";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(170, 233);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(89, 17);
            this.check.TabIndex = 11;
            this.check.Text = "Estoy Seguro";
            this.check.UseVisualStyleBackColor = true;
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(284, 229);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pagar.TabIndex = 12;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            this.btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Folio:";
            // 
            // folio
            // 
            this.folio.Location = new System.Drawing.Point(145, 127);
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Size = new System.Drawing.Size(255, 20);
            this.folio.TabIndex = 14;
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.folio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.importe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.tarjetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.MaximizeBox = false;
            this.Name = "Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tarjetas;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox importe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox folio;
    }
}