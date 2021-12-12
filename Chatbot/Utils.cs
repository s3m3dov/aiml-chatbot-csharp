using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Chatbot
{
    public static class Utils
    {
        #region File
        public static void check_file(string filename)
        {
            if (!File.Exists(filename))
            {
                var file = File.Create(filename);
                file.Close();
            }
        }

        public static void save_to_db(string db_name, char seperator, params string[] data)
        {
            StreamWriter sw = new StreamWriter(db_name, append: true);
            foreach (string data_field in data)
            {
                sw.Write(data_field + seperator);
            }
            sw.Write("\r\n");
            sw.Close();
        }
        #endregion

        #region Placeholder
        public static void remove_placeholder(TextBox textbox, string placeholder)
        {
            if (textbox.Text == placeholder)
            {
                textbox.Text = string.Empty;
                textbox.ForeColor = Color.Black;
            }
        }
        public static void add_placeholder(TextBox textbox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.Text = placeholder;
                textbox.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Text
        public static int GetTextHeight(Label label)
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
        #endregion
    }
}
