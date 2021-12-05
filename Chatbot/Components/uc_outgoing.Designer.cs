
namespace Chatbot.Components
{
    partial class uc_outgoing
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_msg_outgoing = new System.Windows.Forms.Label();
            this.pb_outgoing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_outgoing)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_msg_outgoing
            // 
            this.lbl_msg_outgoing.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_msg_outgoing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_outgoing.Location = new System.Drawing.Point(62, 20);
            this.lbl_msg_outgoing.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_msg_outgoing.Name = "lbl_msg_outgoing";
            this.lbl_msg_outgoing.Size = new System.Drawing.Size(300, 27);
            this.lbl_msg_outgoing.TabIndex = 1;
            this.lbl_msg_outgoing.Text = "How are u doing?";
            // 
            // pb_outgoing
            // 
            this.pb_outgoing.Image = global::Chatbot.Properties.Resources.icons8_user_dark;
            this.pb_outgoing.Location = new System.Drawing.Point(371, 7);
            this.pb_outgoing.Name = "pb_outgoing";
            this.pb_outgoing.Size = new System.Drawing.Size(48, 48);
            this.pb_outgoing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_outgoing.TabIndex = 0;
            this.pb_outgoing.TabStop = false;
            // 
            // uc_outgoing
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_msg_outgoing);
            this.Controls.Add(this.pb_outgoing);
            this.Name = "uc_outgoing";
            this.Size = new System.Drawing.Size(430, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pb_outgoing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_outgoing;
        private System.Windows.Forms.Label lbl_msg_outgoing;
    }
}
