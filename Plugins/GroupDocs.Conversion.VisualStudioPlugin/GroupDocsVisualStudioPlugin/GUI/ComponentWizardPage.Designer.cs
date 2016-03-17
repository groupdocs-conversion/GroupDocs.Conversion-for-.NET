using GroupDocsConversionVisualStudioPlugin.Core;
namespace GroupDocsConversionVisualStudioPlugin.GUI
{
    partial class ComponentWizardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentWizardPage));
            this.groupBoxCommonUses = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabelGroupDocs = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toolStripStatusMessage = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCommonUses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCommonUses
            // 
            this.groupBoxCommonUses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommonUses.Controls.Add(this.label2);
            this.groupBoxCommonUses.Controls.Add(this.button1);
            this.groupBoxCommonUses.Controls.Add(this.linkLabelGroupDocs);
            this.groupBoxCommonUses.Font = new System.Drawing.Font("Calibri", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCommonUses.Location = new System.Drawing.Point(12, 136);
            this.groupBoxCommonUses.Name = "groupBoxCommonUses";
            this.groupBoxCommonUses.Size = new System.Drawing.Size(474, 275);
            this.groupBoxCommonUses.TabIndex = 1;
            this.groupBoxCommonUses.TabStop = false;
            this.groupBoxCommonUses.Text = "Common Uses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 182);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::GroupDocsConversionVisualStudioPlugin.Properties.Resources.groupdocs_conversion;
            this.button1.Location = new System.Drawing.Point(6, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 131);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabelGroupDocs
            // 
            this.linkLabelGroupDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGroupDocs.AutoSize = true;
            this.linkLabelGroupDocs.LinkArea = new System.Windows.Forms.LinkArea(6, 9);
            this.linkLabelGroupDocs.Location = new System.Drawing.Point(12, 255);
            this.linkLabelGroupDocs.Name = "linkLabelGroupDocs";
            this.linkLabelGroupDocs.Size = new System.Drawing.Size(161, 19);
            this.linkLabelGroupDocs.TabIndex = 1;
            this.linkLabelGroupDocs.TabStop = true;
            this.linkLabelGroupDocs.Text = "Visit GroupDocs for more details.";
            this.linkLabelGroupDocs.UseCompatibleTextRendering = true;
            this.linkLabelGroupDocs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAspose_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 102);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(474, 28);
            this.progressBar.TabIndex = 3;
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripStatusMessage.AutoSize = true;
            this.toolStripStatusMessage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusMessage.Location = new System.Drawing.Point(10, 85);
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(99, 14);
            this.toolStripStatusMessage.TabIndex = 4;
            this.toolStripStatusMessage.Text = "Fetching API info...";
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortButton.Location = new System.Drawing.Point(411, 426);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 7;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(330, 425);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 1);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Image = global::GroupDocsConversionVisualStudioPlugin.Properties.Resources.Banner;
            this.label1.Location = new System.Drawing.Point(-39, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "           GroupDocs.Conversion for .NET API Examples";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComponentWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripStatusMessage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBoxCommonUses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 500);
            this.MinimizeBox = false;
            this.Name = "ComponentWizardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupDocs Visual Studio Plugin";
            this.groupBoxCommonUses.ResumeLayout(false);
            this.groupBoxCommonUses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCommonUses;
        private System.Windows.Forms.LinkLabel linkLabelGroupDocs;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label toolStripStatusMessage;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}