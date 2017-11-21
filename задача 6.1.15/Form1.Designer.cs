namespace Task6_1_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите слова через пробел:";
            // 
            // inputS
            // 
            this.inputS.Location = new System.Drawing.Point(228, 97);
            this.inputS.Name = "inputS";
            this.inputS.Size = new System.Drawing.Size(603, 24);
            this.inputS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите число k:";
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(150, 141);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(122, 24);
            this.inputK.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "k-e слово в данной строке:";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(211, 242);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(93, 18);
            this.output.TabIndex = 7;
            this.output.Text = "слово";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(10, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 130);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 418);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Task 6.1.15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.ListBox listBox1;
    }
}

