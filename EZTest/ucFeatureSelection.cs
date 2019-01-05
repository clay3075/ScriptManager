using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZTest
{
    public partial class ucFeatureSelection : UserControl
    {
        private string _directoryPath = "";
        public ScreenManager ScreenManager { get; set; }

        public ucFeatureSelection()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => _title.Text;
            set => _title.Text = value;
        }

        public bool ShowBackButton
        {
            get => btnBack.Visible;
            set => btnBack.Visible = value;
        }

        public string DirectoryPath
        {
            get => _directoryPath;
            set
            {
                _directoryPath = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            var directoryContents = Directory.GetFileSystemEntries(DirectoryPath);
            foreach (var content in directoryContents)
            {
                // get the file attributes for file or directory
                var newPath = Path.Combine(DirectoryPath, content);
                FileAttributes attr = File.GetAttributes(newPath);
                FileSystemInfo tmpContentInfo;

                if (attr.HasFlag(FileAttributes.Directory))
                    tmpContentInfo = new DirectoryInfo(newPath);
                else
                    tmpContentInfo = new FileInfo(newPath);

                Button tmpButton = new Button();
                tmpButton.Height = 50;
                tmpButton.Width = 90;
                tmpButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                tmpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tmpButton.Text = tmpContentInfo.Name;
                tmpButton.Click += (sender, args) => ButtonClickEvent(tmpContentInfo);
                featureSelectionLayout.Controls.Add(tmpButton);
            }
        }

        private void ButtonClickEvent(FileSystemInfo content)
        {
            
            if (content.Attributes.HasFlag(FileAttributes.Directory))
            {
                var newScreen = new ucFeatureSelection();
                newScreen.DirectoryPath = content.FullName;
                newScreen.ScreenManager = ScreenManager;
                newScreen.ShowBackButton = true;
                
                ScreenManager.AddScreenAndShow(newScreen);
            }
            else
            {
                MessageBox.Show($"Run script {content.Name}");
            }
        }

        private void ucFeatureSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ScreenManager.PrevScreen();
        }
    }
}
