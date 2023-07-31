namespace EmployeeAccounting.Forms
{
    partial class EmployeeStatForm
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
            ShowStatBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            DivisionBox = new TextBox();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            HireLabel = new Label();
            FireLabel = new Label();
            SuspendLayout();
            // 
            // ShowStatBtn
            // 
            ShowStatBtn.Location = new Point(250, 201);
            ShowStatBtn.Name = "ShowStatBtn";
            ShowStatBtn.Size = new Size(172, 29);
            ShowStatBtn.TabIndex = 2;
            ShowStatBtn.Text = "Показать статистику";
            ShowStatBtn.UseVisualStyleBackColor = true;
            ShowStatBtn.Click += ShowStatBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 29);
            label1.Name = "label1";
            label1.Size = new Size(282, 20);
            label1.TabIndex = 3;
            label1.Text = "Выберите начальную и конечную даты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 116);
            label2.Name = "label2";
            label2.Size = new Size(306, 20);
            label2.TabIndex = 4;
            label2.Text = "Название подраззделения (опционально)";
            // 
            // DivisionBox
            // 
            DivisionBox.Location = new Point(162, 149);
            DivisionBox.Name = "DivisionBox";
            DivisionBox.Size = new Size(366, 27);
            DivisionBox.TabIndex = 5;
            // 
            // StartTimePicker
            // 
            StartTimePicker.Location = new Point(63, 63);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(250, 27);
            StartTimePicker.TabIndex = 6;
            // 
            // EndTimePicker
            // 
            EndTimePicker.Location = new Point(378, 63);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(250, 27);
            EndTimePicker.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 251);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 8;
            label3.Text = "Принято на работу:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 282);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Уволено:";
            // 
            // HireLabel
            // 
            HireLabel.AutoSize = true;
            HireLabel.Location = new Point(405, 253);
            HireLabel.Name = "HireLabel";
            HireLabel.Size = new Size(17, 20);
            HireLabel.TabIndex = 10;
            HireLabel.Text = "0";
            // 
            // FireLabel
            // 
            FireLabel.AutoSize = true;
            FireLabel.Location = new Point(327, 283);
            FireLabel.Name = "FireLabel";
            FireLabel.Size = new Size(17, 20);
            FireLabel.TabIndex = 11;
            FireLabel.Text = "0";
            // 
            // EmployeeStatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 458);
            Controls.Add(FireLabel);
            Controls.Add(HireLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(DivisionBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ShowStatBtn);
            Name = "EmployeeStatForm";
            Text = "EmployeeStatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ShowStatBtn;
        private Label label1;
        private Label label2;
        private TextBox DivisionBox;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Label label3;
        private Label label4;
        private Label HireLabel;
        private Label FireLabel;
    }
}