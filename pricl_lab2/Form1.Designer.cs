
namespace pricl_lab2
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
            this.txt_pow = new System.Windows.Forms.TextBox();
            this.lbl_pow = new System.Windows.Forms.Label();
            this.btn_pow = new System.Windows.Forms.Button();
            this.txt_sum1 = new System.Windows.Forms.TextBox();
            this.txt_sum2 = new System.Windows.Forms.TextBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_pow
            // 
            this.txt_pow.Location = new System.Drawing.Point(12, 69);
            this.txt_pow.Name = "txt_pow";
            this.txt_pow.Size = new System.Drawing.Size(286, 22);
            this.txt_pow.TabIndex = 0;
            // 
            // lbl_pow
            // 
            this.lbl_pow.AutoSize = true;
            this.lbl_pow.Location = new System.Drawing.Point(564, 74);
            this.lbl_pow.Name = "lbl_pow";
            this.lbl_pow.Size = new System.Drawing.Size(0, 17);
            this.lbl_pow.TabIndex = 1;
            // 
            // btn_pow
            // 
            this.btn_pow.Location = new System.Drawing.Point(314, 71);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Size = new System.Drawing.Size(75, 23);
            this.btn_pow.TabIndex = 2;
            this.btn_pow.Text = "POW";
            this.btn_pow.UseVisualStyleBackColor = true;
            this.btn_pow.Click += new System.EventHandler(this.btn_pow_Click);
            // 
            // txt_sum1
            // 
            this.txt_sum1.Location = new System.Drawing.Point(13, 345);
            this.txt_sum1.Name = "txt_sum1";
            this.txt_sum1.Size = new System.Drawing.Size(249, 22);
            this.txt_sum1.TabIndex = 3;
            // 
            // txt_sum2
            // 
            this.txt_sum2.Location = new System.Drawing.Point(521, 345);
            this.txt_sum2.Name = "txt_sum2";
            this.txt_sum2.Size = new System.Drawing.Size(249, 22);
            this.txt_sum2.TabIndex = 4;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(349, 344);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(88, 23);
            this.btn_sum.TabIndex = 5;
            this.btn_sum.Text = "Summarize";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(12, 405);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(0, 17);
            this.lbl_sum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 558);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.txt_sum2);
            this.Controls.Add(this.txt_sum1);
            this.Controls.Add(this.btn_pow);
            this.Controls.Add(this.lbl_pow);
            this.Controls.Add(this.txt_pow);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pow;
        private System.Windows.Forms.Label lbl_pow;
        private System.Windows.Forms.Button btn_pow;
        private System.Windows.Forms.TextBox txt_sum1;
        private System.Windows.Forms.TextBox txt_sum2;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Label lbl_sum;
    }
}

