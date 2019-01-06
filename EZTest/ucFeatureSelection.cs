using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptManager
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

                Button tmpButton = new Button
                {
                    Height = 50,
                    Width = 90,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Text = tmpContentInfo.Name
                };
                tmpButton.Click += (sender, args) => ButtonClickEvent(tmpContentInfo);
                featureSelectionLayout.Controls.Add(tmpButton);
            }
        }

        private void ButtonClickEvent(FileSystemInfo content)
        {
            
            if (content.Attributes.HasFlag(FileAttributes.Directory))
            {
                var newScreen = new ucFeatureSelection
                {
                    DirectoryPath = content.FullName,
                    ScreenManager = ScreenManager,
                    ShowBackButton = true
                };

                ScreenManager.AddScreenAndShow(newScreen);
            }
            else
            {
                var cmd = "";
                switch (content.Extension)
                {
                    case ".py":
                        cmd = $"python {content.FullName}";
                        break;
                    case ".rb":
                        cmd = $"ruby {content.FullName}";
                        break;
                    default:
                        break;
                }
                RunCMD(cmd);
            }
        }

        private void RunCMD(string cmd)
        {
            var tmpProcess = new Process();
            var startInfo = new ProcessStartInfo()
            {
                Arguments = $@"/C {cmd}",
                FileName = "cmd.exe"
            };
            tmpProcess.StartInfo = startInfo;
            tmpProcess.Start();
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
