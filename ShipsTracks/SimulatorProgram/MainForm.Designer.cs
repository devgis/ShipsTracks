namespace SimulatorProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.miShip = new System.Windows.Forms.ToolStripMenuItem();
            this.miBS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSim
            // 
            this.cbSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSim.AutoSize = true;
            this.cbSim.Checked = true;
            this.cbSim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSim.Location = new System.Drawing.Point(299, 143);
            this.cbSim.Margin = new System.Windows.Forms.Padding(6);
            this.cbSim.Name = "cbSim";
            this.cbSim.Size = new System.Drawing.Size(107, 29);
            this.cbSim.TabIndex = 0;
            this.cbSim.Text = "模拟数据";
            this.cbSim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "时间间隔：";
            // 
            // tbTicks
            // 
            this.tbTicks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTicks.Location = new System.Drawing.Point(299, 198);
            this.tbTicks.Margin = new System.Windows.Forms.Padding(6);
            this.tbTicks.Name = "tbTicks";
            this.tbTicks.Size = new System.Drawing.Size(180, 33);
            this.tbTicks.TabIndex = 2;
            this.tbTicks.Text = "10";
            this.tbTicks.TextChanged += new System.EventHandler(this.tbTicks_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "秒";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuManager,
            this.menuHelpAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(761, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(59, 21);
            this.menuSystem.Text = "系统(&S)";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(115, 22);
            this.miExit.Text = "退出(&E)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // menuManager
            // 
            this.menuManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShip,
            this.miBS});
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(64, 21);
            this.menuManager.Text = "管理(&M)";
            // 
            // miShip
            // 
            this.miShip.Name = "miShip";
            this.miShip.Size = new System.Drawing.Size(140, 22);
            this.miShip.Text = "船舶管理(&S)";
            this.miShip.Click += new System.EventHandler(this.miShip_Click);
            // 
            // miBS
            // 
            this.miBS.Name = "miBS";
            this.miBS.Size = new System.Drawing.Size(140, 22);
            this.miBS.Text = "基站管理(&B)";
            this.miBS.Click += new System.EventHandler(this.miBS_Click);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.miAbout});
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(61, 21);
            this.menuHelpAbout.Text = "帮助(&H)";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(117, 22);
            this.miHelp.Text = "帮助(&H)";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(117, 22);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTicks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSim);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(777, 462);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟程序";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem menuManager;
        private System.Windows.Forms.ToolStripMenuItem miShip;
        private System.Windows.Forms.ToolStripMenuItem miBS;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

