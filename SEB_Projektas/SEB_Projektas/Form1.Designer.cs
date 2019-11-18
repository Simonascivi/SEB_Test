namespace SEB_Projektas
{
    partial class IBANTikrinimas
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
            this.variantas1 = new System.Windows.Forms.Label();
            this.iveskiteLabel = new System.Windows.Forms.Label();
            this.inputIBAN = new System.Windows.Forms.TextBox();
            this.ivestiRankaButton = new System.Windows.Forms.Button();
            this.IBANCheckList = new System.Windows.Forms.CheckedListBox();
            this.variantas2 = new System.Windows.Forms.Label();
            this.PasirinktiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isvalytiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variantas1
            // 
            this.variantas1.AutoSize = true;
            this.variantas1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.variantas1.Location = new System.Drawing.Point(75, 9);
            this.variantas1.Name = "variantas1";
            this.variantas1.Size = new System.Drawing.Size(257, 22);
            this.variantas1.TabIndex = 0;
            this.variantas1.Text = "Interaktyvusis IBAN tikrinimas";
            // 
            // iveskiteLabel
            // 
            this.iveskiteLabel.AutoSize = true;
            this.iveskiteLabel.Location = new System.Drawing.Point(18, 51);
            this.iveskiteLabel.Name = "iveskiteLabel";
            this.iveskiteLabel.Size = new System.Drawing.Size(112, 13);
            this.iveskiteLabel.TabIndex = 1;
            this.iveskiteLabel.Text = "Įveskite IBAN numerį: ";
            // 
            // inputIBAN
            // 
            this.inputIBAN.Location = new System.Drawing.Point(136, 48);
            this.inputIBAN.Name = "inputIBAN";
            this.inputIBAN.Size = new System.Drawing.Size(230, 20);
            this.inputIBAN.TabIndex = 2;
            // 
            // ivestiRankaButton
            // 
            this.ivestiRankaButton.Location = new System.Drawing.Point(21, 87);
            this.ivestiRankaButton.Name = "ivestiRankaButton";
            this.ivestiRankaButton.Size = new System.Drawing.Size(345, 23);
            this.ivestiRankaButton.TabIndex = 3;
            this.ivestiRankaButton.Text = "Tikrinti";
            this.ivestiRankaButton.UseVisualStyleBackColor = true;
            this.ivestiRankaButton.Click += new System.EventHandler(this.ivestiRankaButton_Click);
            // 
            // IBANCheckList
            // 
            this.IBANCheckList.FormattingEnabled = true;
            this.IBANCheckList.Location = new System.Drawing.Point(21, 224);
            this.IBANCheckList.Name = "IBANCheckList";
            this.IBANCheckList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.IBANCheckList.Size = new System.Drawing.Size(345, 184);
            this.IBANCheckList.TabIndex = 5;
            // 
            // variantas2
            // 
            this.variantas2.AutoSize = true;
            this.variantas2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.variantas2.Location = new System.Drawing.Point(75, 127);
            this.variantas2.Name = "variantas2";
            this.variantas2.Size = new System.Drawing.Size(247, 22);
            this.variantas2.TabIndex = 6;
            this.variantas2.Text = "IBAN Kodų tikrinimas iš failo";
            // 
            // PasirinktiButton
            // 
            this.PasirinktiButton.Location = new System.Drawing.Point(21, 163);
            this.PasirinktiButton.Name = "PasirinktiButton";
            this.PasirinktiButton.Size = new System.Drawing.Size(345, 23);
            this.PasirinktiButton.TabIndex = 7;
            this.PasirinktiButton.Text = "Pasirinkti įvesties failą";
            this.PasirinktiButton.UseVisualStyleBackColor = true;
            this.PasirinktiButton.Click += new System.EventHandler(this.PasirinktiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IBAN kodų tikrinimo istorija";
            // 
            // isvalytiButton
            // 
            this.isvalytiButton.Location = new System.Drawing.Point(151, 414);
            this.isvalytiButton.Name = "isvalytiButton";
            this.isvalytiButton.Size = new System.Drawing.Size(99, 23);
            this.isvalytiButton.TabIndex = 9;
            this.isvalytiButton.Text = "Išvalyti istoriją";
            this.isvalytiButton.UseVisualStyleBackColor = true;
            this.isvalytiButton.Click += new System.EventHandler(this.isvalytiButton_Click);
            // 
            // IBANTikrinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 443);
            this.Controls.Add(this.isvalytiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasirinktiButton);
            this.Controls.Add(this.variantas2);
            this.Controls.Add(this.IBANCheckList);
            this.Controls.Add(this.ivestiRankaButton);
            this.Controls.Add(this.inputIBAN);
            this.Controls.Add(this.iveskiteLabel);
            this.Controls.Add(this.variantas1);
            this.Name = "IBANTikrinimas";
            this.Text = "IBAN Tikrinimo Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label variantas1;
        private System.Windows.Forms.Label iveskiteLabel;
        private System.Windows.Forms.TextBox inputIBAN;
        private System.Windows.Forms.Button ivestiRankaButton;
        private System.Windows.Forms.CheckedListBox IBANCheckList;
        private System.Windows.Forms.Label variantas2;
        private System.Windows.Forms.Button PasirinktiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button isvalytiButton;
    }
}

