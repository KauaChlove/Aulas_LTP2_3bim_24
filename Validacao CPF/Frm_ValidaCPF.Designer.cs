namespace Validacao_CPF
{
    partial class Frm_ValidaCPF
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
            Lbl_Resultdo = new Label();
            Msk_CPF = new MaskedTextBox();
            Btn_Reset = new Button();
            Btn_Valida = new Button();
            SuspendLayout();
            // 
            // Lbl_Resultdo
            // 
            Lbl_Resultdo.AutoSize = true;
            Lbl_Resultdo.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            Lbl_Resultdo.Location = new Point(63, 130);
            Lbl_Resultdo.Name = "Lbl_Resultdo";
            Lbl_Resultdo.Size = new Size(0, 22);
            Lbl_Resultdo.TabIndex = 1;
            // 
            // Msk_CPF
            // 
            Msk_CPF.Font = new Font("Segoe UI", 7F);
            Msk_CPF.Location = new Point(12, 45);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 20);
            Msk_CPF.TabIndex = 3;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 0;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_Valida
            // 
            Btn_Valida.Location = new Point(245, 71);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(111, 23);
            Btn_Valida.TabIndex = 4;
            Btn_Valida.Text = "Valida";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click;
            // 
            // Frm_ValidaCPF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(Msk_CPF);
            Controls.Add(Lbl_Resultdo);
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Name = "Frm_ValidaCPF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validacao CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label Lbl_Resultdo;
        private MaskedTextBox Msk_CPF;
        private Button Btn_Valida;
        private Button Btn_Reset;
    }
}
