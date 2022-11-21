namespace TeamTimeTrack
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
            this.buttonPrintExcel = new System.Windows.Forms.Button();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.richTextBoxTasks = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAddDay = new System.Windows.Forms.Button();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBreak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxControlWindow = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrintExcel
            // 
            this.buttonPrintExcel.BackColor = System.Drawing.Color.Green;
            this.buttonPrintExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintExcel.Location = new System.Drawing.Point(655, 373);
            this.buttonPrintExcel.Name = "buttonPrintExcel";
            this.buttonPrintExcel.Size = new System.Drawing.Size(112, 35);
            this.buttonPrintExcel.TabIndex = 0;
            this.buttonPrintExcel.Text = "Print Excel";
            this.buttonPrintExcel.UseVisualStyleBackColor = false;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(26, 95);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(47, 23);
            this.textBoxStartTime.TabIndex = 1;
            this.textBoxStartTime.TextChanged += new System.EventHandler(this.textBoxStartTime_TextChanged);
            // 
            // richTextBoxTasks
            // 
            this.richTextBoxTasks.Location = new System.Drawing.Point(260, 39);
            this.richTextBoxTasks.Name = "richTextBoxTasks";
            this.richTextBoxTasks.Size = new System.Drawing.Size(366, 79);
            this.richTextBoxTasks.TabIndex = 2;
            this.richTextBoxTasks.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(670, 77);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAddDay
            // 
            this.buttonAddDay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddDay.Location = new System.Drawing.Point(655, 39);
            this.buttonAddDay.Name = "buttonAddDay";
            this.buttonAddDay.Size = new System.Drawing.Size(106, 32);
            this.buttonAddDay.TabIndex = 4;
            this.buttonAddDay.Text = "Tag Hinzufügen";
            this.buttonAddDay.UseVisualStyleBackColor = false;
            this.buttonAddDay.Click += new System.EventHandler(this.buttonAddDay_Click);
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(79, 95);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(53, 23);
            this.textBoxEndTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ende";
            // 
            // textBoxBreak
            // 
            this.textBoxBreak.Location = new System.Drawing.Point(180, 95);
            this.textBoxBreak.Name = "textBoxBreak";
            this.textBoxBreak.Size = new System.Drawing.Size(46, 23);
            this.textBoxBreak.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pause";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Task";
            // 
            // richTextBoxControlWindow
            // 
            this.richTextBoxControlWindow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxControlWindow.Location = new System.Drawing.Point(26, 166);
            this.richTextBoxControlWindow.Name = "richTextBoxControlWindow";
            this.richTextBoxControlWindow.ReadOnly = true;
            this.richTextBoxControlWindow.Size = new System.Drawing.Size(719, 158);
            this.richTextBoxControlWindow.TabIndex = 12;
            this.richTextBoxControlWindow.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kontrolle";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(26, 39);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(47, 23);
            this.comboBoxDay.TabIndex = 14;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(85, 39);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(47, 23);
            this.comboBoxMonth.TabIndex = 15;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxYear.Location = new System.Drawing.Point(148, 39);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(56, 23);
            this.comboBoxYear.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zeiten in Dezimalzahlen angeben bsp.: 08:30 - 16:00 = 8,5 -16,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxControlWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBreak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.buttonAddDay);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.richTextBoxTasks);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.buttonPrintExcel);
            this.Name = "Form1";
            this.Text = "Team Time Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPrintExcel;
        private TextBox textBoxStartTime;
        private RichTextBox richTextBoxTasks;
        private Button buttonReset;
        private Button buttonAddDay;
        private TextBox textBoxEndTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxBreak;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBoxControlWindow;
        private Label label6;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Label label7;
    }
}