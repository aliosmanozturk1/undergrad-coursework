namespace Hafta2_2_NotHesaplayici
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
            hesaplaButonu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            arasinavTextBox = new TextBox();
            finalSinavTextBox = new TextBox();
            hesaplananNotTextBox = new TextBox();
            harfNotTextBox = new TextBox();
            SuspendLayout();
            // 
            // hesaplaButonu
            // 
            hesaplaButonu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            hesaplaButonu.Location = new Point(691, 452);
            hesaplaButonu.Margin = new Padding(6, 6, 6, 6);
            hesaplaButonu.Name = "hesaplaButonu";
            hesaplaButonu.Size = new Size(171, 77);
            hesaplaButonu.TabIndex = 0;
            hesaplaButonu.Text = "HESAPLA";
            hesaplaButonu.UseVisualStyleBackColor = true;
            hesaplaButonu.Click += hesaplaButonu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 277);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 45);
            label1.TabIndex = 1;
            label1.Text = "ARA SINAV NOTUNUZ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(310, 331);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(390, 45);
            label2.TabIndex = 2;
            label2.Text = "FİNAL SINAV NOTUNUZ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(292, 606);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(411, 45);
            label3.TabIndex = 3;
            label3.Text = "HESAPLANAN NOTUNUZ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(414, 670);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(281, 45);
            label4.TabIndex = 4;
            label4.Text = "HARF NOTUNUZ:";
            // 
            // arasinavTextBox
            // 
            arasinavTextBox.Location = new Point(691, 283);
            arasinavTextBox.Margin = new Padding(6, 6, 6, 6);
            arasinavTextBox.Name = "arasinavTextBox";
            arasinavTextBox.Size = new Size(182, 39);
            arasinavTextBox.TabIndex = 5;
            // 
            // finalSinavTextBox
            // 
            finalSinavTextBox.Location = new Point(691, 338);
            finalSinavTextBox.Margin = new Padding(6, 6, 6, 6);
            finalSinavTextBox.Name = "finalSinavTextBox";
            finalSinavTextBox.Size = new Size(182, 39);
            finalSinavTextBox.TabIndex = 6;
            // 
            // hesaplananNotTextBox
            // 
            hesaplananNotTextBox.Location = new Point(691, 613);
            hesaplananNotTextBox.Margin = new Padding(6, 6, 6, 6);
            hesaplananNotTextBox.Name = "hesaplananNotTextBox";
            hesaplananNotTextBox.Size = new Size(182, 39);
            hesaplananNotTextBox.TabIndex = 7;
            // 
            // harfNotTextBox
            // 
            harfNotTextBox.Location = new Point(691, 676);
            harfNotTextBox.Margin = new Padding(6, 6, 6, 6);
            harfNotTextBox.Name = "harfNotTextBox";
            harfNotTextBox.Size = new Size(182, 39);
            harfNotTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(harfNotTextBox);
            Controls.Add(hesaplananNotTextBox);
            Controls.Add(finalSinavTextBox);
            Controls.Add(arasinavTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hesaplaButonu);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hesaplaButonu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox arasinavTextBox;
        private TextBox finalSinavTextBox;
        private TextBox hesaplananNotTextBox;
        private TextBox harfNotTextBox;
    }
}