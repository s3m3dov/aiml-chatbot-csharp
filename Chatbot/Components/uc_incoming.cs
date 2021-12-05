using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot.Components
{
    public partial class uc_incoming : UserControl
    {
        public uc_incoming()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return lbl_msg_incoming.Text;
            }
            set
            {
                lbl_msg_incoming.Text = value;
                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            lbl_msg_incoming.Location = new Point(pb_incoming.Location.X + pb_incoming.Width + 10, 15);

            lbl_msg_incoming.Height = Utils.GetTextHeight(lbl_msg_incoming) + 30;

            this.Height = lbl_msg_incoming.Height + 30;
        }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
