﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    class RichTextBoxEx : RichTextBox
    {
        private const int WM_SETCURSOR = 0x20;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SetCursor(IntPtr hCursor);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SETCURSOR)
            {
                if (SelectionType == RichTextBoxSelectionTypes.Object)
                {
                    // Necessary to avoid recursive calls
                    if (Cursor != Cursors.Cross)
                    {
                        Cursor = Cursors.Cross;
                    }
                }
                else
                {
                    // Necessary to avoid recursive calls
                    if (Cursor != Cursors.IBeam)
                    {
                        Cursor = Cursors.IBeam;
                    }
                }

                SetCursor(Cursor.Handle);
                return;
            }

            base.WndProc(ref m);
        }
    }
}
