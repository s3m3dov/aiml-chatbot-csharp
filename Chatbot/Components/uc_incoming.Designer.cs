
namespace Chatbot.Components
{
    partial class uc_incoming
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
            this.lbl_msg_incoming = new System.Windows.Forms.Label();
            this.pb_incoming = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_incoming)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_msg_incoming
            // 
            this.lbl_msg_incoming.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_msg_incoming.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_incoming.Location = new System.Drawing.Point(74, 21);
            this.lbl_msg_incoming.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_msg_incoming.Name = "lbl_msg_incoming";
            this.lbl_msg_incoming.Size = new System.Drawing.Size(300, 27);
            this.lbl_msg_incoming.TabIndex = 2;
            this.lbl_msg_incoming.Text = "How are u doing?";
            // 
            // pb_incoming
            // 
            this.pb_incoming.Image = global::Chatbot.Properties.Resources.chatbot;
            this.pb_incoming.Location = new System.Drawing.Point(14, 2);
            this.pb_incoming.Name = "pb_incoming";
            this.pb_incoming.Size = new System.Drawing.Size(48, 48);
            this.pb_incoming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_incoming.TabIndex = 0;
            this.pb_incoming.TabStop = false;
            // 
            // uc_incoming
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_msg_incoming);
            this.Controls.Add(this.pb_incoming);
            this.Name = "uc_incoming";
            this.Size = new System.Drawing.Size(430, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pb_incoming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_incoming;
        private System.Windows.Forms.Label lbl_msg_incoming;
    }
}
