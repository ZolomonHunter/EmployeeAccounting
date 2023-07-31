namespace EmployeeAccounting.Forms
{
    partial class EmployeeFireForm
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
            FireBtn = new Button();
            label1 = new Label();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // FireBtn
            // 
            FireBtn.Location = new Point(222, 111);
            FireBtn.Name = "FireBtn";
            FireBtn.Size = new Size(94, 29);
            FireBtn.TabIndex = 0;
            FireBtn.Text = "Уволить";
            FireBtn.UseVisualStyleBackColor = true;
            FireBtn.Click += FireBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 30);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите табельный номер сотрудника";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 66);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(516, 27);
            NameBox.TabIndex = 2;
            // 
            // EmployeeFireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 180);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(FireBtn);
            Name = "EmployeeFireForm";
            Text = "EmployeeFireForm";
            Load += EmployeeFireForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FireBtn;
        private Label label1;
        private TextBox NameBox;
    }
}