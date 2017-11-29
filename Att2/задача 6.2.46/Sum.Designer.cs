namespace задача_6._2._46
{
    partial class Sum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputE = new System.Windows.Forms.TextBox();
            this.inputN = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число х:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите число е:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите число n:";
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(177, 11);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(253, 27);
            this.inputX.TabIndex = 4;
            // 
            // inputE
            // 
            this.inputE.Location = new System.Drawing.Point(178, 47);
            this.inputE.Name = "inputE";
            this.inputE.Size = new System.Drawing.Size(252, 27);
            this.inputE.TabIndex = 5;
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(177, 91);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(253, 27);
            this.inputN.TabIndex = 6;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(19, 201);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(474, 160);
            this.output.TabIndex = 7;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(68, 147);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(147, 38);
            this.start.TabIndex = 8;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 401);
            this.Controls.Add(this.start);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.inputE);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sum";
            this.Text = "Task 6_2_46";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputE;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button start;
    }
}