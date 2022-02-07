namespace StefmDE.MinecraftProperties.WinFormEditor
{
    partial class MainEditor
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbxConfigFileRead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddedInVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.tbxConfigFileWrite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxConfigFileRead
            // 
            this.tbxConfigFileRead.Location = new System.Drawing.Point(66, 27);
            this.tbxConfigFileRead.Name = "tbxConfigFileRead";
            this.tbxConfigFileRead.Size = new System.Drawing.Size(882, 27);
            this.tbxConfigFileRead.TabIndex = 0;
            this.tbxConfigFileRead.Text = "C:\\Dev\\MinecraftProperties\\StefmDE.MinecraftProperties.TestConsole\\Samples\\Server" +
    ".properties";
            this.tbxConfigFileRead.TextChanged += new System.EventHandler(this.tbxConfigFileRead_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Read:";
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(954, 26);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(94, 29);
            this.btnLoadConfig.TabIndex = 2;
            this.btnLoadConfig.Text = "Load";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKey,
            this.ColumnType,
            this.ColumnDefaultValue,
            this.ColumnValue,
            this.ColumnMinValue,
            this.ColumnMaxValue,
            this.ColumnAddedInVersion,
            this.ColumnDescription});
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 617);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnKey
            // 
            this.ColumnKey.HeaderText = "Key";
            this.ColumnKey.MinimumWidth = 6;
            this.ColumnKey.Name = "ColumnKey";
            this.ColumnKey.ReadOnly = true;
            this.ColumnKey.Width = 250;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.MinimumWidth = 6;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 90;
            // 
            // ColumnDefaultValue
            // 
            this.ColumnDefaultValue.HeaderText = "Default value";
            this.ColumnDefaultValue.MinimumWidth = 6;
            this.ColumnDefaultValue.Name = "ColumnDefaultValue";
            this.ColumnDefaultValue.ReadOnly = true;
            this.ColumnDefaultValue.Width = 80;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.MinimumWidth = 6;
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 125;
            // 
            // ColumnMinValue
            // 
            this.ColumnMinValue.HeaderText = "Min value";
            this.ColumnMinValue.MinimumWidth = 6;
            this.ColumnMinValue.Name = "ColumnMinValue";
            this.ColumnMinValue.ReadOnly = true;
            this.ColumnMinValue.Width = 60;
            // 
            // ColumnMaxValue
            // 
            this.ColumnMaxValue.HeaderText = "Max value";
            this.ColumnMaxValue.MinimumWidth = 6;
            this.ColumnMaxValue.Name = "ColumnMaxValue";
            this.ColumnMaxValue.ReadOnly = true;
            this.ColumnMaxValue.Width = 90;
            // 
            // ColumnAddedInVersion
            // 
            this.ColumnAddedInVersion.HeaderText = "Added in version";
            this.ColumnAddedInVersion.MinimumWidth = 6;
            this.ColumnAddedInVersion.Name = "ColumnAddedInVersion";
            this.ColumnAddedInVersion.ReadOnly = true;
            this.ColumnAddedInVersion.Width = 80;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 114;
            // 
            // btnNewConfig
            // 
            this.btnNewConfig.Location = new System.Drawing.Point(1054, 26);
            this.btnNewConfig.Name = "btnNewConfig";
            this.btnNewConfig.Size = new System.Drawing.Size(94, 29);
            this.btnNewConfig.TabIndex = 4;
            this.btnNewConfig.Text = "New";
            this.btnNewConfig.UseVisualStyleBackColor = true;
            this.btnNewConfig.Click += new System.EventHandler(this.btnNewConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(1054, 59);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(94, 29);
            this.btnSaveConfig.TabIndex = 5;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // tbxConfigFileWrite
            // 
            this.tbxConfigFileWrite.Location = new System.Drawing.Point(66, 60);
            this.tbxConfigFileWrite.Name = "tbxConfigFileWrite";
            this.tbxConfigFileWrite.Size = new System.Drawing.Size(982, 27);
            this.tbxConfigFileWrite.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write:";
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxConfigFileWrite);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnNewConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConfigFileRead);
            this.Name = "MainEditor";
            this.Text = "Minecraft Properties - Main Editor - StefmDE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox tbxConfigFileRead;
        private Label label1;
        private Button btnLoadConfig;
        private DataGridView dataGridView1;
        private Button btnNewConfig;
        private Button btnSaveConfig;
        private TextBox tbxConfigFileWrite;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnKey;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnDefaultValue;
        private DataGridViewTextBoxColumn ColumnValue;
        private DataGridViewTextBoxColumn ColumnMinValue;
        private DataGridViewTextBoxColumn ColumnMaxValue;
        private DataGridViewTextBoxColumn ColumnAddedInVersion;
        private DataGridViewTextBoxColumn ColumnDescription;
    }
}