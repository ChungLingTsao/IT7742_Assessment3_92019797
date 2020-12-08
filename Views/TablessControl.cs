/*
 * TablessControl.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Used to create a Tabless tabbedpanel form element
 */

using System;
using System.Windows.Forms;

namespace Assessment3
{
    // Custom panel that is able to hide the tab header at runtime, but is shown in Designer mode
    // TabControl is used to allow easier control when switching between panels in Designer mode
    // Code from: https://stackoverflow.com/a/6954785
    public class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
}