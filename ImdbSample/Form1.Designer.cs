namespace ImdbSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.btnSearchByYear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(895, 542);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(106, 37);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(150, 31);
            this.txtCount.TabIndex = 1;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(144, 83);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(112, 34);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "TAKE";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(144, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(106, 168);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Year";
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(153, 347);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(150, 31);
            this.txtStartYear.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Year";
            // 
            // txtEndYear
            // 
            this.txtEndYear.Location = new System.Drawing.Point(153, 409);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(150, 31);
            this.txtEndYear.TabIndex = 8;
            // 
            // btnSearchByYear
            // 
            this.btnSearchByYear.Location = new System.Drawing.Point(191, 478);
            this.btnSearchByYear.Name = "btnSearchByYear";
            this.btnSearchByYear.Size = new System.Drawing.Size(112, 34);
            this.btnSearchByYear.TabIndex = 10;
            this.btnSearchByYear.Text = "Search";
            this.btnSearchByYear.UseVisualStyleBackColor = true;
            this.btnSearchByYear.Click += new System.EventHandler(this.btnSearchByYear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1324, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "a harfi ile baslayan kac adet film var";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearchByYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtCount;
        private Button btnTake;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private TextBox txtStartYear;
        private Label label3;
        private TextBox txtEndYear;
        private Button btnSearchByYear;
        private Button button1;
    }
}