namespace YEMEK_PROGRAMI.Forms
{
    partial class yemekListesiSecme
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
            this.db_yemekList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // db_yemekList
            // 
            this.db_yemekList.FormattingEnabled = true;
            this.db_yemekList.Location = new System.Drawing.Point(23, 23);
            this.db_yemekList.Name = "db_yemekList";
            this.db_yemekList.Size = new System.Drawing.Size(120, 225);
            this.db_yemekList.TabIndex = 0;
            this.db_yemekList.DoubleClick += new System.EventHandler(this.db_yemekList_DoubleClick);
            // 
            // yemekListesiSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 279);
            this.Controls.Add(this.db_yemekList);
            this.Name = "yemekListesiSecme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox db_yemekList;
    }
}