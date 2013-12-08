using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmoothOnTop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonEnumerate_Click(object sender, EventArgs e)
		{
			var enumeration = new Enumeration();
			this.listBoxWindows.Items.Clear();
			foreach (var item in enumeration.Windows)
			{
				this.listBoxWindows.Items.Add(new WindowItem(item.Key, item.Value));
			}
		}

		private class WindowItem
		{
			public WindowItem(IntPtr hwnd, string name)
			{
				this.Hwnd = hwnd;
				this.Name = name;
			}

			public IntPtr Hwnd { get; private set; }
			public string Name { get; private set; }

			public override string ToString()
			{
				return this.Name;
			}
		}

		private IntPtr MakePosValue(bool alwaysOnTop)
		{
			if (alwaysOnTop)
			{
				return (IntPtr)(-1);
			}
			else
			{
				return (IntPtr)(-2);
			}
		}

		private void MakeAlwaysOnTop(IntPtr hwnd, bool yes)
		{
			var arg2 = MakePosValue(yes);
			NativeMethods.SetWindowPos(hwnd, arg2, 0, 0, 0, 0, SetWindowPosFlags.IgnoreMove | SetWindowPosFlags.IgnoreResize);
		}

		private WindowItem GetSelectedItem()
		{
			var item = this.listBoxWindows.SelectedItem as WindowItem;
			return item;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var item = this.GetSelectedItem();
			if (item != null)
			{
				this.MakeAlwaysOnTop(item.Hwnd, true);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var item = this.GetSelectedItem();
			if (item != null)
			{
				this.MakeAlwaysOnTop(item.Hwnd, false);
			}
		}
	}
}
