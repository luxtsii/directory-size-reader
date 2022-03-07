namespace FileSizeReader
{
    partial class Form1
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
            this.filepathText = new System.Windows.Forms.TextBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.scanFilesButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderStorage = new System.Windows.Forms.DataGridView();
            this.folderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.folderStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // filepathText
            // 
            this.filepathText.Location = new System.Drawing.Point(13, 13);
            this.filepathText.Name = "filepathText";
            this.filepathText.Size = new System.Drawing.Size(371, 20);
            this.filepathText.TabIndex = 0;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(391, 13);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(112, 20);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Choose Folder";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // scanFilesButton
            // 
            this.scanFilesButton.Location = new System.Drawing.Point(391, 40);
            this.scanFilesButton.Name = "scanFilesButton";
            this.scanFilesButton.Size = new System.Drawing.Size(112, 23);
            this.scanFilesButton.TabIndex = 3;
            this.scanFilesButton.Text = "Scan Folder";
            this.scanFilesButton.UseVisualStyleBackColor = true;
            this.scanFilesButton.Click += new System.EventHandler(this.scanFilesButton_Click);
            // 
            // folderStorage
            // 
            this.folderStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.folderStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folderStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderColumn,
            this.sizeColumn});
            this.folderStorage.Location = new System.Drawing.Point(13, 69);
            this.folderStorage.Name = "folderStorage";
            this.folderStorage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.folderStorage.Size = new System.Drawing.Size(951, 329);
            this.folderStorage.TabIndex = 4;
            // 
            // folderColumn
            // 
            this.folderColumn.HeaderText = "Folder";
            this.folderColumn.Name = "folderColumn";
            this.folderColumn.ReadOnly = true;
            // 
            // sizeColumn
            // 
            this.sizeColumn.HeaderText = "Folder Size";
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.folderStorage);
            this.Controls.Add(this.scanFilesButton);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.filepathText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.folderStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filepathText;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button scanFilesButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView folderStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
    }
}

