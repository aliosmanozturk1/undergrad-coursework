namespace Hafta2_3_VKI_Hesaplayici
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
            siniflandirma_TextBox = new TextBox();
            VKI_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            hesaplaButonu = new Button();
            agirlik_TextBox = new TextBox();
            boy_TextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // siniflandirma_TextBox
            // 
            siniflandirma_TextBox.Location = new Point(183, 280);
            siniflandirma_TextBox.Name = "siniflandirma_TextBox";
            siniflandirma_TextBox.Size = new Size(100, 23);
            siniflandirma_TextBox.TabIndex = 27;
            // 
            // VKI_textBox
            // 
            VKI_textBox.Location = new Point(183, 245);
            VKI_textBox.Name = "VKI_textBox";
            VKI_textBox.Size = new Size(100, 23);
            VKI_textBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 282);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 25;
            label3.Text = "Sınıflandırma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(115, 243);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 24;
            label4.Text = "VKİ";
            // 
            // hesaplaButonu
            // 
            hesaplaButonu.Location = new Point(183, 167);
            hesaplaButonu.Name = "hesaplaButonu";
            hesaplaButonu.Size = new Size(100, 43);
            hesaplaButonu.TabIndex = 23;
            hesaplaButonu.Text = "HESAPLA";
            hesaplaButonu.UseVisualStyleBackColor = true;
            hesaplaButonu.Click += hesaplaButonu_Click;
            // 
            // agirlik_TextBox
            // 
            agirlik_TextBox.Location = new Point(183, 104);
            agirlik_TextBox.Name = "agirlik_TextBox";
            agirlik_TextBox.Size = new Size(100, 23);
            agirlik_TextBox.TabIndex = 22;
            // 
            // boy_TextBox
            // 
            boy_TextBox.Location = new Point(183, 69);
            boy_TextBox.Name = "boy_TextBox";
            boy_TextBox.Size = new Size(100, 23);
            boy_TextBox.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 104);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 20;
            label2.Text = "Ağırlık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 67);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 19;
            label1.Text = "Boy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 375);
            Controls.Add(siniflandirma_TextBox);
            Controls.Add(VKI_textBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(hesaplaButonu);
            Controls.Add(agirlik_TextBox);
            Controls.Add(boy_TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox siniflandirma_TextBox;
        private TextBox VKI_textBox;
        private Label label3;
        private Label label4;
        private Button hesaplaButonu;
        private TextBox agirlik_TextBox;
        private TextBox boy_TextBox;
        private Label label2;
        private Label label1;
    }
}