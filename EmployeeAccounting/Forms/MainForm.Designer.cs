namespace EmployeeAccounting
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            AddEmloyeeBtn = new Button();
            FireEmployeeBtn = new Button();
            FindEmployeeBtn = new Button();
            FilterEmployeeBtn = new Button();
            ShowStatBtn = new Button();
            ShowAllEmployeesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(968, 487);
            dataGridView.TabIndex = 0;
            // 
            // AddEmloyeeBtn
            // 
            AddEmloyeeBtn.Location = new Point(986, 83);
            AddEmloyeeBtn.Name = "AddEmloyeeBtn";
            AddEmloyeeBtn.Size = new Size(153, 65);
            AddEmloyeeBtn.TabIndex = 1;
            AddEmloyeeBtn.Text = "Добавить сотрудника";
            AddEmloyeeBtn.UseVisualStyleBackColor = true;
            AddEmloyeeBtn.Click += AddEmloyeeBtn_Click;
            // 
            // FireEmployeeBtn
            // 
            FireEmployeeBtn.Location = new Point(986, 154);
            FireEmployeeBtn.Name = "FireEmployeeBtn";
            FireEmployeeBtn.Size = new Size(153, 65);
            FireEmployeeBtn.TabIndex = 2;
            FireEmployeeBtn.Text = "Уволить сотрудника";
            FireEmployeeBtn.UseVisualStyleBackColor = true;
            FireEmployeeBtn.Click += FireEmployeeBtn_Click;
            // 
            // FindEmployeeBtn
            // 
            FindEmployeeBtn.Location = new Point(986, 225);
            FindEmployeeBtn.Name = "FindEmployeeBtn";
            FindEmployeeBtn.Size = new Size(153, 65);
            FindEmployeeBtn.TabIndex = 3;
            FindEmployeeBtn.Text = "Найти сотрудника";
            FindEmployeeBtn.UseVisualStyleBackColor = true;
            FindEmployeeBtn.Click += FindEmployeeBtn_Click;
            // 
            // FilterEmployeeBtn
            // 
            FilterEmployeeBtn.Location = new Point(986, 296);
            FilterEmployeeBtn.Name = "FilterEmployeeBtn";
            FilterEmployeeBtn.Size = new Size(153, 65);
            FilterEmployeeBtn.TabIndex = 4;
            FilterEmployeeBtn.Text = "Отфильтровать по подразделению";
            FilterEmployeeBtn.UseVisualStyleBackColor = true;
            FilterEmployeeBtn.Click += FilterEmployeeBtn_Click;
            // 
            // ShowStatBtn
            // 
            ShowStatBtn.Location = new Point(986, 367);
            ShowStatBtn.Name = "ShowStatBtn";
            ShowStatBtn.Size = new Size(153, 65);
            ShowStatBtn.TabIndex = 5;
            ShowStatBtn.Text = "Показать статистику";
            ShowStatBtn.UseVisualStyleBackColor = true;
            ShowStatBtn.Click += ShowStatBtn_Click;
            // 
            // ShowAllEmployeesBtn
            // 
            ShowAllEmployeesBtn.Location = new Point(986, 12);
            ShowAllEmployeesBtn.Name = "ShowAllEmployeesBtn";
            ShowAllEmployeesBtn.Size = new Size(153, 65);
            ShowAllEmployeesBtn.TabIndex = 6;
            ShowAllEmployeesBtn.Text = "Показать всех сотрудников";
            ShowAllEmployeesBtn.UseVisualStyleBackColor = true;
            ShowAllEmployeesBtn.Click += ShowAllEmployeesBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 511);
            Controls.Add(ShowAllEmployeesBtn);
            Controls.Add(ShowStatBtn);
            Controls.Add(FilterEmployeeBtn);
            Controls.Add(FindEmployeeBtn);
            Controls.Add(FireEmployeeBtn);
            Controls.Add(AddEmloyeeBtn);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button AddEmloyeeBtn;
        private Button FireEmployeeBtn;
        private Button FindEmployeeBtn;
        private Button FilterEmployeeBtn;
        private Button ShowStatBtn;
        private Button ShowAllEmployeesBtn;
    }
}