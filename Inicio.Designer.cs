namespace Tiendita
{
    partial class Inicio
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
            this.pnl_Inicio = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnl_Inicio
            // 
            this.pnl_Inicio.AutoScroll = true;
            this.pnl_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Inicio.Location = new System.Drawing.Point(0, 0);
            this.pnl_Inicio.Name = "pnl_Inicio";
            this.pnl_Inicio.Size = new System.Drawing.Size(1000, 768);
            this.pnl_Inicio.TabIndex = 27;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 768);
            this.Controls.Add(this.pnl_Inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_Inicio;
    }
}