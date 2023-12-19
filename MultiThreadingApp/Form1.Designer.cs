namespace MultiThreadingApp
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
            listView1 = new ListView();
            label1 = new Label();
            nmrFirstValue = new NumericUpDown();
            btnStart = new Button();
            btnPause = new Button();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrFirstValue).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 220);
            listView1.Name = "listView1";
            listView1.Size = new Size(825, 398);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 34);
            label1.Name = "label1";
            label1.Size = new Size(308, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter a first value to number from database : ";
            // 
            // nmrFirstValue
            // 
            nmrFirstValue.Location = new Point(533, 32);
            nmrFirstValue.Name = "nmrFirstValue";
            nmrFirstValue.Size = new Size(94, 27);
            nmrFirstValue.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(219, 133);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 69);
            btnStart.TabIndex = 5;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(373, 133);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(115, 69);
            btnPause.TabIndex = 5;
            btnPause.Text = "PAUSE";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(533, 133);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(115, 69);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "CONTINUE";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 630);
            Controls.Add(btnContinue);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(nmrFirstValue);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmrFirstValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private Label label1;
        private NumericUpDown nmrFirstValue;
        private Button btnStart;
        private Button btnPause;
        private Button btnContinue;
    }
}