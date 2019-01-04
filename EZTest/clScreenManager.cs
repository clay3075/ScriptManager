using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EZTest
{
    public class ScreenManager
    {
        private readonly Control _screenPanel;
        private Stack<Control> _screenHistory = new Stack<Control>();
        private List<Control> _screens = new List<Control>();

        public ScreenManager(Control screenPanel, IList<Control> screens = null)
        {
            _screenPanel = screenPanel;
            _screens = screens == null ? _screens : new List<Control>(screens);
            if (_screens.Any())
            {
                _screenPanel.Controls.Add(_screens[0]);
            }
        }

        public void AddScreen(Control screen)
        {
            _screens.Add(screen);
        }

        public void PrevScreen()
        {
            var prevScreen = _screenHistory.Pop();
            if (_screenPanel.Controls.Count > 0)
                _screenPanel.Controls.RemoveAt(0);
            _screenPanel.Controls.Add(prevScreen);
        }

        public void NextScreen()
        {
            int nextScreenIndex = 0;
            if (_screenPanel.Controls.Count > 0)
            {
                var currScreen = _screenPanel.Controls[0];
                _screenHistory.Push(currScreen);
                nextScreenIndex = _screens.IndexOf(currScreen) + 1;
            }
            _screenPanel.Controls.Add(_screens[nextScreenIndex]);
        }

        public void ClearScreens()
        {
            foreach (var screen in _screenPanel.Controls)
            {
                _screenPanel.Controls.Remove((Control)screen);
                _screens = new List<Control>();
                _screenHistory = new Stack<Control>();
            }
        }
        
    }
}