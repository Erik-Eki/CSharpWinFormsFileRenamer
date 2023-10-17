namespace WinFormsFileRenamer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            headerLabel = new Label();
            label1 = new Label();
            buttonOpenExplorer = new Button();
            label2 = new Label();
            fileTable = new DataGridView();
            currentNames = new DataGridViewTextBoxColumn();
            newNames = new DataGridViewTextBoxColumn();
            fileType = new DataGridViewTextBoxColumn();
            createdAt = new DataGridViewTextBoxColumn();
            buttonRename = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            fileCount = new Label();
            formatTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            formatCollapse = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fileTable).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(420, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Welcome to File Renamer";
            headerLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 1;
            label1.Text = "Current files:";
            label1.Click += label1_Click_1;
            // 
            // buttonOpenExplorer
            // 
            buttonOpenExplorer.BackColor = Color.DarkGray;
            buttonOpenExplorer.Location = new Point(319, 81);
            buttonOpenExplorer.Name = "buttonOpenExplorer";
            buttonOpenExplorer.Size = new Size(171, 57);
            buttonOpenExplorer.TabIndex = 2;
            buttonOpenExplorer.Text = "Open Explorer";
            buttonOpenExplorer.UseVisualStyleBackColor = false;
            buttonOpenExplorer.Click += openExplorer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(135, 88);
            label2.Name = "label2";
            label2.Size = new Size(178, 37);
            label2.TabIndex = 3;
            label2.Text = "Browse folder:";
            label2.Click += label2_Click;
            // 
            // fileTable
            // 
            fileTable.AllowUserToAddRows = false;
            fileTable.AllowUserToDeleteRows = false;
            fileTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fileTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fileTable.Columns.AddRange(new DataGridViewColumn[] { currentNames, newNames, fileType, createdAt });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            fileTable.DefaultCellStyle = dataGridViewCellStyle1;
            fileTable.Dock = DockStyle.Bottom;
            fileTable.Location = new Point(0, 334);
            fileTable.Name = "fileTable";
            fileTable.RowTemplate.Height = 25;
            fileTable.Size = new Size(743, 397);
            fileTable.TabIndex = 4;
            fileTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // currentNames
            // 
            currentNames.HeaderText = "Current Names";
            currentNames.Name = "currentNames";
            currentNames.ReadOnly = true;
            // 
            // newNames
            // 
            newNames.HeaderText = "New Names";
            newNames.Name = "newNames";
            // 
            // fileType
            // 
            fileType.FillWeight = 50F;
            fileType.HeaderText = "File Type";
            fileType.Name = "fileType";
            fileType.ReadOnly = true;
            // 
            // createdAt
            // 
            createdAt.HeaderText = "Created At";
            createdAt.Name = "createdAt";
            // 
            // buttonRename
            // 
            buttonRename.BackColor = SystemColors.MenuHighlight;
            buttonRename.ForeColor = Color.White;
            buttonRename.Location = new Point(549, 273);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(182, 55);
            buttonRename.TabIndex = 5;
            buttonRename.Text = "Rename";
            buttonRename.UseVisualStyleBackColor = false;
            // 
            // fileCount
            // 
            fileCount.AutoSize = true;
            fileCount.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            fileCount.Location = new Point(156, 167);
            fileCount.Name = "fileCount";
            fileCount.Size = new Size(86, 30);
            fileCount.TabIndex = 6;
            fileCount.Text = "<none>";
            // 
            // formatTextBox
            // 
            formatTextBox.Location = new Point(115, 285);
            formatTextBox.Name = "formatTextBox";
            formatTextBox.PlaceholderText = "filename_<index>...";
            formatTextBox.Size = new Size(428, 35);
            formatTextBox.TabIndex = 7;
            formatTextBox.TextChanged += formatTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 282);
            label3.Name = "label3";
            label3.Size = new Size(103, 37);
            label3.TabIndex = 8;
            label3.Text = "Format:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 222);
            label4.Name = "label4";
            label4.Size = new Size(196, 37);
            label4.TabIndex = 9;
            label4.Text = "Running format:";
            label4.Click += label4_Click;
            // 
            // formatCollapse
            // 
            formatCollapse.FormattingEnabled = true;
            formatCollapse.Items.AddRange(new object[] { "Index", "Created At" });
            formatCollapse.Location = new Point(214, 225);
            formatCollapse.Name = "formatCollapse";
            formatCollapse.Size = new Size(329, 38);
            formatCollapse.TabIndex = 10;
            formatCollapse.Text = "Index";
            formatCollapse.SelectedIndexChanged += formatCollapse_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 731);
            Controls.Add(formatCollapse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(formatTextBox);
            Controls.Add(fileCount);
            Controls.Add(buttonRename);
            Controls.Add(fileTable);
            Controls.Add(label2);
            Controls.Add(buttonOpenExplorer);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "File Renamer";
            ((System.ComponentModel.ISupportInitialize)fileTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private Button buttonOpenExplorer;
        private Label label2;
        private DataGridView fileTable;
        private Button buttonRename;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label fileCount;
        private TextBox formatTextBox;
        private Label label3;
        private DataGridViewTextBoxColumn currentNames;
        private DataGridViewTextBoxColumn newNames;
        private DataGridViewTextBoxColumn fileType;
        private DataGridViewTextBoxColumn createdAt;
        private Label label4;
        private ComboBox formatCollapse;
    }
}