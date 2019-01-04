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
            this.titleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.featureSelectionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // titleLayout
            // 
            this.titleLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleLayout.Location = new System.Drawing.Point(0, 0);
            this.titleLayout.Name = "titleLayout";
            this.titleLayout.Size = new System.Drawing.Size(450, 57);
            this.titleLayout.TabIndex = 0;
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
            // ucFeatureSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.featureSelectionLayout);
            this.Controls.Add(this.titleLayout);
            this.Name = "ucFeatureSelection";
            this.Size = new System.Drawing.Size(450, 397);
            this.Load += new System.EventHandler(this.ucFeatureSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel titleLayout;
        private System.Windows.Forms.FlowLayoutPanel featureSelectionLayout;
    }
}
