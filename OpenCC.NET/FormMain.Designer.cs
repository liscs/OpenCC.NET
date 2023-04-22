namespace OpenCC.NET
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApply = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.comboBoxSourceType = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetType = new System.Windows.Forms.ComboBox();
            this.checkBoxWordChange = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(177, 253);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(149, 44);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "转换（Ctrl + Enter）";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.AllowDrop = true;
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContent.Location = new System.Drawing.Point(8, 8);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(466, 196);
            this.textBoxContent.TabIndex = 1;
            // 
            // comboBoxSourceType
            // 
            this.comboBoxSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceType.FormattingEnabled = true;
            this.comboBoxSourceType.Location = new System.Drawing.Point(32, 234);
            this.comboBoxSourceType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSourceType.Name = "comboBoxSourceType";
            this.comboBoxSourceType.Size = new System.Drawing.Size(117, 25);
            this.comboBoxSourceType.TabIndex = 2;
            // 
            // comboBoxTargetType
            // 
            this.comboBoxTargetType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetType.FormattingEnabled = true;
            this.comboBoxTargetType.Location = new System.Drawing.Point(32, 272);
            this.comboBoxTargetType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTargetType.Name = "comboBoxTargetType";
            this.comboBoxTargetType.Size = new System.Drawing.Size(117, 25);
            this.comboBoxTargetType.TabIndex = 3;
            // 
            // checkBoxWordChange
            // 
            this.checkBoxWordChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWordChange.AutoSize = true;
            this.checkBoxWordChange.Checked = true;
            this.checkBoxWordChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWordChange.Location = new System.Drawing.Point(74, 304);
            this.checkBoxWordChange.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxWordChange.Name = "checkBoxWordChange";
            this.checkBoxWordChange.Size = new System.Drawing.Size(75, 21);
            this.checkBoxWordChange.TabIndex = 4;
            this.checkBoxWordChange.Text = "词汇转换";
            this.checkBoxWordChange.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.checkBoxWordChange);
            this.Controls.Add(this.comboBoxTargetType);
            this.Controls.Add(this.comboBoxSourceType);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.btnApply);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(500, 375);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCC.NETG";
            this.ResumeLayout(false);
            this.PerformLayout();
            KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
        }

        #endregion

        private Button btnApply;
        private TextBox textBoxContent;
        private ComboBox comboBoxSourceType;
        private ComboBox comboBoxTargetType;
        private CheckBox checkBoxWordChange;
    }
}