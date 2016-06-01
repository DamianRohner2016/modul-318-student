namespace SwissTransportForm
{
    partial class Mainform
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
            System.Windows.Forms.ColumnHeader Gleis;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Listview_Verbindungen = new System.Windows.Forms.ListView();
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.but_search = new System.Windows.Forms.Button();
            this.time_from = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_con = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.destination_to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.destination_from = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Listview_Station = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_verbindungen = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.destination_text = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Gleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gleis
            // 
            Gleis.Text = "Gleis";
            Gleis.Width = 110;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Listview_Verbindungen);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.but_search);
            this.tabPage3.Controls.Add(this.time_from);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.date_con);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.destination_to);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.destination_from);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(634, 426);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Verbindungen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Listview_Verbindungen
            // 
            this.Listview_Verbindungen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Von,
            this.Nach,
            this.Zeit,
            Gleis,
            this.Abfahrtszeit});
            this.Listview_Verbindungen.Location = new System.Drawing.Point(8, 131);
            this.Listview_Verbindungen.Name = "Listview_Verbindungen";
            this.Listview_Verbindungen.Size = new System.Drawing.Size(614, 291);
            this.Listview_Verbindungen.TabIndex = 14;
            this.Listview_Verbindungen.UseCompatibleStateImageBehavior = false;
            this.Listview_Verbindungen.View = System.Windows.Forms.View.Details;
            // 
            // Von
            // 
            this.Von.Text = "Von";
            this.Von.Width = 130;
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            this.Nach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nach.Width = 130;
            // 
            // Zeit
            // 
            this.Zeit.Text = "Zeit";
            this.Zeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zeit.Width = 120;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.Text = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 120;
            // 
            // label5
            // 
            this.label5.AccessibleName = "label5";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verbindungen";
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(464, 78);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(79, 22);
            this.but_search.TabIndex = 8;
            this.but_search.Text = "Suchen";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // time_from
            // 
            this.time_from.Location = new System.Drawing.Point(343, 80);
            this.time_from.Name = "time_from";
            this.time_from.Size = new System.Drawing.Size(89, 20);
            this.time_from.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Abfahrtszeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // date_con
            // 
            this.date_con.Location = new System.Drawing.Point(343, 33);
            this.date_con.Name = "date_con";
            this.date_con.Size = new System.Drawing.Size(200, 20);
            this.date_con.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // destination_to
            // 
            this.destination_to.AccessibleName = "destination_to";
            this.destination_to.Location = new System.Drawing.Point(94, 80);
            this.destination_to.Name = "destination_to";
            this.destination_to.Size = new System.Drawing.Size(133, 20);
            this.destination_to.TabIndex = 2;
            this.destination_to.TextChanged += new System.EventHandler(this.destination_to_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // destination_from
            // 
            this.destination_from.AccessibleName = "destination_from";
            this.destination_from.Location = new System.Drawing.Point(94, 33);
            this.destination_from.Name = "destination_from";
            this.destination_from.Size = new System.Drawing.Size(133, 20);
            this.destination_from.TabIndex = 0;
            this.destination_from.TextChanged += new System.EventHandler(this.destination_from_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Listview_Station);
            this.tabPage4.Controls.Add(this.label_verbindungen);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.destination_text);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(634, 426);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Abfahrt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Listview_Station
            // 
            this.Listview_Station.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Listview_Station.Location = new System.Drawing.Point(10, 103);
            this.Listview_Station.Name = "Listview_Station";
            this.Listview_Station.Size = new System.Drawing.Size(616, 308);
            this.Listview_Station.TabIndex = 25;
            this.Listview_Station.UseCompatibleStateImageBehavior = false;
            this.Listview_Station.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nach";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zeit";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gleis";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ankunftszeit";
            this.columnHeader5.Width = 120;
            // 
            // label_verbindungen
            // 
            this.label_verbindungen.AccessibleName = "label_verbindung";
            this.label_verbindungen.AutoSize = true;
            this.label_verbindungen.Location = new System.Drawing.Point(12, 87);
            this.label_verbindungen.Name = "label_verbindungen";
            this.label_verbindungen.Size = new System.Drawing.Size(73, 13);
            this.label_verbindungen.TabIndex = 21;
            this.label_verbindungen.Text = "Verbindungen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Suchen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Abfahrten von Station";
            // 
            // destination_text
            // 
            this.destination_text.AccessibleName = "destination_text";
            this.destination_text.Location = new System.Drawing.Point(123, 21);
            this.destination_text.Name = "destination_text";
            this.destination_text.Size = new System.Drawing.Size(173, 20);
            this.destination_text.TabIndex = 12;
            this.destination_text.TextChanged += new System.EventHandler(this.destination_text_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 426);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(628, 420);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(153, 22);
            this.toolStripLabel1.Text = "Schweizer öffentlicher Verkehr";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 484);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Mainform";
            this.Text = "ÖV";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destination_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destination_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_con;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.TextBox time_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_verbindungen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox destination_text;
        public System.Windows.Forms.ListView Listview_Verbindungen;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Zeit;
        public System.Windows.Forms.ListView Listview_Station;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Abfahrtszeit;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
    }
}

