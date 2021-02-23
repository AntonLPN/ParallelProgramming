
namespace ParallelProgramming
{
    partial class Task3Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task3Forms));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCountOffers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountSymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCountWords = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCountQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSeentenceCount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 255);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заранее подготовленный текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCountOffers
            // 
            this.textBoxCountOffers.Location = new System.Drawing.Point(358, 462);
            this.textBoxCountOffers.Multiline = true;
            this.textBoxCountOffers.Name = "textBoxCountOffers";
            this.textBoxCountOffers.Size = new System.Drawing.Size(73, 24);
            this.textBoxCountOffers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количесвто предложений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количесвто символов\r\n";
            // 
            // textBoxCountSymbol
            // 
            this.textBoxCountSymbol.Location = new System.Drawing.Point(358, 495);
            this.textBoxCountSymbol.Multiline = true;
            this.textBoxCountSymbol.Name = "textBoxCountSymbol";
            this.textBoxCountSymbol.Size = new System.Drawing.Size(73, 24);
            this.textBoxCountSymbol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количесвто слов\r\n";
            // 
            // textBoxCountWords
            // 
            this.textBoxCountWords.Location = new System.Drawing.Point(358, 525);
            this.textBoxCountWords.Multiline = true;
            this.textBoxCountWords.Name = "textBoxCountWords";
            this.textBoxCountWords.Size = new System.Drawing.Size(73, 24);
            this.textBoxCountWords.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количесвто вопросительных предлжений\r\n\r\n";
            // 
            // textBoxCountQuestion
            // 
            this.textBoxCountQuestion.Location = new System.Drawing.Point(358, 555);
            this.textBoxCountQuestion.Multiline = true;
            this.textBoxCountQuestion.Name = "textBoxCountQuestion";
            this.textBoxCountQuestion.Size = new System.Drawing.Size(73, 24);
            this.textBoxCountQuestion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количесвто восклицательных предлжений\r\n\r\n";
            // 
            // textBoxSeentenceCount
            // 
            this.textBoxSeentenceCount.Location = new System.Drawing.Point(358, 585);
            this.textBoxSeentenceCount.Multiline = true;
            this.textBoxSeentenceCount.Name = "textBoxSeentenceCount";
            this.textBoxSeentenceCount.Size = new System.Drawing.Size(73, 28);
            this.textBoxSeentenceCount.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 80);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сохранить результат в файл\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Task3Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 690);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSeentenceCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCountQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCountWords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCountSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCountOffers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task3Forms";
            this.Text = "Task3Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCountOffers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCountWords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCountQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSeentenceCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}