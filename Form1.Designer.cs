namespace EncoLyze
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbOptions = new System.Windows.Forms.ListBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toUPPERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tolowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblnumberNum = new System.Windows.Forms.Label();
            this.lblLineNumber = new System.Windows.Forms.Label();
            this.lblWordNumber = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lsbOptions
            // 
            this.lsbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOptions.FormattingEnabled = true;
            this.lsbOptions.ItemHeight = 15;
            this.lsbOptions.Items.AddRange(new object[] {
            "ToBase64",
            "ToHEX",
            "FromBase64",
            "FromHEX",
            "CharCodeToString",
            "StringToCharCode"});
            this.lsbOptions.Location = new System.Drawing.Point(6, 17);
            this.lsbOptions.Name = "lsbOptions";
            this.lsbOptions.Size = new System.Drawing.Size(118, 244);
            this.lsbOptions.TabIndex = 1;
            // 
            // rtbText
            // 
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbText.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(153, 17);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(558, 247);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toUPPERToolStripMenuItem,
            this.tolowerToolStripMenuItem,
            this.inverseCaseToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 136);
            // 
            // toUPPERToolStripMenuItem
            // 
            this.toUPPERToolStripMenuItem.Name = "toUPPERToolStripMenuItem";
            this.toUPPERToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.toUPPERToolStripMenuItem.Text = "ToUPPER";
            // 
            // tolowerToolStripMenuItem
            // 
            this.tolowerToolStripMenuItem.Name = "tolowerToolStripMenuItem";
            this.tolowerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tolowerToolStripMenuItem.Text = "Tolower";
            // 
            // inverseCaseToolStripMenuItem
            // 
            this.inverseCaseToolStripMenuItem.Name = "inverseCaseToolStripMenuItem";
            this.inverseCaseToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.inverseCaseToolStripMenuItem.Text = "InverseCase";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(439, 370);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 352);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length : ";
            // 
            // lblnumberNum
            // 
            this.lblnumberNum.AutoSize = true;
            this.lblnumberNum.Location = new System.Drawing.Point(12, 380);
            this.lblnumberNum.Name = "lblnumberNum";
            this.lblnumberNum.Size = new System.Drawing.Size(103, 13);
            this.lblnumberNum.TabIndex = 6;
            this.lblnumberNum.Text = "Number of number : ";
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.AutoSize = true;
            this.lblLineNumber.Location = new System.Drawing.Point(167, 352);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(74, 13);
            this.lblLineNumber.TabIndex = 7;
            this.lblLineNumber.Text = "Line number : ";
            // 
            // lblWordNumber
            // 
            this.lblWordNumber.AutoSize = true;
            this.lblWordNumber.Location = new System.Drawing.Point(167, 380);
            this.lblWordNumber.Name = "lblWordNumber";
            this.lblWordNumber.Size = new System.Drawing.Size(80, 13);
            this.lblWordNumber.TabIndex = 8;
            this.lblWordNumber.Text = "Word number : ";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(740, 312);
            this.tabControl.TabIndex = 9;
            // 
            // tab1
            // 
            this.tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab1.Controls.Add(this.lsbOptions);
            this.tab1.Controls.Add(this.rtbText);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(732, 283);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Editor";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(732, 283);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Modules";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblWordNumber);
            this.Controls.Add(this.lblLineNumber);
            this.Controls.Add(this.lblnumberNum);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EncoLyze";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbOptions;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toUPPERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tolowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblnumberNum;
        private System.Windows.Forms.Label lblLineNumber;
        private System.Windows.Forms.Label lblWordNumber;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
    }
}

