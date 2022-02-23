
namespace RisuyuFigury
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
            this.picB = new System.Windows.Forms.PictureBox();
            this.Narisovatbtn = new System.Windows.Forms.Button();
            this.Steret_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // picB
            // 
            this.picB.Location = new System.Drawing.Point(16, 15);
            this.picB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(756, 524);
            this.picB.TabIndex = 0;
            this.picB.TabStop = false;
            // 
            // Narisovatbtn
            // 
            this.Narisovatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Narisovatbtn.Location = new System.Drawing.Point(780, 15);
            this.Narisovatbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Narisovatbtn.Name = "Narisovatbtn";
            this.Narisovatbtn.Size = new System.Drawing.Size(271, 44);
            this.Narisovatbtn.TabIndex = 1;
            this.Narisovatbtn.Text = "Нарисовать";
            this.Narisovatbtn.UseVisualStyleBackColor = true;
            this.Narisovatbtn.Click += new System.EventHandler(this.Narisovatbtn_Click);
            // 
            // Steret_btn
            // 
            this.Steret_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Steret_btn.Location = new System.Drawing.Point(780, 66);
            this.Steret_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Steret_btn.Name = "Steret_btn";
            this.Steret_btn.Size = new System.Drawing.Size(271, 44);
            this.Steret_btn.TabIndex = 2;
            this.Steret_btn.Text = "Стереть";
            this.Steret_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Steret_btn);
            this.Controls.Add(this.Narisovatbtn);
            this.Controls.Add(this.picB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.Button Narisovatbtn;
        private System.Windows.Forms.Button Steret_btn;
    }
}

