namespace EZTest
{
    partial class ucFeatureSelection
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
            this.featureSelectionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this._title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // featureSelectionLayout
            // 
            this.featureSelectionLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featureSelectionLayout.AutoScroll = true;
            this.featureSelectionLayout.Location = new System.Drawing.Point(76, 81);
            this.featureSelectionLayout.Name = "featureSelectionLayout";
            this.featureSelectionLayout.Size = new System.Drawing.Size(297, 294);
            this.featureSelectionLayout.TabIndex = 1;
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Location = new System.Drawing.Point(167, 30);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(118, 13);
            this._title.TabIndex = 2;
            this._title.Text = "Please Select A Project";
            // 
            // ucFeatureSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._title);
            this.Controls.Add(this.featureSelectionLayout);
            this.Name = "ucFeatureSelection";
            this.Size = new System.Drawing.Size(450, 397);
            this.Load += new System.EventHandler(this.ucFeatureSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel featureSelectionLayout;
        private System.Windows.Forms.Label _title;
    }
}
