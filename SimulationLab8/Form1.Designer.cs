
namespace SimulationLab8
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
            this.button_answer = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_orb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_orbAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_answer
            // 
            this.button_answer.Location = new System.Drawing.Point(95, 207);
            this.button_answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(108, 52);
            this.button_answer.TabIndex = 2;
            this.button_answer.Text = "Yes or No?";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button_answer_Click);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_answer.Location = new System.Drawing.Point(97, 262);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(0, 69);
            this.label_answer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lab 8.1";
            // 
            // button_orb
            // 
            this.button_orb.Location = new System.Drawing.Point(477, 207);
            this.button_orb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_orb.Name = "button_orb";
            this.button_orb.Size = new System.Drawing.Size(108, 52);
            this.button_orb.TabIndex = 5;
            this.button_orb.Text = "Shake orb";
            this.button_orb.UseVisualStyleBackColor = true;
            this.button_orb.Click += new System.EventHandler(this.button_orb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lab 8.1";
            // 
            // label_orbAnswer
            // 
            this.label_orbAnswer.AutoSize = true;
            this.label_orbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_orbAnswer.Location = new System.Drawing.Point(455, 281);
            this.label_orbAnswer.Name = "label_orbAnswer";
            this.label_orbAnswer.Size = new System.Drawing.Size(0, 32);
            this.label_orbAnswer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_orbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_orb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_answer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_orb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_orbAnswer;
    }
}

