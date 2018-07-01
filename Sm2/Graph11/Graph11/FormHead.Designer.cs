namespace Graph11
{
    partial class FormHead
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
            this.buttonLoadGraph = new System.Windows.Forms.Button();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.labelOutputRoute = new System.Windows.Forms.Label();
            this.buttonFindMinSumOfDists = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelAddWeight = new System.Windows.Forms.Label();
            this.labelAddNode = new System.Windows.Forms.Label();
            this.textBoxAddNode = new System.Windows.Forms.TextBox();
            this.groupBoxChecks = new System.Windows.Forms.GroupBox();
            this.radioButtonDelEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonAddEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonMoveNode = new System.Windows.Forms.RadioButton();
            this.radioButtonDelNode = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNode = new System.Windows.Forms.RadioButton();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.groupBoxChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadGraph
            // 
            this.buttonLoadGraph.BackColor = System.Drawing.Color.White;
            this.buttonLoadGraph.Location = new System.Drawing.Point(3, 12);
            this.buttonLoadGraph.Name = "buttonLoadGraph";
            this.buttonLoadGraph.Size = new System.Drawing.Size(134, 23);
            this.buttonLoadGraph.TabIndex = 34;
            this.buttonLoadGraph.Text = "Загрузить граф";
            this.buttonLoadGraph.UseVisualStyleBackColor = false;
            this.buttonLoadGraph.Click += new System.EventHandler(this.buttonLoadGraph_Click);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.BackColor = System.Drawing.Color.White;
            this.buttonSaveGraph.Location = new System.Drawing.Point(3, 41);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(133, 23);
            this.buttonSaveGraph.TabIndex = 33;
            this.buttonSaveGraph.Text = "Сохранить граф";
            this.buttonSaveGraph.UseVisualStyleBackColor = false;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // labelOutputRoute
            // 
            this.labelOutputRoute.AutoSize = true;
            this.labelOutputRoute.Location = new System.Drawing.Point(12, 415);
            this.labelOutputRoute.Name = "labelOutputRoute";
            this.labelOutputRoute.Size = new System.Drawing.Size(43, 13);
            this.labelOutputRoute.TabIndex = 32;
            this.labelOutputRoute.Text = "*ответ*";
            // 
            // buttonFindMinSumOfDists
            // 
            this.buttonFindMinSumOfDists.BackColor = System.Drawing.Color.White;
            this.buttonFindMinSumOfDists.Location = new System.Drawing.Point(4, 70);
            this.buttonFindMinSumOfDists.Name = "buttonFindMinSumOfDists";
            this.buttonFindMinSumOfDists.Size = new System.Drawing.Size(133, 82);
            this.buttonFindMinSumOfDists.TabIndex = 31;
            this.buttonFindMinSumOfDists.Text = "Найти город в системе двусторонних дорог, у которого сумма расстояний до любого г" +
    "орода минимальна";
            this.buttonFindMinSumOfDists.UseVisualStyleBackColor = false;
            this.buttonFindMinSumOfDists.Click += new System.EventHandler(this.buttonFindMinSumOfDists_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(96, 344);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(38, 20);
            this.textBoxWeight.TabIndex = 30;
            // 
            // labelAddWeight
            // 
            this.labelAddWeight.AutoSize = true;
            this.labelAddWeight.Location = new System.Drawing.Point(25, 347);
            this.labelAddWeight.Name = "labelAddWeight";
            this.labelAddWeight.Size = new System.Drawing.Size(65, 13);
            this.labelAddWeight.TabIndex = 29;
            this.labelAddWeight.Text = "Вес ребра: ";
            // 
            // labelAddNode
            // 
            this.labelAddNode.AutoSize = true;
            this.labelAddNode.Location = new System.Drawing.Point(1, 311);
            this.labelAddNode.Name = "labelAddNode";
            this.labelAddNode.Size = new System.Drawing.Size(89, 13);
            this.labelAddNode.TabIndex = 28;
            this.labelAddNode.Text = "Название узла: ";
            // 
            // textBoxAddNode
            // 
            this.textBoxAddNode.Location = new System.Drawing.Point(96, 308);
            this.textBoxAddNode.Name = "textBoxAddNode";
            this.textBoxAddNode.Size = new System.Drawing.Size(38, 20);
            this.textBoxAddNode.TabIndex = 27;
            // 
            // groupBoxChecks
            // 
            this.groupBoxChecks.Controls.Add(this.radioButtonDelEdge);
            this.groupBoxChecks.Controls.Add(this.radioButtonAddEdge);
            this.groupBoxChecks.Controls.Add(this.radioButtonMoveNode);
            this.groupBoxChecks.Controls.Add(this.radioButtonDelNode);
            this.groupBoxChecks.Controls.Add(this.radioButtonAddNode);
            this.groupBoxChecks.Location = new System.Drawing.Point(4, 158);
            this.groupBoxChecks.Name = "groupBoxChecks";
            this.groupBoxChecks.Size = new System.Drawing.Size(133, 140);
            this.groupBoxChecks.TabIndex = 26;
            this.groupBoxChecks.TabStop = false;
            this.groupBoxChecks.Text = "Режим";
            // 
            // radioButtonDelEdge
            // 
            this.radioButtonDelEdge.AutoSize = true;
            this.radioButtonDelEdge.Location = new System.Drawing.Point(7, 116);
            this.radioButtonDelEdge.Name = "radioButtonDelEdge";
            this.radioButtonDelEdge.Size = new System.Drawing.Size(101, 17);
            this.radioButtonDelEdge.TabIndex = 4;
            this.radioButtonDelEdge.TabStop = true;
            this.radioButtonDelEdge.Text = "Удалить ребро";
            this.radioButtonDelEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddEdge
            // 
            this.radioButtonAddEdge.AutoSize = true;
            this.radioButtonAddEdge.Location = new System.Drawing.Point(7, 92);
            this.radioButtonAddEdge.Name = "radioButtonAddEdge";
            this.radioButtonAddEdge.Size = new System.Drawing.Size(108, 17);
            this.radioButtonAddEdge.TabIndex = 3;
            this.radioButtonAddEdge.TabStop = true;
            this.radioButtonAddEdge.Text = "Добавить ребро";
            this.radioButtonAddEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoveNode
            // 
            this.radioButtonMoveNode.AutoSize = true;
            this.radioButtonMoveNode.Location = new System.Drawing.Point(7, 68);
            this.radioButtonMoveNode.Name = "radioButtonMoveNode";
            this.radioButtonMoveNode.Size = new System.Drawing.Size(119, 17);
            this.radioButtonMoveNode.TabIndex = 2;
            this.radioButtonMoveNode.TabStop = true;
            this.radioButtonMoveNode.Text = "Переместить узел";
            this.radioButtonMoveNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelNode
            // 
            this.radioButtonDelNode.AutoSize = true;
            this.radioButtonDelNode.Location = new System.Drawing.Point(7, 44);
            this.radioButtonDelNode.Name = "radioButtonDelNode";
            this.radioButtonDelNode.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDelNode.TabIndex = 1;
            this.radioButtonDelNode.TabStop = true;
            this.radioButtonDelNode.Text = "Удалить узел";
            this.radioButtonDelNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddNode
            // 
            this.radioButtonAddNode.AutoSize = true;
            this.radioButtonAddNode.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAddNode.Name = "radioButtonAddNode";
            this.radioButtonAddNode.Size = new System.Drawing.Size(101, 17);
            this.radioButtonAddNode.TabIndex = 0;
            this.radioButtonAddNode.TabStop = true;
            this.radioButtonAddNode.Text = "Добавить узел";
            this.radioButtonAddNode.UseVisualStyleBackColor = true;
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.Location = new System.Drawing.Point(143, 2);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(1315, 661);
            this.pictureBoxHead.TabIndex = 25;
            this.pictureBoxHead.TabStop = false;
            this.pictureBoxHead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            // 
            // FormHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.buttonLoadGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.labelOutputRoute);
            this.Controls.Add(this.buttonFindMinSumOfDists);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelAddWeight);
            this.Controls.Add(this.labelAddNode);
            this.Controls.Add(this.textBoxAddNode);
            this.Controls.Add(this.groupBoxChecks);
            this.Controls.Add(this.pictureBoxHead);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHead";
            this.Text = "Graph11";
            this.Load += new System.EventHandler(this.FormHead_Load);
            this.groupBoxChecks.ResumeLayout(false);
            this.groupBoxChecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadGraph;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Label labelOutputRoute;
        private System.Windows.Forms.Button buttonFindMinSumOfDists;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelAddWeight;
        private System.Windows.Forms.Label labelAddNode;
        private System.Windows.Forms.TextBox textBoxAddNode;
        private System.Windows.Forms.GroupBox groupBoxChecks;
        private System.Windows.Forms.RadioButton radioButtonDelEdge;
        private System.Windows.Forms.RadioButton radioButtonAddEdge;
        private System.Windows.Forms.RadioButton radioButtonMoveNode;
        private System.Windows.Forms.RadioButton radioButtonDelNode;
        private System.Windows.Forms.RadioButton radioButtonAddNode;
        private System.Windows.Forms.PictureBox pictureBoxHead;
    }
}

