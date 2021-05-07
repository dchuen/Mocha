namespace Mocha
{
    partial class FormMocha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMocha));
            this.notifyIconMocha = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMocha = new System.Windows.Forms.Timer(this.components);
            this.cbDisplayRequired = new System.Windows.Forms.CheckBox();
            this.cbSystemRequired = new System.Windows.Forms.CheckBox();
            this.cbBoostAlwaysOn = new System.Windows.Forms.CheckBox();
            this.tpBoostOn = new System.Windows.Forms.DateTimePicker();
            this.tpBoostOff = new System.Windows.Forms.DateTimePicker();
            this.pnlDisplayBoost = new System.Windows.Forms.Panel();
            this.pnlSystemBoost = new System.Windows.Forms.Panel();
            this.lblNextDay = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconMocha
            // 
            this.notifyIconMocha.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconMocha.BalloonTipText = "Mocha In Tray";
            this.notifyIconMocha.BalloonTipTitle = "Mocha";
            this.notifyIconMocha.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMocha.Icon")));
            this.notifyIconMocha.Text = "Mocha In Tray";
            this.notifyIconMocha.Visible = true;
            this.notifyIconMocha.DoubleClick += new System.EventHandler(this.NotifyIconMocha_DoubleClick);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(164, 18);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Minimize";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mocha in Tray";
            // 
            // timerMocha
            // 
            this.timerMocha.Enabled = true;
            this.timerMocha.Interval = 5000;
            this.timerMocha.Tick += new System.EventHandler(this.timerMocha_Tick);
            // 
            // cbDisplayRequired
            // 
            this.cbDisplayRequired.AutoSize = true;
            this.cbDisplayRequired.Checked = true;
            this.cbDisplayRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisplayRequired.Location = new System.Drawing.Point(11, 59);
            this.cbDisplayRequired.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDisplayRequired.Name = "cbDisplayRequired";
            this.cbDisplayRequired.Size = new System.Drawing.Size(89, 17);
            this.cbDisplayRequired.TabIndex = 2;
            this.cbDisplayRequired.Text = "Display boost";
            this.cbDisplayRequired.UseVisualStyleBackColor = true;
            this.cbDisplayRequired.CheckedChanged += new System.EventHandler(this.cbDisplayRequired_CheckedChanged);
            // 
            // cbSystemRequired
            // 
            this.cbSystemRequired.AutoSize = true;
            this.cbSystemRequired.Checked = true;
            this.cbSystemRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSystemRequired.Location = new System.Drawing.Point(11, 79);
            this.cbSystemRequired.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSystemRequired.Name = "cbSystemRequired";
            this.cbSystemRequired.Size = new System.Drawing.Size(89, 17);
            this.cbSystemRequired.TabIndex = 3;
            this.cbSystemRequired.Text = "System boost";
            this.cbSystemRequired.UseVisualStyleBackColor = true;
            this.cbSystemRequired.CheckedChanged += new System.EventHandler(this.cbSystemRequired_CheckedChanged);
            // 
            // cbBoostAlwaysOn
            // 
            this.cbBoostAlwaysOn.AutoSize = true;
            this.cbBoostAlwaysOn.Location = new System.Drawing.Point(11, 101);
            this.cbBoostAlwaysOn.Name = "cbBoostAlwaysOn";
            this.cbBoostAlwaysOn.Size = new System.Drawing.Size(106, 17);
            this.cbBoostAlwaysOn.TabIndex = 4;
            this.cbBoostAlwaysOn.Text = "Boost Always On";
            this.cbBoostAlwaysOn.UseVisualStyleBackColor = true;
            this.cbBoostAlwaysOn.CheckedChanged += new System.EventHandler(this.cbBoostAlwaysOn_CheckedChanged);
            // 
            // tpBoostOn
            // 
            this.tpBoostOn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpBoostOn.Location = new System.Drawing.Point(3, 20);
            this.tpBoostOn.Name = "tpBoostOn";
            this.tpBoostOn.ShowUpDown = true;
            this.tpBoostOn.Size = new System.Drawing.Size(89, 20);
            this.tpBoostOn.TabIndex = 5;
            this.tpBoostOn.Value = new System.DateTime(2000, 1, 1, 7, 0, 0, 0);
            this.tpBoostOn.ValueChanged += new System.EventHandler(this.tpBoostOn_ValueChanged);
            // 
            // tpBoostOff
            // 
            this.tpBoostOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpBoostOff.Location = new System.Drawing.Point(113, 20);
            this.tpBoostOff.Name = "tpBoostOff";
            this.tpBoostOff.ShowUpDown = true;
            this.tpBoostOff.Size = new System.Drawing.Size(89, 20);
            this.tpBoostOff.TabIndex = 6;
            this.tpBoostOff.Value = new System.DateTime(2000, 1, 1, 18, 0, 0, 0);
            this.tpBoostOff.ValueChanged += new System.EventHandler(this.tpBoostOff_ValueChanged);
            // 
            // pnlDisplayBoost
            // 
            this.pnlDisplayBoost.Location = new System.Drawing.Point(102, 59);
            this.pnlDisplayBoost.Name = "pnlDisplayBoost";
            this.pnlDisplayBoost.Size = new System.Drawing.Size(15, 17);
            this.pnlDisplayBoost.TabIndex = 7;
            // 
            // pnlSystemBoost
            // 
            this.pnlSystemBoost.Location = new System.Drawing.Point(102, 79);
            this.pnlSystemBoost.Name = "pnlSystemBoost";
            this.pnlSystemBoost.Size = new System.Drawing.Size(15, 17);
            this.pnlSystemBoost.TabIndex = 8;
            // 
            // lblNextDay
            // 
            this.lblNextDay.AutoSize = true;
            this.lblNextDay.Location = new System.Drawing.Point(136, 4);
            this.lblNextDay.Name = "lblNextDay";
            this.lblNextDay.Size = new System.Drawing.Size(51, 13);
            this.lblNextDay.TabIndex = 9;
            this.lblNextDay.Text = "Next Day";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Controls.Add(this.label3);
            this.pnlSchedule.Controls.Add(this.label2);
            this.pnlSchedule.Controls.Add(this.tpBoostOff);
            this.pnlSchedule.Controls.Add(this.lblNextDay);
            this.pnlSchedule.Controls.Add(this.tpBoostOn);
            this.pnlSchedule.Location = new System.Drawing.Point(11, 124);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(207, 51);
            this.pnlSchedule.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To";
            // 
            // FormMocha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.pnlSchedule);
            this.Controls.Add(this.pnlSystemBoost);
            this.Controls.Add(this.pnlDisplayBoost);
            this.Controls.Add(this.cbBoostAlwaysOn);
            this.Controls.Add(this.cbSystemRequired);
            this.Controls.Add(this.cbDisplayRequired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "FormMocha";
            this.Text = "Mocha in Tray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMocha_Load);
            this.Shown += new System.EventHandler(this.FormMocha_Shown);
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMocha;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMocha;
        private System.Windows.Forms.CheckBox cbDisplayRequired;
        private System.Windows.Forms.CheckBox cbSystemRequired;
        private System.Windows.Forms.CheckBox cbBoostAlwaysOn;
        private System.Windows.Forms.DateTimePicker tpBoostOn;
        private System.Windows.Forms.DateTimePicker tpBoostOff;
        private System.Windows.Forms.Panel pnlDisplayBoost;
        private System.Windows.Forms.Panel pnlSystemBoost;
        private System.Windows.Forms.Label lblNextDay;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

