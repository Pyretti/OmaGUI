namespace OmaGUI
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tapaturmavakuutus");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Eläkevakuutus");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Henkilövakuutukset", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Kotivakuutus");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rakennukset", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Henkilöauto");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Henkilöauto");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Moottoripyörä");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ajoneuvovakuutukset", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sovellusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asetuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerNumberTb = new System.Windows.Forms.TextBox();
            this.CustomerNameTb = new System.Windows.Forms.TextBox();
            this.CustomerAddresTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InsuranceTv = new System.Windows.Forms.TreeView();
            this.FamilyListbox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sovellusToolStripMenuItem,
            this.asetuksetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sovellusToolStripMenuItem
            // 
            this.sovellusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lopetaToolStripMenuItem});
            this.sovellusToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.sovellusToolStripMenuItem.Name = "sovellusToolStripMenuItem";
            this.sovellusToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sovellusToolStripMenuItem.Text = "Sovellus";
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // asetuksetToolStripMenuItem
            // 
            this.asetuksetToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.asetuksetToolStripMenuItem.Name = "asetuksetToolStripMenuItem";
            this.asetuksetToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.asetuksetToolStripMenuItem.Text = "Asetukset";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.57587F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.42413F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerNumberTb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerNameTb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomerAddresTb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CustomerNumberTb
            // 
            this.CustomerNumberTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerNumberTb.Location = new System.Drawing.Point(96, 3);
            this.CustomerNumberTb.Name = "CustomerNumberTb";
            this.CustomerNumberTb.Size = new System.Drawing.Size(158, 20);
            this.CustomerNumberTb.TabIndex = 0;
            this.CustomerNumberTb.Text = "1223";
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerNameTb.Location = new System.Drawing.Point(96, 29);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(158, 20);
            this.CustomerNameTb.TabIndex = 1;
            this.CustomerNameTb.Text = "Jari Heikkinen";
            // 
            // CustomerAddresTb
            // 
            this.CustomerAddresTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerAddresTb.Location = new System.Drawing.Point(96, 55);
            this.CustomerAddresTb.Name = "CustomerAddresTb";
            this.CustomerAddresTb.Size = new System.Drawing.Size(158, 20);
            this.CustomerAddresTb.TabIndex = 2;
            this.CustomerAddresTb.Text = "Kotitie 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nimi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Osoite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asiakastunnus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsuranceTv
            // 
            this.InsuranceTv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InsuranceTv.Location = new System.Drawing.Point(12, 133);
            this.InsuranceTv.Name = "InsuranceTv";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Tapaturmavakuutus";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Eläkevakuutus";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Henkilövakuutukset";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Kotivakuutus";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Rakennukset";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Henkilöauto";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Henkilöauto";
            treeNode8.Name = "Node12";
            treeNode8.Text = "Moottoripyörä";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Ajoneuvovakuutukset";
            this.InsuranceTv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode9});
            this.InsuranceTv.Size = new System.Drawing.Size(254, 346);
            this.InsuranceTv.TabIndex = 2;
            // 
            // FamilyListbox
            // 
            this.FamilyListbox.FormattingEnabled = true;
            this.FamilyListbox.Items.AddRange(new object[] {
            "Vaimo Heikkinen",
            "Lapsi Heikkinen",
            "Lapsi Heikkinen"});
            this.FamilyListbox.Location = new System.Drawing.Point(273, 37);
            this.FamilyListbox.Name = "FamilyListbox";
            this.FamilyListbox.Size = new System.Drawing.Size(188, 82);
            this.FamilyListbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(952, 571);
            this.Controls.Add(this.FamilyListbox);
            this.Controls.Add(this.InsuranceTv);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sovellusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asetuksetToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CustomerNumberTb;
        private System.Windows.Forms.TextBox CustomerNameTb;
        private System.Windows.Forms.TextBox CustomerAddresTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView InsuranceTv;
        private System.Windows.Forms.ListBox FamilyListbox;
    }
}

