using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO; 
using System.Speech.Synthesis;


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

        string my_db = "chat.log";
        char seperator = '_';
        bool text_to_speech = false;
        string global_placeholder = "Enter message...";

        string online = "Online";
        string typing = "Typing...";

        string bot_name = "Bot";
        string user_name = "Human";

        public static string command_prefix = "/";
        public static string on = "on";
        public static string off = "off";
        public static string speech = String.Format("{0}speech", command_prefix);
        public static string speech_on = String.Format("{0}:{1}", speech, on);
        public static string speech_off = String.Format("{0}:{1}", speech, off);
        public static string clear = String.Format("{0}clear", command_prefix);
        public static string exit = String.Format("{0}exit", command_prefix);

        //string bot_greeting = "Hello! Ask me anything:)";
        string bot_response_default = "Sorry, I don't know the answer.";
        string bot_wrong_command = "This command does not exist.";

        static ChatBot bot;
        SpeechSynthesizer reader = new SpeechSynthesizer();
        SoundPlayer SoundSend = new SoundPlayer("SOUND/SOUND1.wav");
        SoundPlayer SoundReceive = new SoundPlayer("SOUND/SOUND2.wav");
        #endregion

        #region FormControl
        private void Form_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();
            Utils.check_file(my_db);
            load_chat();
            tb_message_leave(sender, e);
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            // add_incoming_message(bot_greeting);
            // Changed because now we load previous chat
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
            Utils.remove_placeholder(tb_message, global_placeholder);
        }

        private void tb_message_leave(object sender, EventArgs e)
        {
            Utils.add_placeholder(tb_message, global_placeholder);
        }

        private void tb_message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_send_Click(sender, e);
            }
        }
        #endregion

        #region Chatting Ref
        public void load_chat()
        {
            using (StreamReader sr = new StreamReader(my_db))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] msg_info = line.Split(seperator);
                    string message = msg_info[1];
                    if (i % 2 == 0)
                    {
                        add_outgoing_message(message);
                    }
                    else
                    {
                        add_incoming_message(message);
                    }
                    i++;
                }
                // scroll to the bottom once finished loading.
                pnl_main.VerticalScroll.Value = pnl_main.VerticalScroll.Maximum;
                pnl_main.PerformLayout();

            }

        }
        public void execute_command(string command)
        {
            if (command == speech_on)
            {
                text_to_speech = true;
                add_incoming_message("Now I will use my wonderful voice.");
            }
            else if (command == speech_off)
            {
                text_to_speech = false;
                add_incoming_message("Okay, I will not use my voice.");
            }
            else if (command == clear)
            {
                File.Delete(my_db);
                pnl_main.Controls.Clear();
                add_incoming_message("Chat is cleared.");
            }
            else if (command == exit)
            {
                Application.Exit();
            }
            else
            {
                add_incoming_message(bot_wrong_command);
            }
            SoundReceive.Play();
        }
        #endregion

        #region Chatting
        private void btn_send_Click(object sender, EventArgs e)
        {
            string user_response = tb_message.Text.Trim();
            tb_message.Text = String.Empty;


            if (!string.IsNullOrEmpty(user_response)) {
                if (user_response.StartsWith(command_prefix)) {
                    string command = user_response.ToLower();
                    add_outgoing_message(command);
                    SoundSend.Play();
                    execute_command(command);
                }
                else
                {
                    add_outgoing_message(user_response);
                    Utils.save_to_db(my_db, seperator, user_name, user_response);
                    SoundSend.Play();

                    lbl_status.Text = typing;
                    tb_message.Enabled = false;

                    chat_with_bot(user_response);

                }
            }
        }

        public void chat_with_bot(string user_response)
        {
            string bot_response = bot.get_bot_response(user_response);

            if (string.IsNullOrEmpty(bot_response))
            {
                bot_response = bot_response_default;
            }

            // Make a Dynamic Timer to delay the bot's response to make it feel humanlike.
            // Time in milseconds - minimum delay of 0.5s plus 0.5s per character.
            var timer_bot = new Timer();
            timer_bot.Interval = 500 + (bot_response.Length * 50);

            timer_bot_tick(timer_bot, bot_response);

            timer_bot.Start();
        }

        public void timer_bot_tick(Timer timer_bot, string bot_response)
        {
            // When timer finishes
            timer_bot.Tick += (s, d) =>
            {
                tb_message.Enabled = true;

                // Message Received
                lbl_status.Text = online;
                add_incoming_message(bot_response);
                Utils.save_to_db(my_db, seperator, bot_name, bot_response);
                SoundReceive.Play();

                // Read out loud
                if (text_to_speech)
                {
                    reader.SpeakAsync(bot_response);
                }

                // End timer
                tb_message.Focus();
                timer_bot.Stop();
            };
        }
        #endregion

    }
}
