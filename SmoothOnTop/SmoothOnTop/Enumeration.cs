using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoothOnTop
{
	public class Enumeration
	{
		public Enumeration()
		{
			this.Windows = new Dictionary<IntPtr, string>();
			NativeMethods.EnumWindows(this.EnumTheWindows, IntPtr.Zero);
		}

		public Dictionary<IntPtr, string> Windows { get; private set; }

		private bool EnumTheWindows(IntPtr hWnd, IntPtr lParam)
		{
			int size = NativeMethods.GetWindowTextLength(hWnd);
			if (size++ > 0 && NativeMethods.IsWindowVisible(hWnd))
			{
				StringBuilder sb = new StringBuilder(size);
				NativeMethods.GetWindowText(hWnd, sb, size);
				this.Windows.Add(hWnd, sb.ToString());
			}
			return true;
		}
	}
}
