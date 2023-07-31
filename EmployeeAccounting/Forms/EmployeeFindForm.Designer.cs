namespace EmployeeAccounting.Forms
{
    partial class EmployeeFindForm
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
            FindBtn = new Button();
            label1 = new Label();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // FindBtn
            // 
            FindBtn.Location = new Point(310, 130);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(94, 29);
            FindBtn.TabIndex = 0;
            FindBtn.Text = "Найти";
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.Click += FindBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 29);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите ФИО/номер сотрудника";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(36, 71);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(641, 27);
            NameBox.TabIndex = 2;
            // 
            // EmployeeFindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 207);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(FindBtn);
            Name = "EmployeeFindForm";
            Text = "EmployeeFindForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindBtn;
        private Label label1;
        private TextBox NameBox;
    }
}