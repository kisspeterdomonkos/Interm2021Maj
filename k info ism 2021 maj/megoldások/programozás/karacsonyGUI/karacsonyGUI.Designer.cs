namespace karacsonyGUI
{
    partial class karacsonyGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.preparedTextBox = new System.Windows.Forms.TextBox();
            this.soldTextBox = new System.Windows.Forms.TextBox();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nap száma:";
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(142, 26);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(120, 28);
            this.dayComboBox.TabIndex = 1;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elkészített:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eladott:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(744, 21);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 32);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Hozzáad";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // preparedTextBox
            // 
            this.preparedTextBox.Location = new System.Drawing.Point(386, 26);
            this.preparedTextBox.Name = "preparedTextBox";
            this.preparedTextBox.Size = new System.Drawing.Size(82, 27);
            this.preparedTextBox.TabIndex = 5;
            this.preparedTextBox.Text = "0";
            // 
            // soldTextBox
            // 
            this.soldTextBox.Location = new System.Drawing.Point(606, 26);
            this.soldTextBox.Name = "soldTextBox";
            this.soldTextBox.Size = new System.Drawing.Size(82, 27);
            this.soldTextBox.TabIndex = 6;
            this.soldTextBox.Text = "0";
            // 
            // infoListBox
            // 
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 20;
            this.infoListBox.Location = new System.Drawing.Point(41, 108);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(647, 304);
            this.infoListBox.TabIndex = 7;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(647, 75);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(50, 20);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "label4";
            // 
            // karacsonyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.soldTextBox);
            this.Controls.Add(this.preparedTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.label1);
            this.Name = "karacsonyGUI";
            this.Text = "Angyalkák";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox dayComboBox;
        private Label label2;
        private Label label3;
        private Button confirmButton;
        private TextBox preparedTextBox;
        private TextBox soldTextBox;
        private ListBox infoListBox;
        private Label labelError;
    }
}