namespace LifxEmulator.Views
{
    partial class BulbMeasurands
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mMeasurandsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // mMeasurandsTable
            // 
            this.mMeasurandsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mMeasurandsTable.AutoSize = true;
            this.mMeasurandsTable.ColumnCount = 2;
            this.mMeasurandsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mMeasurandsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mMeasurandsTable.Location = new System.Drawing.Point(4, 9);
            this.mMeasurandsTable.Name = "mMeasurandsTable";
            this.mMeasurandsTable.RowCount = 1;
            this.mMeasurandsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mMeasurandsTable.Size = new System.Drawing.Size(2, 0);
            this.mMeasurandsTable.TabIndex = 0;
            // 
            // BulbMeasurands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.mMeasurandsTable);
            this.Name = "BulbMeasurands";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(9, 12);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mMeasurandsTable;
    }
}
