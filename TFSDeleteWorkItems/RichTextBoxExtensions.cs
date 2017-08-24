using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFSDeleteWorkItems
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.ScrollToCaret();
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(DateTime.Now.ToShortTimeString() + " >> "+ text);
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendTextWithNewLine(this RichTextBox box, string text, Color color)
        {
            AppendText(box, text, color);
            box.AppendText(Environment.NewLine);
            box.ScrollToCaret();

        }
    }
}
