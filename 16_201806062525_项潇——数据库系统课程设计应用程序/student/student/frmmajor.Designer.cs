namespace student
{
    partial class frmmajor
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
            this.txtxx_Mno16 = new System.Windows.Forms.TextBox();
            this.txtxx_Mname16 = new System.Windows.Forms.TextBox();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "专业号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "专业名";
            // 
            // txtxx_Mno16
            // 
            this.txtxx_Mno16.Location = new System.Drawing.Point(200, 78);
            this.txtxx_Mno16.Name = "txtxx_Mno16";
            this.txtxx_Mno16.Size = new System.Drawing.Size(100, 25);
            this.txtxx_Mno16.TabIndex = 2;
            // 
            // txtxx_Mname16
            // 
            this.txtxx_Mname16.Location = new System.Drawing.Point(436, 78);
            this.txtxx_Mname16.Name = "txtxx_Mname16";
            this.txtxx_Mname16.Size = new System.Drawing.Size(100, 25);
            this.txtxx_Mname16.TabIndex = 3;
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGridView1);
            this.Gbox.Location = new System.Drawing.Point(104, 159);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(432, 183);
            this.Gbox.TabIndex = 4;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "Gbox";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(426, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(632, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(347, 370);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 31);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(494, 370);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(75, 31);
            this.txtChange.TabIndex = 7;
            this.txtChange.Text = "保存";
            this.txtChange.UseVisualStyleBackColor = true;
            this.txtChange.Click += new System.EventHandler(this.txtChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(632, 370);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmmajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.txtxx_Mname16);
            this.Controls.Add(this.txtxx_Mno16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmmajor";
            this.Text = "专业信息管理窗口";
            this.Gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtxx_Mno16;
        private System.Windows.Forms.TextBox txtxx_Mname16;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button txtChange;
        private System.Windows.Forms.Button Cancel;
    }
}