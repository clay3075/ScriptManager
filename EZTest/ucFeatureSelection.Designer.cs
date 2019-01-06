namespace ScriptManager
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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // featureSelectionLayout
            // 
            this.featureSelectionLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featureSelectionLayout.AutoScroll = true;
            this.featureSelectionLayout.BackColor = System.Drawing.SystemColors.Control;
            this.featureSelectionLayout.Location = new System.Drawing.Point(203, 193);
            this.featureSelectionLayout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.featureSelectionLayout.Name = "featureSelectionLayout";
            this.featureSelectionLayout.Size = new System.Drawing.Size(817, 695);
            this.featureSelectionLayout.TabIndex = 1;
            // 
            // _title
            // 
            this._title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._title.AutoSize = true;
            this._title.Location = new System.Drawing.Point(445, 72);
            this._title.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(312, 32);
            this._title.TabIndex = 2;
            this._title.Text = "Please Select A Project";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(37, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 65);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucFeatureSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this._title);
            this.Controls.Add(this.featureSelectionLayout);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ucFeatureSelection";
            this.Size = new System.Drawing.Size(1199, 951);
            this.Load += new System.EventHandler(this.ucFeatureSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel featureSelectionLayout;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Button btnBack;
    }
}
