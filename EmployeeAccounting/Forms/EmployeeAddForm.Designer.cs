namespace EmployeeAccounting
{
    partial class EmployeeAddForm
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
            EmployeeAddBtn = new Button();
            NameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NumberTextBox = new TextBox();
            label3 = new Label();
            PositionTextBox = new TextBox();
            label4 = new Label();
            DivisionTextBox = new TextBox();
            label5 = new Label();
            EmailTextBox = new TextBox();
            label6 = new Label();
            PhoneTextBox = new TextBox();
            SuspendLayout();
            // 
            // EmployeeAddBtn
            // 
            EmployeeAddBtn.Location = new Point(195, 376);
            EmployeeAddBtn.Name = "EmployeeAddBtn";
            EmployeeAddBtn.Size = new Size(94, 29);
            EmployeeAddBtn.TabIndex = 0;
            EmployeeAddBtn.Text = "Добавить";
            EmployeeAddBtn.UseVisualStyleBackColor = true;
            EmployeeAddBtn.Click += EmployeeAddBtn_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(65, 42);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(379, 27);
            NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 72);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Табельный номер";
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(65, 95);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(379, 27);
            NumberTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 125);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Должность";
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(65, 148);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(379, 27);
            PositionTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 178);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 8;
            label4.Text = "Подразделение";
            // 
            // DivisionTextBox
            // 
            DivisionTextBox.Location = new Point(65, 201);
            DivisionTextBox.Name = "DivisionTextBox";
            DivisionTextBox.Size = new Size(379, 27);
            DivisionTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 231);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(65, 254);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(379, 27);
            EmailTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 284);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Телефон";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(65, 307);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(379, 27);
            PhoneTextBox.TabIndex = 11;
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(label6);
            Controls.Add(PhoneTextBox);
            Controls.Add(label5);
            Controls.Add(EmailTextBox);
            Controls.Add(label4);
            Controls.Add(DivisionTextBox);
            Controls.Add(label3);
            Controls.Add(PositionTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Controls.Add(EmployeeAddBtn);
            Name = "EmployeeAddForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmployeeAddBtn;
        private TextBox NameTextBox;
        private Label label1;
        private Label label2;
        private TextBox NumberTextBox;
        private Label label3;
        private TextBox PositionTextBox;
        private Label label4;
        private TextBox DivisionTextBox;
        private Label label5;
        private TextBox EmailTextBox;
        private Label label6;
        private TextBox PhoneTextBox;
    }
}