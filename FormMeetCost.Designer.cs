namespace WinMeetCost
{
    partial class FormMeetCost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCost = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelAttendees = new System.Windows.Forms.Label();
            this.labelPlusAttendee = new System.Windows.Forms.Label();
            this.labelMinusAttendee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCost.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelCost.Location = new System.Drawing.Point(0, 55);
            this.labelCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(195, 85);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "0 kr";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelAttendees
            // 
            this.labelAttendees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAttendees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAttendees.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelAttendees.Location = new System.Drawing.Point(56, 25);
            this.labelAttendees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttendees.Name = "labelAttendees";
            this.labelAttendees.Size = new System.Drawing.Size(82, 42);
            this.labelAttendees.TabIndex = 1;
            this.labelAttendees.Text = "5☺";
            this.labelAttendees.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPlusAttendee
            // 
            this.labelPlusAttendee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPlusAttendee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlusAttendee.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPlusAttendee.Location = new System.Drawing.Point(138, 25);
            this.labelPlusAttendee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlusAttendee.Name = "labelPlusAttendee";
            this.labelPlusAttendee.Size = new System.Drawing.Size(22, 42);
            this.labelPlusAttendee.TabIndex = 2;
            this.labelPlusAttendee.Text = "+";
            this.labelPlusAttendee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPlusAttendee.Click += new System.EventHandler(this.labelPlusAttendee_Click);
            // 
            // labelMinusAttendee
            // 
            this.labelMinusAttendee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinusAttendee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinusAttendee.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelMinusAttendee.Location = new System.Drawing.Point(42, 25);
            this.labelMinusAttendee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinusAttendee.Name = "labelMinusAttendee";
            this.labelMinusAttendee.Size = new System.Drawing.Size(23, 42);
            this.labelMinusAttendee.TabIndex = 3;
            this.labelMinusAttendee.Text = "-";
            this.labelMinusAttendee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelMinusAttendee.Click += new System.EventHandler(this.labelMinusAttendee_Click);
            // 
            // FormMeetCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 140);
            this.Controls.Add(this.labelMinusAttendee);
            this.Controls.Add(this.labelPlusAttendee);
            this.Controls.Add(this.labelAttendees);
            this.Controls.Add(this.labelCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMeetCost";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.FormCountdown_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelCost;
        private System.Windows.Forms.Timer timer;
        private Label labelAttendees;
        private Label labelPlusAttendee;
        private Label labelMinusAttendee;
    }
}