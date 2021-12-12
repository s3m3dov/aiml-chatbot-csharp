using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace Chatbot
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
    public class ChatBot
    {
        const string user_id = "Alexa";
        private Bot myBot;
        private User myUser;

        public ChatBot()
        {
            myBot = new Bot(); 
            myUser = new User(user_id, myBot);
            Initialize();
        }

        // Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            // string path = String.Format("{0}\\{1}", Path.Combine(Environment.CurrentDirectory), Path.Combine("config", "Settings.xml"));
            myBot.loadSettings();
            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            myBot.isAcceptingUserInput = true;
        }

        // Given an input string, finds a response using AIMLbot lib
        public String get_bot_response(String input)
        {
            Request request = new Request(input, myUser, myBot);
            Result result = myBot.Chat(request);
            return (result.Output);
        }
    }
}
