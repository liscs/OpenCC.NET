using OpenCCNET;

namespace OpenCC.NET
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ZhConverter.Initialize();
            comboBoxSourceType.Items.AddRange(new object[] {
            "简体中文",
            "繁体中文",
            "繁体中文（香港）",
            "繁体中文（台湾）"});
            comboBoxTargetType.Items.AddRange(new object[] {
            "繁体中文（台湾）",
            "简体中文",
            "繁体中文",
            "繁体中文（香港）"});
            comboBoxSourceType.SelectedIndex = 0;
            comboBoxTargetType.SelectedIndex = 0;
        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = (e.KeyData == (Keys.Control | Keys.Enter));
            if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                btnApply.PerformClick();
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int sourceType = comboBoxSourceType.SelectedIndex;
            int targetType = comboBoxTargetType.SelectedIndex;
            
            switch (sourceType)
            {
                //Hans
                case 0:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.HansToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.HansToHant(textBoxContent.Text);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HansToHK(textBoxContent.Text);
                            break;
                    }
                    break;
                //Hant
                case 1:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.HantToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 1:
                            textBoxContent.Text = ZhConverter.HantToHans(textBoxContent.Text);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HantToHK(textBoxContent.Text);
                            break;
                    }
                    break;
                //HK
                case 2:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.HansToTW(ZhConverter.HKToHans(textBoxContent.Text));
                            break;
                        case 1:
                            textBoxContent.Text = ZhConverter.HKToHans(textBoxContent.Text);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.HKToHans(textBoxContent.Text);
                            break;
                    }
                    break;
                //TW
                case 3:
                    switch (targetType)
                    {
                        case 1:
                            textBoxContent.Text = ZhConverter.TWToHans(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HansToHK(ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked));
                            break;
                    }
                    break;
            }
            textBoxContent.Focus();
            textBoxContent.SelectAll();
        }

    }
}