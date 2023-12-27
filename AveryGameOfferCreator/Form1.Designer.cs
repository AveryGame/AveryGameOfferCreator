namespace AveryGameOfferCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MicroReward = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MicroChecked = new System.Windows.Forms.CheckBox();
            this.StatValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatRewardCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.uploadOfferToBackendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyOfferPayloadToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.getFieldsFromBackendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MicroReward)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 410);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MicroReward);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.MicroChecked);
            this.groupBox3.Controls.Add(this.StatValue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.StatName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.StatRewardCheck);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(280, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 369);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rewards";
            // 
            // MicroReward
            // 
            this.MicroReward.Enabled = false;
            this.MicroReward.Location = new System.Drawing.Point(127, 131);
            this.MicroReward.Name = "MicroReward";
            this.MicroReward.Size = new System.Drawing.Size(120, 23);
            this.MicroReward.TabIndex = 9;
            this.MicroReward.ValueChanged += new System.EventHandler(this.MicroReward_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Microtransational Reward";
            // 
            // MicroChecked
            // 
            this.MicroChecked.AutoSize = true;
            this.MicroChecked.Enabled = false;
            this.MicroChecked.Location = new System.Drawing.Point(127, 78);
            this.MicroChecked.Name = "MicroChecked";
            this.MicroChecked.Size = new System.Drawing.Size(167, 19);
            this.MicroChecked.TabIndex = 7;
            this.MicroChecked.Text = "Microtransactional Reward";
            this.MicroChecked.UseVisualStyleBackColor = true;
            this.MicroChecked.CheckedChanged += new System.EventHandler(this.MicroChecked_CheckedChanged);
            // 
            // StatValue
            // 
            this.StatValue.Enabled = false;
            this.StatValue.Location = new System.Drawing.Point(12, 188);
            this.StatValue.Name = "StatValue";
            this.StatValue.Size = new System.Drawing.Size(100, 23);
            this.StatValue.TabIndex = 6;
            this.StatValue.TextChanged += new System.EventHandler(this.StatValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stat Value";
            // 
            // StatName
            // 
            this.StatName.Enabled = false;
            this.StatName.Location = new System.Drawing.Point(12, 130);
            this.StatName.Name = "StatName";
            this.StatName.Size = new System.Drawing.Size(100, 23);
            this.StatName.TabIndex = 4;
            this.StatName.TextChanged += new System.EventHandler(this.StatName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stat Name";
            // 
            // StatRewardCheck
            // 
            this.StatRewardCheck.AutoSize = true;
            this.StatRewardCheck.Checked = true;
            this.StatRewardCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatRewardCheck.Enabled = false;
            this.StatRewardCheck.Location = new System.Drawing.Point(12, 78);
            this.StatRewardCheck.Name = "StatRewardCheck";
            this.StatRewardCheck.Size = new System.Drawing.Size(88, 19);
            this.StatRewardCheck.TabIndex = 2;
            this.StatRewardCheck.Text = "Stat Reward";
            this.StatRewardCheck.UseVisualStyleBackColor = true;
            this.StatRewardCheck.CheckedChanged += new System.EventHandler(this.StatRewardCheck_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Reward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 369);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Redemption Message";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Offer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cost";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(8, 280);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 240);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(190, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Microtransational Requirement";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(122, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 188);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promotional Code";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Promotional Offer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadOfferToBackendToolStripMenuItem,
            this.copyOfferPayloadToClipboardToolStripMenuItem,
            this.resetAllFieldsToolStripMenuItem,
            this.getFieldsFromBackendToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // uploadOfferToBackendToolStripMenuItem
            // 
            this.uploadOfferToBackendToolStripMenuItem.Name = "uploadOfferToBackendToolStripMenuItem";
            this.uploadOfferToBackendToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.uploadOfferToBackendToolStripMenuItem.Text = "Upload Offer To Backend";
            this.uploadOfferToBackendToolStripMenuItem.Click += new System.EventHandler(this.uploadOfferToBackendToolStripMenuItem_Click);
            // 
            // copyOfferPayloadToClipboardToolStripMenuItem
            // 
            this.copyOfferPayloadToClipboardToolStripMenuItem.Name = "copyOfferPayloadToClipboardToolStripMenuItem";
            this.copyOfferPayloadToClipboardToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.copyOfferPayloadToClipboardToolStripMenuItem.Text = "Copy Offer Payload To Clipboard";
            this.copyOfferPayloadToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyOfferPayloadToClipboardToolStripMenuItem_Click);
            // 
            // resetAllFieldsToolStripMenuItem
            // 
            this.resetAllFieldsToolStripMenuItem.Name = "resetAllFieldsToolStripMenuItem";
            this.resetAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.resetAllFieldsToolStripMenuItem.Text = "Reset All Fields";
            this.resetAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.resetAllFieldsToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Options";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // getFieldsFromBackendToolStripMenuItem
            // 
            this.getFieldsFromBackendToolStripMenuItem.Name = "getFieldsFromBackendToolStripMenuItem";
            this.getFieldsFromBackendToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.getFieldsFromBackendToolStripMenuItem.Text = "Get Fields from Backend";
            this.getFieldsFromBackendToolStripMenuItem.Click += new System.EventHandler(this.getFieldsFromBackendToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avery Game Offer Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MicroReward)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem copyOfferPayloadToClipboardToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStrip toolStrip1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox3;
        private Button button2;
        private ComboBox comboBox1;
        private ToolStripMenuItem uploadOfferToBackendToolStripMenuItem;
        private NumericUpDown MicroReward;
        private Label label7;
        private CheckBox MicroChecked;
        private TextBox StatValue;
        private Label label6;
        private TextBox StatName;
        private Label label5;
        private CheckBox StatRewardCheck;
        private ToolStripMenuItem resetAllFieldsToolStripMenuItem;
        private ToolStripMenuItem getFieldsFromBackendToolStripMenuItem;
    }
}