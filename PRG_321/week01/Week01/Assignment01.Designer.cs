namespace Week01
{
    partial class Assignment01
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_textBox_first_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_textBox_Second_Input = new System.Windows.Forms.TextBox();
            this.m_button_Add = new System.Windows.Forms.Button();
            this.m_button_Multiply = new System.Windows.Forms.Button();
            this.m_label_Feedback = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Input";
            // 
            // m_textBox_first_input
            // 
            this.m_textBox_first_input.Location = new System.Drawing.Point(91, 45);
            this.m_textBox_first_input.Name = "m_textBox_first_input";
            this.m_textBox_first_input.Size = new System.Drawing.Size(100, 20);
            this.m_textBox_first_input.TabIndex = 1;
            this.m_textBox_first_input.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2nd Input";
            // 
            // m_textBox_Second_Input
            // 
            this.m_textBox_Second_Input.Location = new System.Drawing.Point(91, 79);
            this.m_textBox_Second_Input.Name = "m_textBox_Second_Input";
            this.m_textBox_Second_Input.Size = new System.Drawing.Size(100, 20);
            this.m_textBox_Second_Input.TabIndex = 3;
            // 
            // m_button_Add
            // 
            this.m_button_Add.Location = new System.Drawing.Point(39, 120);
            this.m_button_Add.Name = "m_button_Add";
            this.m_button_Add.Size = new System.Drawing.Size(75, 23);
            this.m_button_Add.TabIndex = 4;
            this.m_button_Add.Text = "+";
            this.m_button_Add.UseVisualStyleBackColor = true;
            this.m_button_Add.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // m_button_Multiply
            // 
            this.m_button_Multiply.Location = new System.Drawing.Point(120, 120);
            this.m_button_Multiply.Name = "m_button_Multiply";
            this.m_button_Multiply.Size = new System.Drawing.Size(75, 23);
            this.m_button_Multiply.TabIndex = 5;
            this.m_button_Multiply.Text = "*";
            this.m_button_Multiply.UseVisualStyleBackColor = true;
            this.m_button_Multiply.Click += new System.EventHandler(this.Handle_Operation);
            // 
            // m_label_Feedback
            // 
            this.m_label_Feedback.AutoSize = true;
            this.m_label_Feedback.Location = new System.Drawing.Point(16, 204);
            this.m_label_Feedback.Name = "m_label_Feedback";
            this.m_label_Feedback.Size = new System.Drawing.Size(0, 13);
            this.m_label_Feedback.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.clearEntriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // clearEntriesToolStripMenuItem
            // 
            this.clearEntriesToolStripMenuItem.Name = "clearEntriesToolStripMenuItem";
            this.clearEntriesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearEntriesToolStripMenuItem.Text = "Clear Entries";
            this.clearEntriesToolStripMenuItem.Click += new System.EventHandler(this.Clear_Entries);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Application);
            // 
            // Assignment01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 261);
            this.Controls.Add(this.m_label_Feedback);
            this.Controls.Add(this.m_button_Multiply);
            this.Controls.Add(this.m_button_Add);
            this.Controls.Add(this.m_textBox_Second_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_textBox_first_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Assignment01";
            this.Text = "Assignment01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_textBox_first_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_textBox_Second_Input;
        private System.Windows.Forms.Button m_button_Add;
        private System.Windows.Forms.Button m_button_Multiply;
        private System.Windows.Forms.Label m_label_Feedback;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}