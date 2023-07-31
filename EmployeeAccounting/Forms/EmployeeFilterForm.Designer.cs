namespace EmployeeAccounting.Forms
{
    partial class EmployeeFilterForm
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
            FilterBtn = new Button();
            DivisionBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // FilterBtn
            // 
            FilterBtn.Location = new Point(197, 140);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(132, 29);
            FilterBtn.TabIndex = 0;
            FilterBtn.Text = "Отфильтровать";
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // DivisionBox
            // 
            DivisionBox.Location = new Point(42, 83);
            DivisionBox.Name = "DivisionBox";
            DivisionBox.Size = new Size(442, 27);
            DivisionBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 35);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите название подразделения";
            // 
            // EmployeeFilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 197);
            Controls.Add(label1);
            Controls.Add(DivisionBox);
            Controls.Add(FilterBtn);
            Name = "EmployeeFilterForm";
            Text = "EmployeeFilterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FilterBtn;
        private TextBox DivisionBox;
        private Label label1;
    }
}