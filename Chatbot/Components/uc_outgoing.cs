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
    public partial class uc_outgoing : UserControl
    {
        public uc_outgoing()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return lbl_msg_outgoing.Text;
            }
            set
            {
                lbl_msg_outgoing.Text = value;
                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            lbl_msg_outgoing.Location = new Point(pb_outgoing.Location.X - lbl_msg_outgoing.Width - 10, 15);

            lbl_msg_outgoing.Height = Utils.GetTextHeight(lbl_msg_outgoing) + 40;

            this.Height = lbl_msg_outgoing.Height + 30;

        }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
