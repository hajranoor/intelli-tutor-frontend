using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.CustomComponent
{
    internal class NoCaretRichTextBox : RichTextBox
    {
        private const int WM_SETFOCUS = 0x0007;
        private const int WM_SETCURSOR = 0x0020;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SETFOCUS || m.Msg == WM_SETCURSOR)
            {
                // Ignore the focus and cursor messages to prevent the caret from being displayed
                return;
            }

            base.WndProc(ref m);
        }
    }
}
