namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtResult = new TextBox();
            btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 174);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Precione OK para preencher a caixa de texto";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(157, 202);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(358, 27);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.ButtonShadow;
            btn.Location = new Point(157, 248);
            btn.Name = "btn";
            btn.Size = new Size(358, 60);
            btn.TabIndex = 2;
            btn.Text = "OK";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 650);
            Controls.Add(btn);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aplicação1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResult;
        private Button btn;
    }
}
