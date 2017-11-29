namespace Task_7_1_15
{
    partial class Task7_1_15
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
            this.TaskCondition = new System.Windows.Forms.Label();
            this.InvitationForUserInput = new System.Windows.Forms.Label();
            this.AcceptedData = new System.Windows.Forms.TextBox();
            this.CheckCondition = new System.Windows.Forms.Button();
            this.ResultOutput = new System.Windows.Forms.Label();
            this.Samples = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskCondition
            // 
            this.TaskCondition.Location = new System.Drawing.Point(18, 20);
            this.TaskCondition.Name = "TaskCondition";
            this.TaskCondition.Size = new System.Drawing.Size(985, 67);
            this.TaskCondition.TabIndex = 0;
            this.TaskCondition.Text = "Дан целочисленный массив размера N. Если он является перестановкой, то есть содер" +
    "жит все числа от 1 до N, то вывести 0, в противном случае вывести номер первого " +
    "недопустимого элемента.";
            // 
            // InvitationForUserInput
            // 
            this.InvitationForUserInput.AutoSize = true;
            this.InvitationForUserInput.Location = new System.Drawing.Point(18, 162);
            this.InvitationForUserInput.Name = "InvitationForUserInput";
            this.InvitationForUserInput.Size = new System.Drawing.Size(289, 20);
            this.InvitationForUserInput.TabIndex = 1;
            this.InvitationForUserInput.Text = "Введите целочисленный массив:";
            // 
            // AcceptedData
            // 
            this.AcceptedData.Location = new System.Drawing.Point(22, 198);
            this.AcceptedData.Name = "AcceptedData";
            this.AcceptedData.Size = new System.Drawing.Size(630, 27);
            this.AcceptedData.TabIndex = 2;
            this.AcceptedData.TextChanged += new System.EventHandler(this.AcceptedData_TextChanged);
            // 
            // CheckCondition
            // 
            this.CheckCondition.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CheckCondition.Location = new System.Drawing.Point(107, 245);
            this.CheckCondition.Name = "CheckCondition";
            this.CheckCondition.Size = new System.Drawing.Size(339, 47);
            this.CheckCondition.TabIndex = 3;
            this.CheckCondition.Text = "Проверить условие";
            this.CheckCondition.UseVisualStyleBackColor = true;
            this.CheckCondition.Click += new System.EventHandler(this.CheckCondition_Click);
            // 
            // ResultOutput
            // 
            this.ResultOutput.AutoSize = true;
            this.ResultOutput.Location = new System.Drawing.Point(21, 312);
            this.ResultOutput.Name = "ResultOutput";
            this.ResultOutput.Size = new System.Drawing.Size(262, 20);
            this.ResultOutput.TabIndex = 4;
            this.ResultOutput.Text = "результат работы программы";
            this.ResultOutput.Visible = false;
            // 
            // Samples
            // 
            this.Samples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Samples.FormattingEnabled = true;
            this.Samples.Location = new System.Drawing.Point(22, 112);
            this.Samples.Name = "Samples";
            this.Samples.Size = new System.Drawing.Size(721, 28);
            this.Samples.TabIndex = 5;
            this.Samples.SelectedIndexChanged += new System.EventHandler(this.Samples_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Примеры вводимых массивов:";
            // 
            // Task7_1_15
            // 
            this.AcceptButton = this.CheckCondition;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Samples);
            this.Controls.Add(this.ResultOutput);
            this.Controls.Add(this.CheckCondition);
            this.Controls.Add(this.AcceptedData);
            this.Controls.Add(this.InvitationForUserInput);
            this.Controls.Add(this.TaskCondition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Task7_1_15";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Task 7.1.15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskCondition;
        private System.Windows.Forms.Label InvitationForUserInput;
        private System.Windows.Forms.TextBox AcceptedData;
        private System.Windows.Forms.Button CheckCondition;
        private System.Windows.Forms.Label ResultOutput;
        private System.Windows.Forms.ComboBox Samples;
        private System.Windows.Forms.Label label1;
    }
}

