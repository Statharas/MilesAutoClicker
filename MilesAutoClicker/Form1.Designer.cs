namespace AutoClicker
{
    public partial class AutoClicker
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
            this.mscount = new System.Windows.Forms.NumericUpDown();
            this.Savebtn = new System.Windows.Forms.Button();
            this.AddNewF = new System.Windows.Forms.Button();
            this.RemoveF = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.AdvancedMode = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AdvancedPanel = new System.Windows.Forms.Panel();
            this.SimplePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SimpleRepeats = new System.Windows.Forms.NumericUpDown();
            this.SimpleRepeat = new System.Windows.Forms.RadioButton();
            this.SimpleNonstop = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SimplePickLoc = new System.Windows.Forms.Button();
            this.SimpleY = new System.Windows.Forms.NumericUpDown();
            this.SimpleX = new System.Windows.Forms.NumericUpDown();
            this.SimpleLocation = new System.Windows.Forms.RadioButton();
            this.SimpleMouseLocation = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleTimer = new System.Windows.Forms.NumericUpDown();
            this.SimpleKeybind = new System.Windows.Forms.Button();
            this.SimpleStart = new System.Windows.Forms.Button();
            this.SimpleStop = new System.Windows.Forms.Button();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SimpleLeftClick = new System.Windows.Forms.RadioButton();
            this.SimpleRightClick = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mscount)).BeginInit();
            this.Menus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.AdvancedPanel.SuspendLayout();
            this.SimplePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleRepeats)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleTimer)).BeginInit();
            this.CentralPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mscount
            // 
            this.mscount.Location = new System.Drawing.Point(11, 44);
            this.mscount.Name = "mscount";
            this.mscount.Size = new System.Drawing.Size(120, 20);
            this.mscount.TabIndex = 0;
            this.mscount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Savebtn.Location = new System.Drawing.Point(12, 381);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 1;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewF
            // 
            this.AddNewF.AccessibleName = "AddNew";
            this.AddNewF.Location = new System.Drawing.Point(3, 3);
            this.AddNewF.Name = "AddNewF";
            this.AddNewF.Size = new System.Drawing.Size(128, 23);
            this.AddNewF.TabIndex = 3;
            this.AddNewF.Text = "Add New Function";
            this.AddNewF.UseVisualStyleBackColor = true;
            this.AddNewF.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveF
            // 
            this.RemoveF.AccessibleName = "RemoveFunction";
            this.RemoveF.Location = new System.Drawing.Point(137, 3);
            this.RemoveF.Name = "RemoveF";
            this.RemoveF.Size = new System.Drawing.Size(128, 23);
            this.RemoveF.TabIndex = 4;
            this.RemoveF.Text = "Remove Function";
            this.RemoveF.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(288, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 424);
            this.listBox1.TabIndex = 5;
            // 
            // Menus
            // 
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdvancedMode});
            this.Menus.Location = new System.Drawing.Point(0, 0);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(496, 24);
            this.Menus.TabIndex = 6;
            this.Menus.Text = "menuStrip1";
            this.Menus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // AdvancedMode
            // 
            this.AdvancedMode.Checked = true;
            this.AdvancedMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AdvancedMode.Name = "AdvancedMode";
            this.AdvancedMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.AdvancedMode.Size = new System.Drawing.Size(72, 20);
            this.AdvancedMode.Text = "Advanced";
            this.AdvancedMode.Click += new System.EventHandler(this.AdvancedMode_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // AdvancedPanel
            // 
            this.AdvancedPanel.AutoSize = true;
            this.AdvancedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdvancedPanel.Controls.Add(this.listBox1);
            this.AdvancedPanel.Controls.Add(this.mscount);
            this.AdvancedPanel.Controls.Add(this.RemoveF);
            this.AdvancedPanel.Controls.Add(this.Savebtn);
            this.AdvancedPanel.Controls.Add(this.AddNewF);
            this.AdvancedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedPanel.Location = new System.Drawing.Point(0, 0);
            this.AdvancedPanel.Name = "AdvancedPanel";
            this.AdvancedPanel.Size = new System.Drawing.Size(496, 424);
            this.AdvancedPanel.TabIndex = 11;
            this.AdvancedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SimplePanel
            // 
            this.SimplePanel.Controls.Add(this.panel4);
            this.SimplePanel.Controls.Add(this.panel3);
            this.SimplePanel.Controls.Add(this.panel2);
            this.SimplePanel.Controls.Add(this.panel1);
            this.SimplePanel.Controls.Add(this.SimpleKeybind);
            this.SimplePanel.Controls.Add(this.SimpleStart);
            this.SimplePanel.Controls.Add(this.SimpleStop);
            this.SimplePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimplePanel.Location = new System.Drawing.Point(0, 0);
            this.SimplePanel.Name = "SimplePanel";
            this.SimplePanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
            this.SimplePanel.Size = new System.Drawing.Size(496, 424);
            this.SimplePanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SimpleRepeats);
            this.panel3.Controls.Add(this.SimpleRepeat);
            this.panel3.Controls.Add(this.SimpleNonstop);
            this.panel3.Location = new System.Drawing.Point(3, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 112);
            this.panel3.TabIndex = 7;
            // 
            // SimpleRepeats
            // 
            this.SimpleRepeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SimpleRepeats.Location = new System.Drawing.Point(10, 53);
            this.SimpleRepeats.Name = "SimpleRepeats";
            this.SimpleRepeats.Size = new System.Drawing.Size(116, 20);
            this.SimpleRepeats.TabIndex = 3;
            this.SimpleRepeats.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SimpleRepeats.ValueChanged += new System.EventHandler(this.SimpleTimer_ValueChanged);
            // 
            // SimpleRepeat
            // 
            this.SimpleRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SimpleRepeat.Checked = true;
            this.SimpleRepeat.Location = new System.Drawing.Point(10, 24);
            this.SimpleRepeat.Name = "SimpleRepeat";
            this.SimpleRepeat.Size = new System.Drawing.Size(112, 23);
            this.SimpleRepeat.TabIndex = 4;
            this.SimpleRepeat.TabStop = true;
            this.SimpleRepeat.Text = "Repeats";
            this.SimpleRepeat.UseVisualStyleBackColor = true;
            this.SimpleRepeat.CheckedChanged += new System.EventHandler(this.SimpleRepeat_CheckedChanged);
            // 
            // SimpleNonstop
            // 
            this.SimpleNonstop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SimpleNonstop.Location = new System.Drawing.Point(10, 3);
            this.SimpleNonstop.Name = "SimpleNonstop";
            this.SimpleNonstop.Size = new System.Drawing.Size(69, 18);
            this.SimpleNonstop.TabIndex = 5;
            this.SimpleNonstop.Text = "Non-stop";
            this.SimpleNonstop.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SimplePickLoc);
            this.panel2.Controls.Add(this.SimpleY);
            this.panel2.Controls.Add(this.SimpleX);
            this.panel2.Controls.Add(this.SimpleLocation);
            this.panel2.Controls.Add(this.SimpleMouseLocation);
            this.panel2.Location = new System.Drawing.Point(336, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 111);
            this.panel2.TabIndex = 7;
            // 
            // SimplePickLoc
            // 
            this.SimplePickLoc.Location = new System.Drawing.Point(43, 76);
            this.SimplePickLoc.Name = "SimplePickLoc";
            this.SimplePickLoc.Size = new System.Drawing.Size(75, 23);
            this.SimplePickLoc.TabIndex = 4;
            this.SimplePickLoc.Text = "Pick Location";
            this.SimplePickLoc.UseVisualStyleBackColor = true;
            this.SimplePickLoc.Click += new System.EventHandler(this.SimplePickLoc_Click);
            // 
            // SimpleY
            // 
            this.SimpleY.Location = new System.Drawing.Point(83, 50);
            this.SimpleY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SimpleY.Name = "SimpleY";
            this.SimpleY.Size = new System.Drawing.Size(69, 20);
            this.SimpleY.TabIndex = 3;
            // 
            // SimpleX
            // 
            this.SimpleX.Location = new System.Drawing.Point(3, 50);
            this.SimpleX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SimpleX.Name = "SimpleX";
            this.SimpleX.Size = new System.Drawing.Size(69, 20);
            this.SimpleX.TabIndex = 2;
            // 
            // SimpleLocation
            // 
            this.SimpleLocation.AutoSize = true;
            this.SimpleLocation.Location = new System.Drawing.Point(4, 27);
            this.SimpleLocation.Name = "SimpleLocation";
            this.SimpleLocation.Size = new System.Drawing.Size(148, 17);
            this.SimpleLocation.TabIndex = 1;
            this.SimpleLocation.Text = "At location (X, Y Absolute)";
            this.SimpleLocation.UseVisualStyleBackColor = true;
            // 
            // SimpleMouseLocation
            // 
            this.SimpleMouseLocation.AutoSize = true;
            this.SimpleMouseLocation.Checked = true;
            this.SimpleMouseLocation.Location = new System.Drawing.Point(4, 4);
            this.SimpleMouseLocation.Name = "SimpleMouseLocation";
            this.SimpleMouseLocation.Size = new System.Drawing.Size(101, 17);
            this.SimpleMouseLocation.TabIndex = 0;
            this.SimpleMouseLocation.TabStop = true;
            this.SimpleMouseLocation.Text = "Mouse Location";
            this.SimpleMouseLocation.UseVisualStyleBackColor = true;
            this.SimpleMouseLocation.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SimpleTimer);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 70);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Repeats every (ms)";
            // 
            // SimpleTimer
            // 
            this.SimpleTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SimpleTimer.Location = new System.Drawing.Point(10, 24);
            this.SimpleTimer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SimpleTimer.Name = "SimpleTimer";
            this.SimpleTimer.Size = new System.Drawing.Size(116, 20);
            this.SimpleTimer.TabIndex = 6;
            this.SimpleTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimpleTimer.ValueChanged += new System.EventHandler(this.SimpleTimer_ValueChanged_1);
            // 
            // SimpleKeybind
            // 
            this.SimpleKeybind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SimpleKeybind.Location = new System.Drawing.Point(168, 344);
            this.SimpleKeybind.Margin = new System.Windows.Forms.Padding(0);
            this.SimpleKeybind.Name = "SimpleKeybind";
            this.SimpleKeybind.Size = new System.Drawing.Size(160, 73);
            this.SimpleKeybind.TabIndex = 2;
            this.SimpleKeybind.Text = "Keybind";
            this.SimpleKeybind.UseVisualStyleBackColor = true;
            this.SimpleKeybind.Click += new System.EventHandler(this.SimpleKeybind_Click);
            // 
            // SimpleStart
            // 
            this.SimpleStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleStart.AutoSize = true;
            this.SimpleStart.Location = new System.Drawing.Point(0, 344);
            this.SimpleStart.Margin = new System.Windows.Forms.Padding(0);
            this.SimpleStart.Name = "SimpleStart";
            this.SimpleStart.Size = new System.Drawing.Size(160, 73);
            this.SimpleStart.TabIndex = 0;
            this.SimpleStart.Text = "Start";
            this.SimpleStart.UseVisualStyleBackColor = true;
            this.SimpleStart.Click += new System.EventHandler(this.SimpleStart_Click);
            // 
            // SimpleStop
            // 
            this.SimpleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleStop.AutoSize = true;
            this.SimpleStop.Enabled = false;
            this.SimpleStop.Location = new System.Drawing.Point(336, 344);
            this.SimpleStop.Margin = new System.Windows.Forms.Padding(0);
            this.SimpleStop.Name = "SimpleStop";
            this.SimpleStop.Size = new System.Drawing.Size(160, 73);
            this.SimpleStop.TabIndex = 1;
            this.SimpleStop.Text = "Stop";
            this.SimpleStop.UseVisualStyleBackColor = true;
            this.SimpleStop.Click += new System.EventHandler(this.SimpleStop_Click);
            // 
            // CentralPanel
            // 
            this.CentralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CentralPanel.Controls.Add(this.SimplePanel);
            this.CentralPanel.Controls.Add(this.AdvancedPanel);
            this.CentralPanel.Location = new System.Drawing.Point(0, 26);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(496, 424);
            this.CentralPanel.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SimpleRightClick);
            this.panel4.Controls.Add(this.SimpleLeftClick);
            this.panel4.Location = new System.Drawing.Point(166, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 100);
            this.panel4.TabIndex = 8;
            // 
            // SimpleLeftClick
            // 
            this.SimpleLeftClick.AutoSize = true;
            this.SimpleLeftClick.Checked = true;
            this.SimpleLeftClick.Location = new System.Drawing.Point(4, 5);
            this.SimpleLeftClick.Name = "SimpleLeftClick";
            this.SimpleLeftClick.Size = new System.Drawing.Size(69, 17);
            this.SimpleLeftClick.TabIndex = 0;
            this.SimpleLeftClick.TabStop = true;
            this.SimpleLeftClick.Text = "Left Click";
            this.SimpleLeftClick.UseVisualStyleBackColor = true;
            // 
            // SimpleRightClick
            // 
            this.SimpleRightClick.AutoSize = true;
            this.SimpleRightClick.Location = new System.Drawing.Point(4, 25);
            this.SimpleRightClick.Name = "SimpleRightClick";
            this.SimpleRightClick.Size = new System.Drawing.Size(76, 17);
            this.SimpleRightClick.TabIndex = 1;
            this.SimpleRightClick.Text = "Right Click";
            this.SimpleRightClick.UseVisualStyleBackColor = true;
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.CentralPanel);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.Menus;
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "AutoClicker";
            this.Text = "MilesAutoClicker";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mscount)).EndInit();
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.AdvancedPanel.ResumeLayout(false);
            this.SimplePanel.ResumeLayout(false);
            this.SimplePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimpleRepeats)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleTimer)).EndInit();
            this.CentralPanel.ResumeLayout(false);
            this.CentralPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown mscount;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button AddNewF;
        private System.Windows.Forms.Button RemoveF;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel AdvancedPanel;
        private System.Windows.Forms.Panel SimplePanel;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.RadioButton SimpleNonstop;
        private System.Windows.Forms.RadioButton SimpleRepeat;
        private System.Windows.Forms.NumericUpDown SimpleRepeats;
        private System.Windows.Forms.Button SimpleKeybind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton SimpleMouseLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SimpleLocation;
        private System.Windows.Forms.NumericUpDown SimpleX;
        private System.Windows.Forms.NumericUpDown SimpleY;
        private System.Windows.Forms.ToolStripMenuItem AdvancedMode;
        private System.Windows.Forms.NumericUpDown SimpleTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Button SimpleStart;
        public System.Windows.Forms.Button SimpleStop;
        private System.Windows.Forms.Button SimplePickLoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton SimpleRightClick;
        private System.Windows.Forms.RadioButton SimpleLeftClick;
    }
}

