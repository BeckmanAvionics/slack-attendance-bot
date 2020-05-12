namespace Attendance.Main
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTheme = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsThemeSteel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThemeJade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThemeRose = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRequestType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Tag = "heading";
            this.label1.Text = "Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Address";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTheme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTheme
            // 
            this.tsTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThemeSteel,
            this.tsThemeJade,
            this.tsThemeRose});
            this.tsTheme.Image = ((System.Drawing.Image)(resources.GetObject("tsTheme.Image")));
            this.tsTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTheme.Name = "tsTheme";
            this.tsTheme.Size = new System.Drawing.Size(27, 20);
            this.tsTheme.Text = "#";
            // 
            // tsThemeSteel
            // 
            this.tsThemeSteel.CheckOnClick = true;
            this.tsThemeSteel.Name = "tsThemeSteel";
            this.tsThemeSteel.Size = new System.Drawing.Size(81, 22);
            this.tsThemeSteel.Text = "#";
            this.tsThemeSteel.Click += new System.EventHandler(this.tsThemeX_Click);
            // 
            // tsThemeJade
            // 
            this.tsThemeJade.CheckOnClick = true;
            this.tsThemeJade.Name = "tsThemeJade";
            this.tsThemeJade.Size = new System.Drawing.Size(81, 22);
            this.tsThemeJade.Text = "#";
            this.tsThemeJade.Click += new System.EventHandler(this.tsThemeX_Click);
            // 
            // tsThemeRose
            // 
            this.tsThemeRose.CheckOnClick = true;
            this.tsThemeRose.Name = "tsThemeRose";
            this.tsThemeRose.Size = new System.Drawing.Size(81, 22);
            this.tsThemeRose.Text = "#";
            this.tsThemeRose.Click += new System.EventHandler(this.tsThemeX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Request Type";
            // 
            // cboRequestType
            // 
            this.cboRequestType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestType.FormattingEnabled = true;
            this.cboRequestType.Items.AddRange(new object[] {
            "Attendance Log",
            "Poll Log"});
            this.cboRequestType.Location = new System.Drawing.Point(116, 82);
            this.cboRequestType.Name = "cboRequestType";
            this.cboRequestType.Size = new System.Drawing.Size(285, 21);
            this.cboRequestType.TabIndex = 9;
            this.cboRequestType.SelectedIndexChanged += new System.EventHandler(this.cboRequestType_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(14, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "#";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(116, 109);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(285, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(301, 135);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(100, 23);
            this.btnSendRequest.TabIndex = 13;
            this.btnSendRequest.Tag = "send";
            this.btnSendRequest.Text = "&Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Attendance.Properties.Settings.Default, "SERVER", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServerAddress.Location = new System.Drawing.Point(116, 56);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(285, 20);
            this.txtServerAddress.TabIndex = 4;
            this.txtServerAddress.Text = global::Attendance.Properties.Settings.Default.SERVER;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername});
            this.dgv.Location = new System.Drawing.Point(12, 164);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(389, 209);
            this.dgv.TabIndex = 14;
            this.dgv.Tag = "row";
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 80;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 398);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboRequestType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRequestType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ToolStripDropDownButton tsTheme;
        private System.Windows.Forms.ToolStripMenuItem tsThemeSteel;
        private System.Windows.Forms.ToolStripMenuItem tsThemeJade;
        private System.Windows.Forms.ToolStripMenuItem tsThemeRose;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
    }
}