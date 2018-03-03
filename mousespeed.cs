
using System;
using System.ComponentModel;
using System.Drawing;

using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

using ROS;
public class WinAPI
{
    [DllImport("user32.dll", CharSet = CharSet.Auto),]
    public static extern int SystemParametersInfo(uint uiAction, uint uiParam, uint pvParam, uint fWinIni);
}