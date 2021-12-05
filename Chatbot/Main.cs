using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Global Vars
        private bool dragging;
        private Point lastLocation;
        string online = "Online";
        string typing = "Typing...";
        string global_placeholder = "Enter message...";
        string bot_greeting = "Hello! Ask me anything:)";
        string bot_response = "Sorry, I don't know the answer.";
        #endregion

        #region Helper Functions
        public void remove_placeholder(TextBox textbox, string placeholder)
        {
            if (textbox.Text == placeholder)
            {
                textbox.Text = string.Empty;
                textbox.ForeColor = Color.Black;
            }
        }

        public void add_placeholder(TextBox textbox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.Text = placeholder;
                textbox.ForeColor = Color.Gray;
            }
        }

        public void get_bot_response()
        {
            lbl_status.Text = typing;
            timer_bot.Start();
        }
        #endregion

        #region FormControl
        private void Form_Load(object sender, EventArgs e)
        {
            tb_message_leave(sender, e);
            pnl_main.AutoScroll = false;
            pnl_main.HorizontalScroll.Enabled = false;
            pnl_main.HorizontalScroll.Visible = false;
            pnl_main.HorizontalScroll.Maximum = 0;
            pnl_main.AutoScroll = true;
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            add_incoming_message(bot_greeting);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            lastLocation = e.Location;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        #endregion

        #region UserControl
        void add_incoming_message (string message)
        {
            var bubble = new Components.uc_incoming();
            pnl_main.Controls.Add(bubble);
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;

        }
        void add_outgoing_message(string message)
        {
            var bubble = new Components.uc_outgoing();
            pnl_main.Controls.Add(bubble);
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }
        #endregion

        #region tb_message
        private void tb_message_enter(object sender, EventArgs e)
        {
            remove_placeholder(tb_message, global_placeholder);
        }

        private void tb_message_leave(object sender, EventArgs e)
        {
            add_placeholder(tb_message, global_placeholder);
        }

        private void tb_message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_send_Click(sender, e);
            }
        }
        #endregion

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_message.Text.Trim()))
            {
                add_outgoing_message(tb_message.Text.Trim());
                tb_message.Text = string.Empty;
                get_bot_response();
            }
        }

        private void timer_bot_Tick(object sender, EventArgs e)
        {
            timer_bot.Stop();
            lbl_status.Text = online;
            add_incoming_message(bot_response);
        }

    }
}
