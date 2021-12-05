
namespace Chatbot
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pb_bot = new System.Windows.Forms.PictureBox();
            this.pnl_btm = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.timer_bot = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot)).BeginInit();
            this.pnl_btm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_top.Controls.Add(this.lbl_status);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pb_bot);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(446, 102);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lbl_status.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_status.Location = new System.Drawing.Point(87, 56);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(46, 19);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "online";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Chatbot.Properties.Resources.icons8_cancel;
            this.btn_close.Location = new System.Drawing.Point(411, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name.Location = new System.Drawing.Point(85, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(84, 28);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chatbot";
            // 
            // pb_bot
            // 
            this.pb_bot.Image = global::Chatbot.Properties.Resources.icons8_bot_light;
            this.pb_bot.Location = new System.Drawing.Point(16, 21);
            this.pb_bot.Name = "pb_bot";
            this.pb_bot.Size = new System.Drawing.Size(64, 64);
            this.pb_bot.TabIndex = 1;
            this.pb_bot.TabStop = false;
            // 
            // pnl_btm
            // 
            this.pnl_btm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_btm.Controls.Add(this.btn_send);
            this.pnl_btm.Controls.Add(this.tb_message);
            this.pnl_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btm.Location = new System.Drawing.Point(0, 673);
            this.pnl_btm.Name = "pnl_btm";
            this.pnl_btm.Size = new System.Drawing.Size(446, 90);
            this.pnl_btm.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
            this.btn_send.Location = new System.Drawing.Point(386, 26);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(40, 40);
            this.btn_send.TabIndex = 3;
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // tb_message
            // 
            this.tb_message.AutoCompleteCustomSource.AddRange(new string[] {
            "Hi!",
            "Hello!",
            "How are you doing?",
            "Bye!"});
            this.tb_message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.Location = new System.Drawing.Point(15, 12);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(365, 65);
            this.tb_message.TabIndex = 0;
            this.tb_message.Enter += new System.EventHandler(this.tb_message_enter);
            this.tb_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_message_KeyUp);
            // 
            // timer_bot
            // 
            this.timer_bot.Tick += new System.EventHandler(this.timer_bot_Tick);
            // 
            // pnl_main
            // 
            this.pnl_main.AutoScroll = true;
            this.pnl_main.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_main.Location = new System.Drawing.Point(0, 102);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(446, 571);
            this.pnl_main.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 763);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_btm);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatbot";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot)).EndInit();
            this.pnl_btm.ResumeLayout(false);
            this.pnl_btm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pb_bot;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel pnl_btm;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Timer timer_bot;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_main;
    }
}

