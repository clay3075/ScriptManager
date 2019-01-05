using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZTest
{
    public partial class MainForm : Form
    {
        private ScreenManager _screenManager;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _screenManager = new ScreenManager(screenPanel);
            var newScreen = new ucFeatureSelection
            {
                ScreenManager = _screenManager,
                DirectoryPath = @"c:\users\cjred\desktop"
            };
            _screenManager.AddScreen(newScreen);
            screenPanel.Update();
        }
    }
}
