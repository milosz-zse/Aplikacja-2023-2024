namespace WinFormsApp1
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
            labelName = new Label();
            labelLastName = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxJob = new ComboBox();
            labelWhatJob = new Label();
            groupBoxPasswords = new GroupBox();
            buttonGeneratePass = new Button();
            checkBoxSpecialLetters = new CheckBox();
            checkBoxNumber = new CheckBox();
            checkBoxSmallAndBigLetters = new CheckBox();
            textBoxHowManyNumbers = new TextBox();
            label1 = new Label();
            buttonSubmit = new Button();
            groupBox1.SuspendLayout();
            groupBoxPasswords.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 15);
            labelName.TabIndex = 1;
            labelName.Text = "imie ";
            labelName.Click += labelName_Click;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(15, 94);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(58, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "nazwisko ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(79, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(96, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(79, 86);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(96, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxJob);
            groupBox1.Controls.Add(labelWhatJob);
            groupBox1.Controls.Add(labelLastName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(67, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 360);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "dane pracownika";
            // 
            // comboBoxJob
            // 
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Items.AddRange(new object[] { "kierownik", "starszy programista ", "mlodszy programista", "tester" });
            comboBoxJob.Location = new Point(99, 139);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(102, 23);
            comboBoxJob.TabIndex = 6;
            comboBoxJob.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelWhatJob
            // 
            labelWhatJob.AutoSize = true;
            labelWhatJob.Location = new Point(15, 146);
            labelWhatJob.Name = "labelWhatJob";
            labelWhatJob.Size = new Size(63, 15);
            labelWhatJob.TabIndex = 5;
            labelWhatJob.Text = "stanowsko";
            // 
            // groupBoxPasswords
            // 
            groupBoxPasswords.Controls.Add(buttonGeneratePass);
            groupBoxPasswords.Controls.Add(checkBoxSpecialLetters);
            groupBoxPasswords.Controls.Add(checkBoxNumber);
            groupBoxPasswords.Controls.Add(checkBoxSmallAndBigLetters);
            groupBoxPasswords.Controls.Add(textBoxHowManyNumbers);
            groupBoxPasswords.Controls.Add(label1);
            groupBoxPasswords.Location = new Point(425, 78);
            groupBoxPasswords.Name = "groupBoxPasswords";
            groupBoxPasswords.Size = new Size(272, 327);
            groupBoxPasswords.TabIndex = 6;
            groupBoxPasswords.TabStop = false;
            groupBoxPasswords.Text = "generowanie hasel";
            // 
            // buttonGeneratePass
            // 
            buttonGeneratePass.BackColor = Color.SteelBlue;
            buttonGeneratePass.Location = new Point(97, 267);
            buttonGeneratePass.Name = "buttonGeneratePass";
            buttonGeneratePass.Size = new Size(120, 23);
            buttonGeneratePass.TabIndex = 5;
            buttonGeneratePass.Text = "generuj hasło";
            buttonGeneratePass.UseVisualStyleBackColor = false;
            buttonGeneratePass.Click += buttonGeneratePass_Click;
            // 
            // checkBoxSpecialLetters
            // 
            checkBoxSpecialLetters.AutoSize = true;
            checkBoxSpecialLetters.Location = new Point(46, 232);
            checkBoxSpecialLetters.Name = "checkBoxSpecialLetters";
            checkBoxSpecialLetters.Size = new Size(105, 19);
            checkBoxSpecialLetters.TabIndex = 4;
            checkBoxSpecialLetters.Text = "znaki specjalne";
            checkBoxSpecialLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            checkBoxNumber.AutoSize = true;
            checkBoxNumber.Location = new Point(48, 175);
            checkBoxNumber.Name = "checkBoxNumber";
            checkBoxNumber.Size = new Size(52, 19);
            checkBoxNumber.TabIndex = 3;
            checkBoxNumber.Text = "cyfry";
            checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallAndBigLetters
            // 
            checkBoxSmallAndBigLetters.AutoSize = true;
            checkBoxSmallAndBigLetters.Location = new Point(46, 125);
            checkBoxSmallAndBigLetters.Name = "checkBoxSmallAndBigLetters";
            checkBoxSmallAndBigLetters.Size = new Size(126, 19);
            checkBoxSmallAndBigLetters.TabIndex = 2;
            checkBoxSmallAndBigLetters.Text = "małe i wieleki litery";
            checkBoxSmallAndBigLetters.TextAlign = ContentAlignment.MiddleRight;
            checkBoxSmallAndBigLetters.UseVisualStyleBackColor = true;
            // 
            // textBoxHowManyNumbers
            // 
            textBoxHowManyNumbers.Location = new Point(104, 37);
            textBoxHowManyNumbers.Name = "textBoxHowManyNumbers";
            textBoxHowManyNumbers.Size = new Size(113, 23);
            textBoxHowManyNumbers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "ile znaków ?";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.SteelBlue;
            buttonSubmit.Location = new Point(622, 415);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Zatwierdz";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(groupBoxPasswords);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPasswords.ResumeLayout(false);
            groupBoxPasswords.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelName;
        private Label labelLastName;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private GroupBox groupBox1;
        private Label labelWhatJob;
        private GroupBox groupBoxPasswords;
        private ComboBox comboBoxJob;
        private Label label1;
        private CheckBox checkBoxSpecialLetters;
        private CheckBox checkBoxNumber;
        private CheckBox checkBoxSmallAndBigLetters;
        private TextBox textBoxHowManyNumbers;
        private Button buttonSubmit;
        private Button buttonGeneratePass;
    }
}