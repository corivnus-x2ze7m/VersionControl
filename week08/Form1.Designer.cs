
namespace week08
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.creteaTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 18);
            this.panel1.TabIndex = 0;
            // 
            // creteaTimer
            // 
            this.creteaTimer.Enabled = true;
            this.creteaTimer.Interval = 3000;
            this.creteaTimer.Tick += new System.EventHandler(this.creteaTimer_Tick);
            // 
            // conveyTimer
            // 
            this.conveyTimer.Enabled = true;
            this.conveyTimer.Interval = 10;
            this.conveyTimer.Tick += new System.EventHandler(this.conveyTimer_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(805, 542);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer creteaTimer;
        private System.Windows.Forms.Timer conveyTimer;
    }
}

