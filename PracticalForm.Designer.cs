namespace PracticalProject
{
    partial class dataform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataform));
            this.label1 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.findbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.findlbl = new System.Windows.Forms.Label();
            this.enterpicbox = new System.Windows.Forms.PictureBox();
            this.resultpicbox = new System.Windows.Forms.PictureBox();
            this.sltptbtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.shwallimgs = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.enterpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultpicbox)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients\' Data :";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(23, 199);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(143, 44);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name: ";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(23, 155);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(78, 44);
            this.idlbl.TabIndex = 2;
            this.idlbl.Text = "ID: ";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(23, 243);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(180, 44);
            this.addresslbl.TabIndex = 3;
            this.addresslbl.Text = "Address: ";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.SystemColors.Menu;
            this.idtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtxt.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(209, 155);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(516, 46);
            this.idtxt.TabIndex = 4;
            this.idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.SystemColors.Menu;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(209, 199);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(516, 46);
            this.nametxt.TabIndex = 5;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addresstxt
            // 
            this.addresstxt.BackColor = System.Drawing.SystemColors.Menu;
            this.addresstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstxt.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(209, 243);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(516, 46);
            this.addresstxt.TabIndex = 6;
            this.addresstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.Location = new System.Drawing.Point(31, 347);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(172, 74);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add New";
            this.addbtn.UseCompatibleTextRendering = true;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.findbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findbtn.Location = new System.Drawing.Point(187, 347);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(179, 74);
            this.findbtn.TabIndex = 8;
            this.findbtn.Text = "Find by ID";
            this.findbtn.UseCompatibleTextRendering = true;
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showbtn.Location = new System.Drawing.Point(435, 56);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(281, 74);
            this.showbtn.TabIndex = 9;
            this.showbtn.Text = " Show All";
            this.toolTip1.SetToolTip(this.showbtn, "Show all data without images");
            this.showbtn.UseVisualStyleBackColor = false;
            this.showbtn.Visible = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.DarkCyan;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(546, 347);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(157, 74);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseCompatibleTextRendering = true;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbtn.Location = new System.Drawing.Point(31, 427);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(672, 74);
            this.exitbtn.TabIndex = 11;
            this.exitbtn.Text = "Exit!";
            this.exitbtn.UseCompatibleTextRendering = true;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // findlbl
            // 
            this.findlbl.AutoSize = true;
            this.findlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findlbl.ForeColor = System.Drawing.Color.DarkRed;
            this.findlbl.Location = new System.Drawing.Point(25, 534);
            this.findlbl.Name = "findlbl";
            this.findlbl.Size = new System.Drawing.Size(0, 36);
            this.findlbl.TabIndex = 12;
            // 
            // enterpicbox
            // 
            this.enterpicbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterpicbox.Location = new System.Drawing.Point(751, 24);
            this.enterpicbox.Name = "enterpicbox";
            this.enterpicbox.Size = new System.Drawing.Size(213, 175);
            this.enterpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterpicbox.TabIndex = 13;
            this.enterpicbox.TabStop = false;
            // 
            // resultpicbox
            // 
            this.resultpicbox.Location = new System.Drawing.Point(751, 326);
            this.resultpicbox.Name = "resultpicbox";
            this.resultpicbox.Size = new System.Drawing.Size(213, 201);
            this.resultpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultpicbox.TabIndex = 14;
            this.resultpicbox.TabStop = false;
            // 
            // sltptbtn
            // 
            this.sltptbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.sltptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sltptbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sltptbtn.Location = new System.Drawing.Point(751, 205);
            this.sltptbtn.Name = "sltptbtn";
            this.sltptbtn.Size = new System.Drawing.Size(213, 44);
            this.sltptbtn.TabIndex = 15;
            this.sltptbtn.Tag = "";
            this.sltptbtn.Text = "Choose Photo!";
            this.sltptbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.sltptbtn, "Press to choose photo");
            this.sltptbtn.UseCompatibleTextRendering = true;
            this.sltptbtn.UseVisualStyleBackColor = false;
            this.sltptbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // shwallimgs
            // 
            this.shwallimgs.BackColor = System.Drawing.Color.DarkCyan;
            this.shwallimgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwallimgs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shwallimgs.Location = new System.Drawing.Point(364, 347);
            this.shwallimgs.Name = "shwallimgs";
            this.shwallimgs.Size = new System.Drawing.Size(184, 74);
            this.shwallimgs.TabIndex = 16;
            this.shwallimgs.Text = "Show All";
            this.shwallimgs.UseCompatibleTextRendering = true;
            this.shwallimgs.UseVisualStyleBackColor = false;
            this.shwallimgs.Click += new System.EventHandler(this.shwallimgs_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 40;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(23, 287);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(121, 44);
            this.datelbl.TabIndex = 17;
            this.datelbl.Text = "Date :";
            // 
            // dtpicker
            // 
            this.dtpicker.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtpicker.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtpicker.CalendarTitleForeColor = System.Drawing.Color.Beige;
            this.dtpicker.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtpicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpicker.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpicker.Location = new System.Drawing.Point(209, 291);
            this.dtpicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(194, 38);
            this.dtpicker.TabIndex = 18;
            this.dtpicker.Value = new System.DateTime(2022, 8, 10, 0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.SeaShell;
            this.pnl.Controls.Add(this.deletebtn);
            this.pnl.Controls.Add(this.findlbl);
            this.pnl.Controls.Add(this.dtpicker);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.datelbl);
            this.pnl.Controls.Add(this.namelbl);
            this.pnl.Controls.Add(this.shwallimgs);
            this.pnl.Controls.Add(this.idlbl);
            this.pnl.Controls.Add(this.sltptbtn);
            this.pnl.Controls.Add(this.addresslbl);
            this.pnl.Controls.Add(this.resultpicbox);
            this.pnl.Controls.Add(this.idtxt);
            this.pnl.Controls.Add(this.enterpicbox);
            this.pnl.Controls.Add(this.nametxt);
            this.pnl.Controls.Add(this.addresstxt);
            this.pnl.Controls.Add(this.exitbtn);
            this.pnl.Controls.Add(this.addbtn);
            this.pnl.Controls.Add(this.findbtn);
            this.pnl.Controls.Add(this.showbtn);
            this.pnl.Location = new System.Drawing.Point(12, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(977, 582);
            this.pnl.TabIndex = 19;
            // 
            // dataform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(999, 602);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "dataform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Data!";
            this.Load += new System.EventHandler(this.dataform_Load);
            this.Resize += new System.EventHandler(this.dataform_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.enterpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultpicbox)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label findlbl;
        private System.Windows.Forms.PictureBox enterpicbox;
        private System.Windows.Forms.PictureBox resultpicbox;
        private System.Windows.Forms.Button sltptbtn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button shwallimgs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl;
    }
}

