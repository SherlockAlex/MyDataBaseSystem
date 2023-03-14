namespace MyDataBaseSystem
{
    partial class MainMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游客ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTravellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游客ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游客ToolStripMenuItem
            // 
            this.游客ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTravellerToolStripMenuItem,
            this.selectTravellerToolStripMenuItem});
            this.游客ToolStripMenuItem.Name = "游客ToolStripMenuItem";
            this.游客ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.游客ToolStripMenuItem.Text = "游客";
            // 
            // addTravellerToolStripMenuItem
            // 
            this.addTravellerToolStripMenuItem.Name = "addTravellerToolStripMenuItem";
            this.addTravellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addTravellerToolStripMenuItem.Text = "添加游客";
            this.addTravellerToolStripMenuItem.Click += new System.EventHandler(this.addTravellerToolStripMenuItem_Click);
            // 
            // selectTravellerToolStripMenuItem
            // 
            this.selectTravellerToolStripMenuItem.Name = "selectTravellerToolStripMenuItem";
            this.selectTravellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectTravellerToolStripMenuItem.Text = "查询游客";
            this.selectTravellerToolStripMenuItem.Click += new System.EventHandler(this.selectTravellerToolStripMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 游客ToolStripMenuItem;
        private ToolStripMenuItem addTravellerToolStripMenuItem;
        private ToolStripMenuItem selectTravellerToolStripMenuItem;
    }
}