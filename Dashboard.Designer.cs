
namespace OnlineLibraryApp
{
    partial class Dashboard
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.btn_ReplacingBooks = new System.Windows.Forms.Button();
            this.btn_IdentifyingAreas = new System.Windows.Forms.Button();
            this.btn_FindingCallNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_welcome.Location = new System.Drawing.Point(83, 52);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(605, 46);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome to your Online Library App";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ReplacingBooks
            // 
            this.btn_ReplacingBooks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReplacingBooks.Location = new System.Drawing.Point(83, 289);
            this.btn_ReplacingBooks.Name = "btn_ReplacingBooks";
            this.btn_ReplacingBooks.Size = new System.Drawing.Size(195, 72);
            this.btn_ReplacingBooks.TabIndex = 1;
            this.btn_ReplacingBooks.Text = "Replacing Books";
            this.btn_ReplacingBooks.UseVisualStyleBackColor = true;
            this.btn_ReplacingBooks.Click += new System.EventHandler(this.btn_ReplacingBooks_Click);
            // 
            // btn_IdentifyingAreas
            // 
            this.btn_IdentifyingAreas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IdentifyingAreas.Location = new System.Drawing.Point(284, 289);
            this.btn_IdentifyingAreas.Name = "btn_IdentifyingAreas";
            this.btn_IdentifyingAreas.Size = new System.Drawing.Size(203, 72);
            this.btn_IdentifyingAreas.TabIndex = 1;
            this.btn_IdentifyingAreas.Text = "Identifying Areas";
            this.btn_IdentifyingAreas.UseVisualStyleBackColor = true;
            // 
            // btn_FindingCallNumbers
            // 
            this.btn_FindingCallNumbers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FindingCallNumbers.Location = new System.Drawing.Point(493, 289);
            this.btn_FindingCallNumbers.Name = "btn_FindingCallNumbers";
            this.btn_FindingCallNumbers.Size = new System.Drawing.Size(195, 72);
            this.btn_FindingCallNumbers.TabIndex = 1;
            this.btn_FindingCallNumbers.Text = "Finding Call Numbers";
            this.btn_FindingCallNumbers.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineLibraryApp.Properties.Resources.Library_Wallpaper_clocks_Vladstudio;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_FindingCallNumbers);
            this.Controls.Add(this.btn_IdentifyingAreas);
            this.Controls.Add(this.btn_ReplacingBooks);
            this.Controls.Add(this.label_welcome);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button btn_ReplacingBooks;
        private System.Windows.Forms.Button btn_IdentifyingAreas;
        private System.Windows.Forms.Button btn_FindingCallNumbers;
    }
}

