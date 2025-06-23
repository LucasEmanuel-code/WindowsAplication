namespace WinFormsApp1
{
    partial class FrmLicenca
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
            btnObter = new Button();
            btnRegister = new Button();
            txtChave = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnObter
            // 
            btnObter.BackColor = SystemColors.ButtonShadow;
            btnObter.Location = new Point(27, 79);
            btnObter.Name = "btnObter";
            btnObter.Size = new Size(209, 55);
            btnObter.TabIndex = 0;
            btnObter.Text = "Obter";
            btnObter.UseVisualStyleBackColor = false;
            btnObter.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonShadow;
            btnRegister.Location = new Point(781, 175);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button2_Click;
            // 
            // txtChave
            // 
            txtChave.Location = new Point(27, 175);
            txtChave.Name = "txtChave";
            txtChave.Size = new Size(729, 27);
            txtChave.TabIndex = 2;
            txtChave.Text = "Chave de acesso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 3;
            label1.Text = "Obtenha a Licença";
            // 
            // FrmLicenca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 649);
            Controls.Add(label1);
            Controls.Add(txtChave);
            Controls.Add(btnRegister);
            Controls.Add(btnObter);
            Name = "FrmLicenca";
            Text = "FrmLicenca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObter;
        private Button btnRegister;
        private TextBox txtChave;
        private Label label1;
    }
}