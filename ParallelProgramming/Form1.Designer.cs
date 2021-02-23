
namespace ParallelProgramming
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTask1
            // 
            this.buttonTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask1.Location = new System.Drawing.Point(49, 31);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(216, 65);
            this.buttonTask1.TabIndex = 0;
            this.buttonTask1.Text = "Task 1";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // buttonTask2
            // 
            this.buttonTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask2.Location = new System.Drawing.Point(49, 120);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(216, 65);
            this.buttonTask2.TabIndex = 1;
            this.buttonTask2.Text = "Task 2";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // buttonTask3
            // 
            this.buttonTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask3.Location = new System.Drawing.Point(49, 209);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(216, 65);
            this.buttonTask3.TabIndex = 2;
            this.buttonTask3.Text = "Task 3";
            this.buttonTask3.UseVisualStyleBackColor = true;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.buttonTask3);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.buttonTask1);
            this.Name = "Form1";
            this.Text = "Parallel programming";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.Button buttonTask3;
    }
}

