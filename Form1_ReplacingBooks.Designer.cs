
namespace OnlineLibraryApp
{
    partial class Form1_ReplacingBooks
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GenerateBooks = new System.Windows.Forms.Button();
            this.callNumberList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.callNumberList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Replacing Books";
            // 
            // btn_GenerateBooks
            // 
            this.btn_GenerateBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenerateBooks.Location = new System.Drawing.Point(145, 449);
            this.btn_GenerateBooks.Name = "btn_GenerateBooks";
            this.btn_GenerateBooks.Size = new System.Drawing.Size(215, 58);
            this.btn_GenerateBooks.TabIndex = 3;
            this.btn_GenerateBooks.Text = "Generate Books";
            this.btn_GenerateBooks.UseVisualStyleBackColor = true;
            this.btn_GenerateBooks.Click += new System.EventHandler(this.btn_GenerateBooks_Click);
            // 
            // callNumberList
            // 
            this.callNumberList.AllowUserToAddRows = false;
            this.callNumberList.AllowUserToDeleteRows = false;
            this.callNumberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callNumberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.callNumber});
            this.callNumberList.Location = new System.Drawing.Point(88, 70);
            this.callNumberList.Name = "callNumberList";
            this.callNumberList.ReadOnly = true;
            this.callNumberList.RowHeadersWidth = 51;
            this.callNumberList.RowTemplate.Height = 29;
            this.callNumberList.Size = new System.Drawing.Size(324, 325);
            this.callNumberList.TabIndex = 4;
            this.callNumberList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.callNumberList_RowPostPaint);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // callNumber
            // 
            this.callNumber.DataPropertyName = "CallNumber";
            this.callNumber.HeaderText = "Call Number";
            this.callNumber.MinimumWidth = 6;
            this.callNumber.Name = "callNumber";
            this.callNumber.ReadOnly = true;
            this.callNumber.Width = 200;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(145, 407);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(215, 29);
            this.progressBar.TabIndex = 5;
            // 
            // Form1_ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineLibraryApp.Properties.Resources.library_multi_wallpaper_600;
            this.ClientSize = new System.Drawing.Size(520, 519);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.callNumberList);
            this.Controls.Add(this.btn_GenerateBooks);
            this.Controls.Add(this.label1);
            this.Name = "Form1_ReplacingBooks";
            this.Text = "Replacing Books";
            ((System.ComponentModel.ISupportInitialize)(this.callNumberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GenerateBooks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView callNumberList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn callNumber;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}