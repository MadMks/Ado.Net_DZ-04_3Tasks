namespace Task_1
{
    partial class MainForm
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
            this.dataGridViewAllData = new System.Windows.Forms.DataGridView();
            this.dataGridViewQueryResult = new System.Windows.Forms.DataGridView();
            this.groupBoxQueryLinq = new System.Windows.Forms.GroupBox();
            this.buttonLinqFifth = new System.Windows.Forms.Button();
            this.buttonLinqFourth = new System.Windows.Forms.Button();
            this.buttonLinqTheThird = new System.Windows.Forms.Button();
            this.buttonLinqSecond = new System.Windows.Forms.Button();
            this.buttonLinqFirst = new System.Windows.Forms.Button();
            this.groupBoxMethodOfExpansion = new System.Windows.Forms.GroupBox();
            this.buttonMethodFifth = new System.Windows.Forms.Button();
            this.buttonMethodFourth = new System.Windows.Forms.Button();
            this.buttonMethodTheThird = new System.Windows.Forms.Button();
            this.buttonMethodSecond = new System.Windows.Forms.Button();
            this.buttonMethodFirst = new System.Windows.Forms.Button();
            this.groupBoxDescriptionOfRequest = new System.Windows.Forms.GroupBox();
            this.labelDescriptionOfRequest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).BeginInit();
            this.groupBoxQueryLinq.SuspendLayout();
            this.groupBoxMethodOfExpansion.SuspendLayout();
            this.groupBoxDescriptionOfRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllData
            // 
            this.dataGridViewAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllData.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewAllData.Name = "dataGridViewAllData";
            this.dataGridViewAllData.ReadOnly = true;
            this.dataGridViewAllData.RowTemplate.Height = 23;
            this.dataGridViewAllData.Size = new System.Drawing.Size(444, 164);
            this.dataGridViewAllData.TabIndex = 0;
            // 
            // dataGridViewQueryResult
            // 
            this.dataGridViewQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResult.Location = new System.Drawing.Point(13, 413);
            this.dataGridViewQueryResult.Name = "dataGridViewQueryResult";
            this.dataGridViewQueryResult.ReadOnly = true;
            this.dataGridViewQueryResult.RowTemplate.Height = 23;
            this.dataGridViewQueryResult.Size = new System.Drawing.Size(443, 124);
            this.dataGridViewQueryResult.TabIndex = 1;
            // 
            // groupBoxQueryLinq
            // 
            this.groupBoxQueryLinq.Controls.Add(this.buttonLinqFifth);
            this.groupBoxQueryLinq.Controls.Add(this.buttonLinqFourth);
            this.groupBoxQueryLinq.Controls.Add(this.buttonLinqTheThird);
            this.groupBoxQueryLinq.Controls.Add(this.buttonLinqSecond);
            this.groupBoxQueryLinq.Controls.Add(this.buttonLinqFirst);
            this.groupBoxQueryLinq.Location = new System.Drawing.Point(12, 186);
            this.groupBoxQueryLinq.Name = "groupBoxQueryLinq";
            this.groupBoxQueryLinq.Size = new System.Drawing.Size(444, 71);
            this.groupBoxQueryLinq.TabIndex = 2;
            this.groupBoxQueryLinq.TabStop = false;
            this.groupBoxQueryLinq.Text = "Запросы LINQ";
            // 
            // buttonLinqFifth
            // 
            this.buttonLinqFifth.Location = new System.Drawing.Point(343, 27);
            this.buttonLinqFifth.Name = "buttonLinqFifth";
            this.buttonLinqFifth.Size = new System.Drawing.Size(75, 23);
            this.buttonLinqFifth.TabIndex = 4;
            this.buttonLinqFifth.Text = "5";
            this.buttonLinqFifth.UseVisualStyleBackColor = true;
            this.buttonLinqFifth.Click += new System.EventHandler(this.buttonLinqFifth_Click);
            // 
            // buttonLinqFourth
            // 
            this.buttonLinqFourth.Location = new System.Drawing.Point(262, 27);
            this.buttonLinqFourth.Name = "buttonLinqFourth";
            this.buttonLinqFourth.Size = new System.Drawing.Size(75, 23);
            this.buttonLinqFourth.TabIndex = 3;
            this.buttonLinqFourth.Text = "4";
            this.buttonLinqFourth.UseVisualStyleBackColor = true;
            this.buttonLinqFourth.Click += new System.EventHandler(this.buttonLinqFourth_Click);
            // 
            // buttonLinqTheThird
            // 
            this.buttonLinqTheThird.Location = new System.Drawing.Point(181, 27);
            this.buttonLinqTheThird.Name = "buttonLinqTheThird";
            this.buttonLinqTheThird.Size = new System.Drawing.Size(75, 23);
            this.buttonLinqTheThird.TabIndex = 2;
            this.buttonLinqTheThird.Text = "3";
            this.buttonLinqTheThird.UseVisualStyleBackColor = true;
            this.buttonLinqTheThird.Click += new System.EventHandler(this.buttonLinqTheThird_Click);
            // 
            // buttonLinqSecond
            // 
            this.buttonLinqSecond.Location = new System.Drawing.Point(100, 27);
            this.buttonLinqSecond.Name = "buttonLinqSecond";
            this.buttonLinqSecond.Size = new System.Drawing.Size(75, 23);
            this.buttonLinqSecond.TabIndex = 1;
            this.buttonLinqSecond.Text = "2";
            this.buttonLinqSecond.UseVisualStyleBackColor = true;
            this.buttonLinqSecond.Click += new System.EventHandler(this.buttonLinqSecond_Click);
            // 
            // buttonLinqFirst
            // 
            this.buttonLinqFirst.Location = new System.Drawing.Point(19, 27);
            this.buttonLinqFirst.Name = "buttonLinqFirst";
            this.buttonLinqFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonLinqFirst.TabIndex = 0;
            this.buttonLinqFirst.Text = "1";
            this.buttonLinqFirst.UseVisualStyleBackColor = true;
            this.buttonLinqFirst.Click += new System.EventHandler(this.buttonLinqFirst_Click);
            // 
            // groupBoxMethodOfExpansion
            // 
            this.groupBoxMethodOfExpansion.Controls.Add(this.buttonMethodFifth);
            this.groupBoxMethodOfExpansion.Controls.Add(this.buttonMethodFourth);
            this.groupBoxMethodOfExpansion.Controls.Add(this.buttonMethodTheThird);
            this.groupBoxMethodOfExpansion.Controls.Add(this.buttonMethodSecond);
            this.groupBoxMethodOfExpansion.Controls.Add(this.buttonMethodFirst);
            this.groupBoxMethodOfExpansion.Location = new System.Drawing.Point(12, 267);
            this.groupBoxMethodOfExpansion.Name = "groupBoxMethodOfExpansion";
            this.groupBoxMethodOfExpansion.Size = new System.Drawing.Size(444, 71);
            this.groupBoxMethodOfExpansion.TabIndex = 5;
            this.groupBoxMethodOfExpansion.TabStop = false;
            this.groupBoxMethodOfExpansion.Text = "Методы расширения";
            // 
            // buttonMethodFifth
            // 
            this.buttonMethodFifth.Location = new System.Drawing.Point(343, 27);
            this.buttonMethodFifth.Name = "buttonMethodFifth";
            this.buttonMethodFifth.Size = new System.Drawing.Size(75, 23);
            this.buttonMethodFifth.TabIndex = 4;
            this.buttonMethodFifth.Text = "5";
            this.buttonMethodFifth.UseVisualStyleBackColor = true;
            this.buttonMethodFifth.Click += new System.EventHandler(this.buttonMethodFifth_Click);
            // 
            // buttonMethodFourth
            // 
            this.buttonMethodFourth.Location = new System.Drawing.Point(262, 27);
            this.buttonMethodFourth.Name = "buttonMethodFourth";
            this.buttonMethodFourth.Size = new System.Drawing.Size(75, 23);
            this.buttonMethodFourth.TabIndex = 3;
            this.buttonMethodFourth.Text = "4";
            this.buttonMethodFourth.UseVisualStyleBackColor = true;
            this.buttonMethodFourth.Click += new System.EventHandler(this.buttonMethodFourth_Click);
            // 
            // buttonMethodTheThird
            // 
            this.buttonMethodTheThird.Location = new System.Drawing.Point(181, 27);
            this.buttonMethodTheThird.Name = "buttonMethodTheThird";
            this.buttonMethodTheThird.Size = new System.Drawing.Size(75, 23);
            this.buttonMethodTheThird.TabIndex = 2;
            this.buttonMethodTheThird.Text = "3";
            this.buttonMethodTheThird.UseVisualStyleBackColor = true;
            this.buttonMethodTheThird.Click += new System.EventHandler(this.buttonMethodTheThird_Click);
            // 
            // buttonMethodSecond
            // 
            this.buttonMethodSecond.Location = new System.Drawing.Point(100, 27);
            this.buttonMethodSecond.Name = "buttonMethodSecond";
            this.buttonMethodSecond.Size = new System.Drawing.Size(75, 23);
            this.buttonMethodSecond.TabIndex = 1;
            this.buttonMethodSecond.Text = "2";
            this.buttonMethodSecond.UseVisualStyleBackColor = true;
            this.buttonMethodSecond.Click += new System.EventHandler(this.buttonMethodSecond_Click);
            // 
            // buttonMethodFirst
            // 
            this.buttonMethodFirst.Location = new System.Drawing.Point(19, 27);
            this.buttonMethodFirst.Name = "buttonMethodFirst";
            this.buttonMethodFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonMethodFirst.TabIndex = 0;
            this.buttonMethodFirst.Text = "1";
            this.buttonMethodFirst.UseVisualStyleBackColor = true;
            this.buttonMethodFirst.Click += new System.EventHandler(this.buttonMethodFirst_Click);
            // 
            // groupBoxDescriptionOfRequest
            // 
            this.groupBoxDescriptionOfRequest.Controls.Add(this.labelDescriptionOfRequest);
            this.groupBoxDescriptionOfRequest.Location = new System.Drawing.Point(13, 348);
            this.groupBoxDescriptionOfRequest.Name = "groupBoxDescriptionOfRequest";
            this.groupBoxDescriptionOfRequest.Size = new System.Drawing.Size(443, 50);
            this.groupBoxDescriptionOfRequest.TabIndex = 6;
            this.groupBoxDescriptionOfRequest.TabStop = false;
            this.groupBoxDescriptionOfRequest.Text = "Описание запроса";
            // 
            // labelDescriptionOfRequest
            // 
            this.labelDescriptionOfRequest.AutoSize = true;
            this.labelDescriptionOfRequest.Location = new System.Drawing.Point(11, 23);
            this.labelDescriptionOfRequest.Name = "labelDescriptionOfRequest";
            this.labelDescriptionOfRequest.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionOfRequest.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 549);
            this.Controls.Add(this.groupBoxDescriptionOfRequest);
            this.Controls.Add(this.groupBoxMethodOfExpansion);
            this.Controls.Add(this.groupBoxQueryLinq);
            this.Controls.Add(this.dataGridViewQueryResult);
            this.Controls.Add(this.dataGridViewAllData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Task 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).EndInit();
            this.groupBoxQueryLinq.ResumeLayout(false);
            this.groupBoxMethodOfExpansion.ResumeLayout(false);
            this.groupBoxDescriptionOfRequest.ResumeLayout(false);
            this.groupBoxDescriptionOfRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllData;
        private System.Windows.Forms.DataGridView dataGridViewQueryResult;
        private System.Windows.Forms.GroupBox groupBoxQueryLinq;
        private System.Windows.Forms.Button buttonLinqFirst;
        private System.Windows.Forms.Button buttonLinqFifth;
        private System.Windows.Forms.Button buttonLinqFourth;
        private System.Windows.Forms.Button buttonLinqTheThird;
        private System.Windows.Forms.Button buttonLinqSecond;
        private System.Windows.Forms.GroupBox groupBoxMethodOfExpansion;
        private System.Windows.Forms.Button buttonMethodFifth;
        private System.Windows.Forms.Button buttonMethodFourth;
        private System.Windows.Forms.Button buttonMethodTheThird;
        private System.Windows.Forms.Button buttonMethodSecond;
        private System.Windows.Forms.Button buttonMethodFirst;
        private System.Windows.Forms.GroupBox groupBoxDescriptionOfRequest;
        private System.Windows.Forms.Label labelDescriptionOfRequest;
    }
}

