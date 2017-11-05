namespace ColourCircles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addThread = new System.Windows.Forms.Button();
            this.removeThread = new System.Windows.Forms.Button();
            this.suspendButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nudRefreshInt = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.listOfThreads = new System.Windows.Forms.ListBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.catsButton = new System.Windows.Forms.Button();
            this.secretButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // addThread
            // 
            this.addThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addThread.Location = new System.Drawing.Point(16, 162);
            this.addThread.Name = "addThread";
            this.addThread.Size = new System.Drawing.Size(133, 23);
            this.addThread.TabIndex = 0;
            this.addThread.Text = "Add thread";
            this.addThread.UseVisualStyleBackColor = true;
            this.addThread.Click += new System.EventHandler(this.addThread_Click);
            // 
            // removeThread
            // 
            this.removeThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeThread.Location = new System.Drawing.Point(16, 191);
            this.removeThread.Name = "removeThread";
            this.removeThread.Size = new System.Drawing.Size(133, 23);
            this.removeThread.TabIndex = 1;
            this.removeThread.Text = "Remove thread";
            this.removeThread.UseVisualStyleBackColor = true;
            this.removeThread.Click += new System.EventHandler(this.removeThread_Click);
            // 
            // suspendButton
            // 
            this.suspendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suspendButton.Location = new System.Drawing.Point(20, 521);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(129, 23);
            this.suspendButton.TabIndex = 2;
            this.suspendButton.Text = "Suspend";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resumeButton.Location = new System.Drawing.Point(21, 550);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(128, 23);
            this.resumeButton.TabIndex = 3;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current thread:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Refresh interval (ms):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radius:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Colour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Main thread priority:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(20, 476);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 623);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // nudRefreshInt
            // 
            this.nudRefreshInt.Location = new System.Drawing.Point(19, 287);
            this.nudRefreshInt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRefreshInt.Name = "nudRefreshInt";
            this.nudRefreshInt.Size = new System.Drawing.Size(130, 22);
            this.nudRefreshInt.TabIndex = 14;
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(19, 346);
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(129, 22);
            this.nudRadius.TabIndex = 15;
            this.nudRadius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // listOfThreads
            // 
            this.listOfThreads.FormattingEnabled = true;
            this.listOfThreads.ItemHeight = 16;
            this.listOfThreads.Location = new System.Drawing.Point(14, 29);
            this.listOfThreads.Name = "listOfThreads";
            this.listOfThreads.Size = new System.Drawing.Size(136, 116);
            this.listOfThreads.TabIndex = 16;
            this.listOfThreads.SelectedValueChanged += new System.EventHandler(this.listOfThreads_SelectedValueChanged);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.Location = new System.Drawing.Point(16, 401);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(134, 27);
            this.colorButton.TabIndex = 17;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // catsButton
            // 
            this.catsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.catsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catsButton.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.catsButton.FlatAppearance.BorderSize = 4;
            this.catsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.catsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.catsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.catsButton.ForeColor = System.Drawing.Color.Blue;
            this.catsButton.Location = new System.Drawing.Point(837, 571);
            this.catsButton.Name = "catsButton";
            this.catsButton.Size = new System.Drawing.Size(180, 60);
            this.catsButton.TabIndex = 18;
            this.catsButton.Text = "Cat";
            this.catsButton.UseVisualStyleBackColor = false;
            this.catsButton.Click += new System.EventHandler(this.catsButton_Click);
            // 
            // secretButton
            // 
            this.secretButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.secretButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.secretButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.secretButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.secretButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretButton.ForeColor = System.Drawing.SystemColors.Control;
            this.secretButton.Location = new System.Drawing.Point(155, 18);
            this.secretButton.Name = "secretButton";
            this.secretButton.Size = new System.Drawing.Size(14, 630);
            this.secretButton.TabIndex = 19;
            this.secretButton.UseVisualStyleBackColor = false;
            this.secretButton.Click += new System.EventHandler(this.secretButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1057, 659);
            this.Controls.Add(this.secretButton);
            this.Controls.Add(this.catsButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.listOfThreads);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.nudRefreshInt);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.removeThread);
            this.Controls.Add(this.addThread);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Circles??? 2017";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addThread;
        private System.Windows.Forms.Button removeThread;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown nudRefreshInt;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.ListBox listOfThreads;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button catsButton;
        private System.Windows.Forms.Button secretButton;
    }
}

