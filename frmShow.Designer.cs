
namespace WinFormsApp1
{
    partial class FrmShow
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
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(218, 255);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(473, 60);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Escrever em Run time";
            lblMensagem.Click += label1_Click;
            // 
            // FrmShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 646);
            Controls.Add(lblMensagem);
            Name = "FrmShow";
            Text = "frmShow";
            Load += FrmShow_Load2;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblMensagem;
    }
}