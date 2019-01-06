namespace ScriptManager
{
    partial class MainForm
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
            this.screenPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.Location = new System.Drawing.Point(0, 0);
            this.screenPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(1199, 951);
            this.screenPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 944);
            this.Controls.Add(this.screenPanel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1232, 1032);
            this.MinimumSize = new System.Drawing.Size(1232, 1032);
            this.Name = "MainForm";
            this.Text = "ScriptManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
    }
}

