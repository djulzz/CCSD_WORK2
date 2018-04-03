namespace Week01
{
    partial class MainWindow
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
            this.m_label_first_name = new System.Windows.Forms.Label();
            this.m_textBox_FirstName = new System.Windows.Forms.TextBox();
            this.m_button_clickMe = new System.Windows.Forms.Button();
            this.m_label_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_label_first_name
            // 
            this.m_label_first_name.AutoSize = true;
            this.m_label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_first_name.Location = new System.Drawing.Point(24, 33);
            this.m_label_first_name.Name = "m_label_first_name";
            this.m_label_first_name.Size = new System.Drawing.Size(129, 26);
            this.m_label_first_name.TabIndex = 0;
            this.m_label_first_name.Text = "First Name";
            // 
            // m_textBox_FirstName
            // 
            this.m_textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_textBox_FirstName.Location = new System.Drawing.Point(184, 27);
            this.m_textBox_FirstName.Name = "m_textBox_FirstName";
            this.m_textBox_FirstName.Size = new System.Drawing.Size(182, 32);
            this.m_textBox_FirstName.TabIndex = 1;
            // 
            // m_button_clickMe
            // 
            this.m_button_clickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_button_clickMe.Location = new System.Drawing.Point(29, 74);
            this.m_button_clickMe.Name = "m_button_clickMe";
            this.m_button_clickMe.Size = new System.Drawing.Size(139, 41);
            this.m_button_clickMe.TabIndex = 2;
            this.m_button_clickMe.Text = "Click Me!";
            this.m_button_clickMe.UseVisualStyleBackColor = true;
            this.m_button_clickMe.Click += new System.EventHandler(this.Handle_Click);
            // 
            // m_label_feedback
            // 
            this.m_label_feedback.AutoSize = true;
            this.m_label_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_feedback.Location = new System.Drawing.Point(29, 318);
            this.m_label_feedback.Name = "m_label_feedback";
            this.m_label_feedback.Size = new System.Drawing.Size(0, 26);
            this.m_label_feedback.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 382);
            this.Controls.Add(this.m_label_feedback);
            this.Controls.Add(this.m_button_clickMe);
            this.Controls.Add(this.m_textBox_FirstName);
            this.Controls.Add(this.m_label_first_name);
            this.Name = "MainWindow";
            this.Text = "My First Windows GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_label_first_name;
        private System.Windows.Forms.TextBox m_textBox_FirstName;
        private System.Windows.Forms.Button m_button_clickMe;
        private System.Windows.Forms.Label m_label_feedback;
    }
}

