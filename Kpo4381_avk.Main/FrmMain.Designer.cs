namespace Kpo4381_avk.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveSearchProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mmProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvMockSearchProjectListCommand = new System.Windows.Forms.DataGridView();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeFactory = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.SStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockSearchProjectListCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmProject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen,
            this.mnSaveSearchProjects});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(70, 26);
            this.mmFile.Text = "1.Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(166, 26);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(166, 26);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnSaveSearchProjects
            // 
            this.mnSaveSearchProjects.Name = "mnSaveSearchProjects";
            this.mnSaveSearchProjects.Size = new System.Drawing.Size(166, 26);
            this.mnSaveSearchProjects.Text = "Сохранить";
            this.mnSaveSearchProjects.Click += new System.EventHandler(this.mnSaveSearchProjects_Click);
            // 
            // mmProject
            // 
            this.mmProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenProject});
            this.mmProject.Name = "mmProject";
            this.mmProject.Size = new System.Drawing.Size(137, 26);
            this.mmProject.Text = "2.Проект поиска";
            this.mmProject.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnOpenProject
            // 
            this.mnOpenProject.Name = "mnOpenProject";
            this.mnOpenProject.Size = new System.Drawing.Size(255, 26);
            this.mnOpenProject.Text = "Открыть проект поиска";
            this.mnOpenProject.Click += new System.EventHandler(this.mnOpenProject_Click);
            // 
            // SStatus
            // 
            this.SStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.SStatus.Location = new System.Drawing.Point(0, 426);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 24);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvMockSearchProjectListCommand
            // 
            this.dgvMockSearchProjectListCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMockSearchProjectListCommand.Location = new System.Drawing.Point(12, 31);
            this.dgvMockSearchProjectListCommand.Name = "dgvMockSearchProjectListCommand";
            this.dgvMockSearchProjectListCommand.RowHeadersWidth = 51;
            this.dgvMockSearchProjectListCommand.RowTemplate.Height = 24;
            this.dgvMockSearchProjectListCommand.Size = new System.Drawing.Size(776, 150);
            this.dgvMockSearchProjectListCommand.TabIndex = 2;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(79, 394);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(113, 22);
            this.txtLogPath.TabIndex = 3;
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.Location = new System.Drawing.Point(326, 392);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.Size = new System.Drawing.Size(164, 22);
            this.txtDataFileName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "logPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "dataFileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "typeFactory";
            // 
            // txtTypeFactory
            // 
            this.txtTypeFactory.Location = new System.Drawing.Point(600, 389);
            this.txtTypeFactory.Name = "txtTypeFactory";
            this.txtTypeFactory.Size = new System.Drawing.Size(100, 22);
            this.txtTypeFactory.TabIndex = 8;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTypeFactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataFileName);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.dgvMockSearchProjectListCommand);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "КПО:4381:Кострина";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SStatus.ResumeLayout(false);
            this.SStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockSearchProjectListCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mmProject;
        private System.Windows.Forms.ToolStripMenuItem mnOpenProject;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvMockSearchProjectListCommand;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeFactory;
        private System.Windows.Forms.ToolStripMenuItem mnSaveSearchProjects;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

