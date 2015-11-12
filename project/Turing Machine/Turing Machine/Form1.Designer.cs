namespace Turing_Machine
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txt_aktStripPos = new System.Windows.Forms.TextBox();
            this.txt_strip = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd_step = new System.Windows.Forms.Button();
            this.txt_aktState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.txt_test2InputLength = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmd_test2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_test1InputLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmd_test1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_emtySymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rejectState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_acceptState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_startState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_transitions = new Turing_Machine.RichTextBoxEx();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testingToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1051, 564);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txt_aktStripPos);
            this.splitContainer3.Panel1.Controls.Add(this.txt_strip);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.cmd_step);
            this.splitContainer3.Panel1.Controls.Add(this.txt_aktState);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.cmd_reset);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txt_test2InputLength);
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.cmd_test2);
            this.splitContainer3.Panel2.Controls.Add(this.label12);
            this.splitContainer3.Panel2.Controls.Add(this.txt_test1InputLength);
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.cmd_test1);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Size = new System.Drawing.Size(477, 564);
            this.splitContainer3.SplitterDistance = 198;
            this.splitContainer3.TabIndex = 0;
            // 
            // txt_aktStripPos
            // 
            this.txt_aktStripPos.Location = new System.Drawing.Point(221, 72);
            this.txt_aktStripPos.Name = "txt_aktStripPos";
            this.txt_aktStripPos.Size = new System.Drawing.Size(53, 20);
            this.txt_aktStripPos.TabIndex = 11;
            this.txt_aktStripPos.Text = "0";
            this.txt_aktStripPos.TextChanged += new System.EventHandler(this.txt_aktStripPos_TextChanged);
            // 
            // txt_strip
            // 
            this.txt_strip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_strip.Location = new System.Drawing.Point(23, 127);
            this.txt_strip.Name = "txt_strip";
            this.txt_strip.Size = new System.Drawing.Size(437, 34);
            this.txt_strip.TabIndex = 2;
            this.txt_strip.Text = "";
            this.txt_strip.TextChanged += new System.EventHandler(this.txt_strip_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "strip position:";
            // 
            // cmd_step
            // 
            this.cmd_step.Location = new System.Drawing.Point(104, 20);
            this.cmd_step.Name = "cmd_step";
            this.cmd_step.Size = new System.Drawing.Size(75, 23);
            this.cmd_step.TabIndex = 1;
            this.cmd_step.Text = "step";
            this.cmd_step.UseVisualStyleBackColor = true;
            this.cmd_step.Click += new System.EventHandler(this.cmd_step_Click);
            // 
            // txt_aktState
            // 
            this.txt_aktState.Location = new System.Drawing.Point(65, 72);
            this.txt_aktState.Name = "txt_aktState";
            this.txt_aktState.Size = new System.Drawing.Size(53, 20);
            this.txt_aktState.TabIndex = 9;
            this.txt_aktState.Text = "Q0";
            this.txt_aktState.TextChanged += new System.EventHandler(this.txt_aktState_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "state:";
            // 
            // cmd_reset
            // 
            this.cmd_reset.Location = new System.Drawing.Point(23, 20);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(75, 23);
            this.cmd_reset.TabIndex = 0;
            this.cmd_reset.Text = "reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // txt_test2InputLength
            // 
            this.txt_test2InputLength.Location = new System.Drawing.Point(298, 205);
            this.txt_test2InputLength.Name = "txt_test2InputLength";
            this.txt_test2InputLength.Size = new System.Drawing.Size(53, 20);
            this.txt_test2InputLength.TabIndex = 12;
            this.txt_test2InputLength.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "input length:";
            // 
            // cmd_test2
            // 
            this.cmd_test2.Location = new System.Drawing.Point(369, 203);
            this.cmd_test2.Name = "cmd_test2";
            this.cmd_test2.Size = new System.Drawing.Size(91, 23);
            this.cmd_test2.TabIndex = 11;
            this.cmd_test2.Text = "test";
            this.cmd_test2.UseVisualStyleBackColor = true;
            this.cmd_test2.Click += new System.EventHandler(this.cmd_test2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "L={ ww|w∈{0,1}* }";
            // 
            // txt_test1InputLength
            // 
            this.txt_test1InputLength.Location = new System.Drawing.Point(298, 66);
            this.txt_test1InputLength.Name = "txt_test1InputLength";
            this.txt_test1InputLength.Size = new System.Drawing.Size(53, 20);
            this.txt_test1InputLength.TabIndex = 8;
            this.txt_test1InputLength.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Test 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "input length:";
            // 
            // cmd_test1
            // 
            this.cmd_test1.Location = new System.Drawing.Point(369, 64);
            this.cmd_test1.Name = "cmd_test1";
            this.cmd_test1.Size = new System.Drawing.Size(91, 23);
            this.cmd_test1.TabIndex = 2;
            this.cmd_test1.Text = "test";
            this.cmd_test1.UseVisualStyleBackColor = true;
            this.cmd_test1.Click += new System.EventHandler(this.cmd_test1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "L={ w#w|w∈{0,1}* }";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Test 1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_emtySymbol);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txt_rejectState);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txt_acceptState);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.txt_startState);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txt_transitions);
            this.splitContainer2.Size = new System.Drawing.Size(570, 564);
            this.splitContainer2.SplitterDistance = 104;
            this.splitContainer2.TabIndex = 0;
            // 
            // txt_emtySymbol
            // 
            this.txt_emtySymbol.Location = new System.Drawing.Point(513, 34);
            this.txt_emtySymbol.Multiline = true;
            this.txt_emtySymbol.Name = "txt_emtySymbol";
            this.txt_emtySymbol.ReadOnly = true;
            this.txt_emtySymbol.Size = new System.Drawing.Size(53, 20);
            this.txt_emtySymbol.TabIndex = 7;
            this.txt_emtySymbol.Text = "_";
            this.txt_emtySymbol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "emty symbol:";
            // 
            // txt_rejectState
            // 
            this.txt_rejectState.Location = new System.Drawing.Point(365, 34);
            this.txt_rejectState.Name = "txt_rejectState";
            this.txt_rejectState.Size = new System.Drawing.Size(53, 20);
            this.txt_rejectState.TabIndex = 5;
            this.txt_rejectState.Text = "rej";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "reject state:";
            // 
            // txt_acceptState
            // 
            this.txt_acceptState.Location = new System.Drawing.Point(222, 34);
            this.txt_acceptState.Name = "txt_acceptState";
            this.txt_acceptState.Size = new System.Drawing.Size(53, 20);
            this.txt_acceptState.TabIndex = 3;
            this.txt_acceptState.Text = "acc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "accept state:";
            // 
            // txt_startState
            // 
            this.txt_startState.Location = new System.Drawing.Point(73, 34);
            this.txt_startState.Name = "txt_startState";
            this.txt_startState.Size = new System.Drawing.Size(53, 20);
            this.txt_startState.TabIndex = 1;
            this.txt_startState.Text = "Q0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "start state:";
            // 
            // txt_transitions
            // 
            this.txt_transitions.AcceptsTab = true;
            this.txt_transitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_transitions.Location = new System.Drawing.Point(0, 0);
            this.txt_transitions.Name = "txt_transitions";
            this.txt_transitions.Size = new System.Drawing.Size(570, 456);
            this.txt_transitions.TabIndex = 0;
            this.txt_transitions.Text = "State\tRead\tWrite\tL/R\tnext State\n";
            this.txt_transitions.TextChanged += new System.EventHandler(this.txt_transitions_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "tur";
            this.saveFileDialog1.Filter = "TuringMachine|*.tur";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TuringMachine|*.tur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Turing Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txt_rejectState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_acceptState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_startState;
        private System.Windows.Forms.Label label1;
        private RichTextBoxEx txt_transitions;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button cmd_step;
        private System.Windows.Forms.Button cmd_reset;
        private System.Windows.Forms.TextBox txt_emtySymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_aktStripPos;
        private System.Windows.Forms.RichTextBox txt_strip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_aktState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_test2InputLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmd_test2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_test1InputLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmd_test1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
    }
}

