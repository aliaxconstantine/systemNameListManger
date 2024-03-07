namespace System_Variable_Editor
{
    partial class SystemInEditor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataViewTypeValue = new Sunny.UI.UIDataGridView();
            typeName = new DataGridViewTextBoxColumn();
            Syvariable = new DataGridViewTextBoxColumn();
            syValue = new DataGridViewTextBoxColumn();
            uiButton1 = new Sunny.UI.UIButton();
            saveButton = new Sunny.UI.UIButton();
            insatllButton = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dataViewTypeValue).BeginInit();
            SuspendLayout();
            // 
            // dataViewTypeValue
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dataViewTypeValue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewTypeValue.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataViewTypeValue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewTypeValue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewTypeValue.ColumnHeadersHeight = 32;
            dataViewTypeValue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataViewTypeValue.Columns.AddRange(new DataGridViewColumn[] { typeName, Syvariable, syValue });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewTypeValue.DefaultCellStyle = dataGridViewCellStyle3;
            dataViewTypeValue.EnableHeadersVisualStyles = false;
            dataViewTypeValue.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataViewTypeValue.GridColor = Color.FromArgb(104, 173, 255);
            dataViewTypeValue.Location = new Point(3, 38);
            dataViewTypeValue.Name = "dataViewTypeValue";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataViewTypeValue.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataViewTypeValue.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataViewTypeValue.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataViewTypeValue.RowTemplate.Height = 29;
            dataViewTypeValue.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            dataViewTypeValue.SelectedIndex = -1;
            dataViewTypeValue.Size = new Size(712, 446);
            dataViewTypeValue.TabIndex = 0;
            // 
            // typeName
            // 
            typeName.HeaderText = "类";
            typeName.MinimumWidth = 6;
            typeName.Name = "typeName";
            typeName.Resizable = DataGridViewTriState.True;
            typeName.Width = 125;
            // 
            // Syvariable
            // 
            Syvariable.HeaderText = "变量";
            Syvariable.MinimumWidth = 6;
            Syvariable.Name = "Syvariable";
            Syvariable.Resizable = DataGridViewTriState.True;
            Syvariable.SortMode = DataGridViewColumnSortMode.NotSortable;
            Syvariable.Width = 125;
            // 
            // syValue
            // 
            syValue.HeaderText = "值";
            syValue.MinimumWidth = 6;
            syValue.Name = "syValue";
            syValue.Resizable = DataGridViewTriState.True;
            syValue.Width = 125;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(3, 490);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(178, 33);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "一键导入";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Click += uiButton1_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(532, 490);
            saveButton.MinimumSize = new Size(1, 1);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(183, 33);
            saveButton.TabIndex = 2;
            saveButton.Text = "保存配置";
            saveButton.Click += saveButton_Click;
            // 
            // insatllButton
            // 
            insatllButton.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insatllButton.Location = new Point(269, 490);
            insatllButton.MinimumSize = new Size(1, 1);
            insatllButton.Name = "insatllButton";
            insatllButton.Size = new Size(173, 33);
            insatllButton.TabIndex = 3;
            insatllButton.Text = "环境安装";
            insatllButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            insatllButton.Click += InstallsButton_Click;
            // 
            // SystemInEditor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(722, 565);
            Controls.Add(insatllButton);
            Controls.Add(saveButton);
            Controls.Add(uiButton1);
            Controls.Add(dataViewTypeValue);
            Name = "SystemInEditor";
            Text = "环境变量安装";
            ZoomScaleRect = new Rectangle(19, 19, 710, 451);
            Load += SystemInEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewTypeValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView dataViewTypeValue;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton saveButton;
        private DataGridViewTextBoxColumn typeName;
        private DataGridViewTextBoxColumn Syvariable;
        private DataGridViewTextBoxColumn syValue;
        private Sunny.UI.UIButton insatllButton;
    }
}