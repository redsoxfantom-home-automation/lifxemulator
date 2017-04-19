namespace LifxEmulator.Views
{
    partial class BulbSelection
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
            this.mBulbComboBox = new System.Windows.Forms.ComboBox();
            this.mBulbMeasurandsBox = new System.Windows.Forms.GroupBox();
            this.mSelectedBulbMeasurandsPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mBulbMeasurandsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mBulbComboBox
            // 
            this.mBulbComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mBulbComboBox.FormattingEnabled = true;
            this.mBulbComboBox.Location = new System.Drawing.Point(3, 3);
            this.mBulbComboBox.Name = "mBulbComboBox";
            this.mBulbComboBox.Size = new System.Drawing.Size(428, 21);
            this.mBulbComboBox.TabIndex = 0;
            this.mBulbComboBox.SelectedIndexChanged += new System.EventHandler(this.mBulbComboBox_SelectedIndexChanged);
            // 
            // mBulbMeasurandsBox
            // 
            this.mBulbMeasurandsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mBulbMeasurandsBox.Controls.Add(this.mSelectedBulbMeasurandsPanel);
            this.mBulbMeasurandsBox.Location = new System.Drawing.Point(3, 30);
            this.mBulbMeasurandsBox.Name = "mBulbMeasurandsBox";
            this.mBulbMeasurandsBox.Size = new System.Drawing.Size(428, 609);
            this.mBulbMeasurandsBox.TabIndex = 1;
            this.mBulbMeasurandsBox.TabStop = false;
            this.mBulbMeasurandsBox.Text = "Bulb Measurands";
            // 
            // mSelectedBulbMeasurandsPanel
            // 
            this.mSelectedBulbMeasurandsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mSelectedBulbMeasurandsPanel.AutoSize = true;
            this.mSelectedBulbMeasurandsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mSelectedBulbMeasurandsPanel.Location = new System.Drawing.Point(6, 19);
            this.mSelectedBulbMeasurandsPanel.Name = "mSelectedBulbMeasurandsPanel";
            this.mSelectedBulbMeasurandsPanel.Size = new System.Drawing.Size(0, 0);
            this.mSelectedBulbMeasurandsPanel.TabIndex = 0;
            // 
            // BulbSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mBulbMeasurandsBox);
            this.Controls.Add(this.mBulbComboBox);
            this.Name = "BulbSelection";
            this.Size = new System.Drawing.Size(434, 642);
            this.mBulbMeasurandsBox.ResumeLayout(false);
            this.mBulbMeasurandsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mBulbComboBox;
        private System.Windows.Forms.GroupBox mBulbMeasurandsBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel mSelectedBulbMeasurandsPanel;
    }
}
