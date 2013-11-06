using System;
using System.Windows;
using System.Collections.Generic;

namespace LearningDataBinding
{
    public class HidableWindow:Window
    {
        private static HashSet<HidableWindow> WindowsToBeClosed = new HashSet<HidableWindow>();
        private static bool IsShootingDown = false;

        public static void CloseAllHiddenWindows()
        {
            IsShootingDown = true;
            foreach (HidableWindow w in WindowsToBeClosed)
            {
                w.Close();
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (IsShootingDown)
            {
                base.OnClosing(e);
            }
            else
            {
                e.Cancel = true;
                base.Hide();
                WindowsToBeClosed.Add(this);
            }
        }
        
    }
}
