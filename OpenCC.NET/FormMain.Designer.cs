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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnApply = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.comboBoxSourceType = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetType = new System.Windows.Forms.ComboBox();
            this.checkBoxWordChange = new System.Windows.Forms.CheckBox();
            this.checkBoxCopy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.AllowDrop = true;
            resources.ApplyResources(this.textBoxContent, "textBoxContent");
            this.textBoxContent.Name = "textBoxContent";
            // 
            // comboBoxSourceType
            // 
            resources.ApplyResources(this.comboBoxSourceType, "comboBoxSourceType");
            this.comboBoxSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceType.FormattingEnabled = true;
            this.comboBoxSourceType.Items.AddRange(new object[] {
            resources.GetString("comboBoxSourceType.Items"),
            resources.GetString("comboBoxSourceType.Items1"),
            resources.GetString("comboBoxSourceType.Items2"),
            resources.GetString("comboBoxSourceType.Items3")});
            this.comboBoxSourceType.Name = "comboBoxSourceType";
            this.comboBoxSourceType.SelectedIndexChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // comboBoxTargetType
            // 
            resources.ApplyResources(this.comboBoxTargetType, "comboBoxTargetType");
            this.comboBoxTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetType.FormattingEnabled = true;
            this.comboBoxTargetType.Items.AddRange(new object[] {
            resources.GetString("comboBoxTargetType.Items"),
            resources.GetString("comboBoxTargetType.Items1"),
            resources.GetString("comboBoxTargetType.Items2"),
            resources.GetString("comboBoxTargetType.Items3")});
            this.comboBoxTargetType.Name = "comboBoxTargetType";
            this.comboBoxTargetType.SelectedIndexChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // checkBoxWordChange
            // 
            resources.ApplyResources(this.checkBoxWordChange, "checkBoxWordChange");
            this.checkBoxWordChange.Checked = true;
            this.checkBoxWordChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWordChange.Name = "checkBoxWordChange";
            this.checkBoxWordChange.UseVisualStyleBackColor = true;
            this.checkBoxWordChange.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // checkBoxCopy
            // 
            resources.ApplyResources(this.checkBoxCopy, "checkBoxCopy");
            this.checkBoxCopy.Checked = true;
            this.checkBoxCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCopy.Name = "checkBoxCopy";
            this.checkBoxCopy.UseVisualStyleBackColor = true;
            this.checkBoxCopy.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCopy);
            this.Controls.Add(this.checkBoxWordChange);
            this.Controls.Add(this.comboBoxTargetType);
            this.Controls.Add(this.comboBoxSourceType);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.btnApply);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.ResizeEnd += new System.EventHandler(this.SettingsChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnApply;
        private TextBox textBoxContent;
        private ComboBox comboBoxSourceType;
        private ComboBox comboBoxTargetType;
        private CheckBox checkBoxWordChange;
        private CheckBox checkBoxCopy;
    }
}