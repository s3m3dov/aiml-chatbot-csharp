using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chatbot
{
    public static class Utils
    {
        public static int GetTextHeight(Label label)
        { 
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
