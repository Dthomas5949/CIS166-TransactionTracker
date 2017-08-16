namespace SeaSharpTransactionTracking
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.lstBoxHistory = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.radWithdrawal = new System.Windows.Forms.RadioButton();
            this.radServiceFee = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.txtChkNumber = new System.Windows.Forms.TextBox();
            this.txtBnkBalance = new System.Windows.Forms.TextBox();
            this.dtmPicker = new System.Windows.Forms.DateTimePicker();
            this.rtbURL = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChkClear = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearedCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxHistory
            // 
            this.lstBoxHistory.FormattingEnabled = true;
            this.lstBoxHistory.Location = new System.Drawing.Point(255, 118);
            this.lstBoxHistory.Name = "lstBoxHistory";
            this.lstBoxHistory.Size = new System.Drawing.Size(248, 186);
            this.lstBoxHistory.TabIndex = 15;
            this.toolTip1.SetToolTip(this.lstBoxHistory, "History of user transactions");
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(104, 205);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bank Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(298, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Transaction Activity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Check &Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "&Payee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Da&te";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(25, 346);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "&Process";
            this.toolTip1.SetToolTip(this.btnProcess, "Process transaction");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearForm.Location = new System.Drawing.Point(107, 346);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 7;
            this.btnClearForm.Text = "&Clear Form";
            this.toolTip1.SetToolTip(this.btnClearForm, "Completly clear the form");
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(255, 310);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(74, 23);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "&History";
            this.toolTip1.SetToolTip(this.btnHistory, "Show transaction history");
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(433, 310);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset transaction history");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radDeposit);
            this.groupBox1.Controls.Add(this.radWithdrawal);
            this.groupBox1.Controls.Add(this.radServiceFee);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type";
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(10, 26);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(61, 17);
            this.radDeposit.TabIndex = 0;
            this.radDeposit.TabStop = true;
            this.radDeposit.Text = "&Deposit";
            this.toolTip1.SetToolTip(this.radDeposit, "Deposit into checking");
            this.radDeposit.UseVisualStyleBackColor = true;
            this.radDeposit.CheckedChanged += new System.EventHandler(this.radDeposit_CheckedChanged);
            // 
            // radWithdrawal
            // 
            this.radWithdrawal.AutoSize = true;
            this.radWithdrawal.Location = new System.Drawing.Point(81, 26);
            this.radWithdrawal.Name = "radWithdrawal";
            this.radWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.radWithdrawal.TabIndex = 1;
            this.radWithdrawal.TabStop = true;
            this.radWithdrawal.Text = "&Withdrawal";
            this.toolTip1.SetToolTip(this.radWithdrawal, "Withdraw money");
            this.radWithdrawal.UseVisualStyleBackColor = true;
            this.radWithdrawal.CheckedChanged += new System.EventHandler(this.radWithdrawal_CheckedChanged);
            // 
            // radServiceFee
            // 
            this.radServiceFee.AutoSize = true;
            this.radServiceFee.Location = new System.Drawing.Point(162, 26);
            this.radServiceFee.Name = "radServiceFee";
            this.radServiceFee.Size = new System.Drawing.Size(82, 17);
            this.radServiceFee.TabIndex = 2;
            this.radServiceFee.TabStop = true;
            this.radServiceFee.Text = "&Service Fee";
            this.toolTip1.SetToolTip(this.radServiceFee, "Pay a service fee");
            this.radServiceFee.UseVisualStyleBackColor = true;
            this.radServiceFee.CheckedChanged += new System.EventHandler(this.radServiceFee_CheckedChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(107, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtAmount, "Transaction amount");
            // 
            // txtPayee
            // 
            this.txtPayee.Location = new System.Drawing.Point(107, 141);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(109, 20);
            this.txtPayee.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPayee, "Transaction payee");
            // 
            // txtChkNumber
            // 
            this.txtChkNumber.Location = new System.Drawing.Point(107, 167);
            this.txtChkNumber.Name = "txtChkNumber";
            this.txtChkNumber.Size = new System.Drawing.Size(100, 20);
            this.txtChkNumber.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtChkNumber, "Check number");
            // 
            // txtBnkBalance
            // 
            this.txtBnkBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBnkBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBnkBalance.Location = new System.Drawing.Point(102, 291);
            this.txtBnkBalance.Name = "txtBnkBalance";
            this.txtBnkBalance.ReadOnly = true;
            this.txtBnkBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBnkBalance.TabIndex = 26;
            this.txtBnkBalance.TabStop = false;
            this.toolTip1.SetToolTip(this.txtBnkBalance, "Current available balace. (Red means negative)");
            // 
            // dtmPicker
            // 
            this.dtmPicker.CustomFormat = " \"dd-MMM-yyyy\"";
            this.dtmPicker.Location = new System.Drawing.Point(107, 82);
            this.dtmPicker.Name = "dtmPicker";
            this.dtmPicker.Size = new System.Drawing.Size(185, 20);
            this.dtmPicker.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtmPicker, "Transaction date");
            this.dtmPicker.Value = new System.DateTime(2017, 2, 9, 0, 0, 0, 0);
            // 
            // rtbURL
            // 
            this.rtbURL.Location = new System.Drawing.Point(269, 348);
            this.rtbURL.Name = "rtbURL";
            this.rtbURL.ReadOnly = true;
            this.rtbURL.Size = new System.Drawing.Size(181, 20);
            this.rtbURL.TabIndex = 11;
            this.rtbURL.Text = "https://www.usbank.com/index.html";
            this.rtbURL.WordWrap = false;
            // 
            // btnChkClear
            // 
            this.btnChkClear.Location = new System.Drawing.Point(335, 310);
            this.btnChkClear.Name = "btnChkClear";
            this.btnChkClear.Size = new System.Drawing.Size(92, 23);
            this.btnChkClear.TabIndex = 28;
            this.btnChkClear.Text = "Check C&leared";
            this.toolTip1.SetToolTip(this.btnChkClear, "Click to see if check has cleared");
            this.btnChkClear.UseVisualStyleBackColor = true;
            this.btnChkClear.Click += new System.EventHandler(this.btnChkClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reviewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openToolStripMenuItem.Text = "&Open    Ctrl+O";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "&Save    Ctrl+S";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "E&xit    Ctrl+X";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.clearedCtrlLToolStripMenuItem,
            this.resetCtrlRToolStripMenuItem});
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.reviewToolStripMenuItem.Text = "R&eview";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.historyToolStripMenuItem.Text = "&History    Ctrl+H";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // clearedCtrlLToolStripMenuItem
            // 
            this.clearedCtrlLToolStripMenuItem.Name = "clearedCtrlLToolStripMenuItem";
            this.clearedCtrlLToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearedCtrlLToolStripMenuItem.Text = "C&leared     Ctrl+L";
            this.clearedCtrlLToolStripMenuItem.Click += new System.EventHandler(this.btnChkClear_Click);
            // 
            // resetCtrlRToolStripMenuItem
            // 
            this.resetCtrlRToolStripMenuItem.Name = "resetCtrlRToolStripMenuItem";
            this.resetCtrlRToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetCtrlRToolStripMenuItem.Text = "&Reset    Ctrl+R";
            this.resetCtrlRToolStripMenuItem.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "He&lp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "&About    Ctrl+A";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SeaSharpTransactionTracking.Properties.Resources.checkbook;
            this.pictureBox1.Location = new System.Drawing.Point(15, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 66);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmTransaction
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearForm;
            this.ClientSize = new System.Drawing.Size(515, 383);
            this.Controls.Add(this.btnChkClear);
            this.Controls.Add(this.rtbURL);
            this.Controls.Add(this.dtmPicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBnkBalance);
            this.Controls.Add(this.txtChkNumber);
            this.Controls.Add(this.txtPayee);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lstBoxHistory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTransaction";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "SeaSharpTransactionTracker";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxHistory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.RadioButton radWithdrawal;
        private System.Windows.Forms.RadioButton radServiceFee;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPayee;
        private System.Windows.Forms.TextBox txtChkNumber;
        private System.Windows.Forms.TextBox txtBnkBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtmPicker;
        private System.Windows.Forms.RichTextBox rtbURL;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChkClear;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearedCtrlLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCtrlRToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

