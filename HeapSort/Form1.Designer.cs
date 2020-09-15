namespace HeapSort
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
            this.startSheet = new System.Windows.Forms.PictureBox();
            this.buttonCreateVertex = new System.Windows.Forms.Button();
            this.textboxWeightVertex = new System.Windows.Forms.TextBox();
            this.textBoxArrayViewGraph = new System.Windows.Forms.TextBox();
            this.buttonConvertToHeap = new System.Windows.Forms.Button();
            this.textBoxArrayHeap = new System.Windows.Forms.TextBox();
            this.resultSheet = new System.Windows.Forms.PictureBox();
            this.labelWeightVertex = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxArraySort = new System.Windows.Forms.TextBox();
            this.labelArrayViewGraph = new System.Windows.Forms.Label();
            this.labelArrayViewHeap = new System.Windows.Forms.Label();
            this.labelArraySort = new System.Windows.Forms.Label();
            this.buttonDeleteVertex = new System.Windows.Forms.Button();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.buttonLoadGraph = new System.Windows.Forms.Button();
            this.checkBoxLearning = new System.Windows.Forms.CheckBox();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonSift = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConverArraytoGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // startSheet
            // 
            this.startSheet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startSheet.Location = new System.Drawing.Point(128, 10);
            this.startSheet.Name = "startSheet";
            this.startSheet.Size = new System.Drawing.Size(260, 320);
            this.startSheet.TabIndex = 0;
            this.startSheet.TabStop = false;
            // 
            // buttonCreateVertex
            // 
            this.buttonCreateVertex.Location = new System.Drawing.Point(12, 10);
            this.buttonCreateVertex.Name = "buttonCreateVertex";
            this.buttonCreateVertex.Size = new System.Drawing.Size(110, 40);
            this.buttonCreateVertex.TabIndex = 1;
            this.buttonCreateVertex.Text = "Создать\r\nвершину\r\n\r\n";
            this.buttonCreateVertex.UseVisualStyleBackColor = true;
            // 
            // textboxWeightVertex
            // 
            this.textboxWeightVertex.Location = new System.Drawing.Point(44, 56);
            this.textboxWeightVertex.Name = "textboxWeightVertex";
            this.textboxWeightVertex.Size = new System.Drawing.Size(78, 20);
            this.textboxWeightVertex.TabIndex = 2;
            // 
            // textBoxArrayViewGraph
            // 
            this.textBoxArrayViewGraph.Location = new System.Drawing.Point(128, 353);
            this.textBoxArrayViewGraph.Name = "textBoxArrayViewGraph";
            this.textBoxArrayViewGraph.ReadOnly = true;
            this.textBoxArrayViewGraph.Size = new System.Drawing.Size(260, 20);
            this.textBoxArrayViewGraph.TabIndex = 3;
            // 
            // buttonConvertToHeap
            // 
            this.buttonConvertToHeap.Location = new System.Drawing.Point(12, 128);
            this.buttonConvertToHeap.Name = "buttonConvertToHeap";
            this.buttonConvertToHeap.Size = new System.Drawing.Size(110, 40);
            this.buttonConvertToHeap.TabIndex = 4;
            this.buttonConvertToHeap.Text = "Преобразовать\r\nв кучу\r\n\r\n\r\n";
            this.buttonConvertToHeap.UseVisualStyleBackColor = true;
            // 
            // textBoxArrayHeap
            // 
            this.textBoxArrayHeap.Location = new System.Drawing.Point(443, 353);
            this.textBoxArrayHeap.Name = "textBoxArrayHeap";
            this.textBoxArrayHeap.ReadOnly = true;
            this.textBoxArrayHeap.Size = new System.Drawing.Size(260, 20);
            this.textBoxArrayHeap.TabIndex = 5;
            // 
            // resultSheet
            // 
            this.resultSheet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultSheet.Location = new System.Drawing.Point(443, 10);
            this.resultSheet.Name = "resultSheet";
            this.resultSheet.Size = new System.Drawing.Size(260, 320);
            this.resultSheet.TabIndex = 6;
            this.resultSheet.TabStop = false;
            // 
            // labelWeightVertex
            // 
            this.labelWeightVertex.AutoSize = true;
            this.labelWeightVertex.Location = new System.Drawing.Point(12, 59);
            this.labelWeightVertex.Name = "labelWeightVertex";
            this.labelWeightVertex.Size = new System.Drawing.Size(26, 13);
            this.labelWeightVertex.TabIndex = 7;
            this.labelWeightVertex.Text = "Вес";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(12, 174);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(110, 40);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Отсортировать \r\nмассив\r\n";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // textBoxArraySort
            // 
            this.textBoxArraySort.Location = new System.Drawing.Point(443, 390);
            this.textBoxArraySort.Name = "textBoxArraySort";
            this.textBoxArraySort.ReadOnly = true;
            this.textBoxArraySort.Size = new System.Drawing.Size(260, 20);
            this.textBoxArraySort.TabIndex = 9;
            // 
            // labelArrayViewGraph
            // 
            this.labelArrayViewGraph.AutoSize = true;
            this.labelArrayViewGraph.Location = new System.Drawing.Point(125, 337);
            this.labelArrayViewGraph.Name = "labelArrayViewGraph";
            this.labelArrayViewGraph.Size = new System.Drawing.Size(206, 13);
            this.labelArrayViewGraph.TabIndex = 10;
            this.labelArrayViewGraph.Text = "Представление графа в виде массива:";
            // 
            // labelArrayViewHeap
            // 
            this.labelArrayViewHeap.AutoSize = true;
            this.labelArrayViewHeap.Location = new System.Drawing.Point(440, 337);
            this.labelArrayViewHeap.Name = "labelArrayViewHeap";
            this.labelArrayViewHeap.Size = new System.Drawing.Size(197, 13);
            this.labelArrayViewHeap.TabIndex = 11;
            this.labelArrayViewHeap.Text = "Представление кучи в виде массива:";
            // 
            // labelArraySort
            // 
            this.labelArraySort.AutoSize = true;
            this.labelArraySort.Location = new System.Drawing.Point(440, 374);
            this.labelArraySort.Name = "labelArraySort";
            this.labelArraySort.Size = new System.Drawing.Size(143, 13);
            this.labelArraySort.TabIndex = 12;
            this.labelArraySort.Text = "Отсортированный массив:";
            // 
            // buttonDeleteVertex
            // 
            this.buttonDeleteVertex.Location = new System.Drawing.Point(12, 82);
            this.buttonDeleteVertex.Name = "buttonDeleteVertex";
            this.buttonDeleteVertex.Size = new System.Drawing.Size(110, 40);
            this.buttonDeleteVertex.TabIndex = 13;
            this.buttonDeleteVertex.Text = "Удалить вершину";
            this.buttonDeleteVertex.UseVisualStyleBackColor = true;
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(128, 379);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(260, 23);
            this.buttonSaveGraph.TabIndex = 14;
            this.buttonSaveGraph.Text = "Сохранить граф";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            // 
            // buttonLoadGraph
            // 
            this.buttonLoadGraph.Location = new System.Drawing.Point(128, 408);
            this.buttonLoadGraph.Name = "buttonLoadGraph";
            this.buttonLoadGraph.Size = new System.Drawing.Size(260, 23);
            this.buttonLoadGraph.TabIndex = 15;
            this.buttonLoadGraph.Text = "Загрузить граф";
            this.buttonLoadGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxLearning
            // 
            this.checkBoxLearning.AutoSize = true;
            this.checkBoxLearning.Location = new System.Drawing.Point(15, 266);
            this.checkBoxLearning.Name = "checkBoxLearning";
            this.checkBoxLearning.Size = new System.Drawing.Size(110, 17);
            this.checkBoxLearning.TabIndex = 16;
            this.checkBoxLearning.Text = "Режим обучения";
            this.checkBoxLearning.UseVisualStyleBackColor = true;
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.Location = new System.Drawing.Point(714, 10);
            this.textBoxExplanation.Multiline = true;
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.Size = new System.Drawing.Size(130, 273);
            this.textBoxExplanation.TabIndex = 17;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(714, 290);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(130, 40);
            this.buttonNextStep.TabIndex = 18;
            this.buttonNextStep.Text = "Следующий шаг";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            // 
            // buttonSift
            // 
            this.buttonSift.Location = new System.Drawing.Point(12, 220);
            this.buttonSift.Name = "buttonSift";
            this.buttonSift.Size = new System.Drawing.Size(73, 40);
            this.buttonSift.TabIndex = 19;
            this.buttonSift.Text = "Просеять граф";
            this.buttonSift.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(30, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // buttonConverArraytoGraph
            // 
            this.buttonConverArraytoGraph.Location = new System.Drawing.Point(9, 350);
            this.buttonConverArraytoGraph.Name = "buttonConverArraytoGraph";
            this.buttonConverArraytoGraph.Size = new System.Drawing.Size(110, 37);
            this.buttonConverArraytoGraph.TabIndex = 21;
            this.buttonConverArraytoGraph.Text = "Построить граф по массиву";
            this.buttonConverArraytoGraph.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 445);
            this.Controls.Add(this.buttonConverArraytoGraph);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSift);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.textBoxExplanation);
            this.Controls.Add(this.checkBoxLearning);
            this.Controls.Add(this.buttonLoadGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.buttonDeleteVertex);
            this.Controls.Add(this.labelArraySort);
            this.Controls.Add(this.labelArrayViewHeap);
            this.Controls.Add(this.labelArrayViewGraph);
            this.Controls.Add(this.textBoxArraySort);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelWeightVertex);
            this.Controls.Add(this.resultSheet);
            this.Controls.Add(this.textBoxArrayHeap);
            this.Controls.Add(this.buttonConvertToHeap);
            this.Controls.Add(this.textBoxArrayViewGraph);
            this.Controls.Add(this.textboxWeightVertex);
            this.Controls.Add(this.buttonCreateVertex);
            this.Controls.Add(this.startSheet);
            this.Name = "Form1";
            this.Text = "Изучение двоичной кучи";
            ((System.ComponentModel.ISupportInitialize)(this.startSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox startSheet;
        private System.Windows.Forms.Button buttonCreateVertex;
        private System.Windows.Forms.TextBox textboxWeightVertex;
        private System.Windows.Forms.TextBox textBoxArrayViewGraph;
        private System.Windows.Forms.Button buttonConvertToHeap;
        private System.Windows.Forms.TextBox textBoxArrayHeap;
        private System.Windows.Forms.PictureBox resultSheet;
        private System.Windows.Forms.Label labelWeightVertex;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxArraySort;
        private System.Windows.Forms.Label labelArrayViewGraph;
        private System.Windows.Forms.Label labelArrayViewHeap;
        private System.Windows.Forms.Label labelArraySort;
        private System.Windows.Forms.Button buttonDeleteVertex;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Button buttonLoadGraph;
        private System.Windows.Forms.CheckBox checkBoxLearning;
        private System.Windows.Forms.TextBox textBoxExplanation;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonSift;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConverArraytoGraph;
    }
}

