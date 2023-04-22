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

        private void btnApply_Click(object sender, EventArgs e)
        {
            int sourceType = comboBoxSourceType.SelectedIndex;
            int targetType = comboBoxTargetType.SelectedIndex;
            if (sourceType == 0)
            {
                if (targetType == 0)
                    textBoxContent.Text = ZhConverter.HansToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                else if (targetType == 2)
                {
                    textBoxContent.Text = ZhConverter.HansToHant(textBoxContent.Text);
                }
                else if (targetType == 3)
                {
                    textBoxContent.Text = ZhConverter.HansToHK(textBoxContent.Text);
                }
            }
            else if (sourceType == 1)
            {
                if (targetType == 0)
                    textBoxContent.Text = ZhConverter.HantToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                else if (targetType == 1)
                {
                    textBoxContent.Text = ZhConverter.HantToHans(textBoxContent.Text);
                }
                else if (targetType == 3)
                {
                    textBoxContent.Text = ZhConverter.HantToHK(textBoxContent.Text);
                }
            }
            else if (sourceType == 2)
            {
                if (targetType == 0)
                {
                    textBoxContent.Text = ZhConverter.HansToTW(ZhConverter.HKToHans(textBoxContent.Text));
                }
                else if (targetType == 1)
                {
                    textBoxContent.Text = ZhConverter.HKToHans(textBoxContent.Text);
                }
                else if (targetType == 2)
                {
                    textBoxContent.Text = ZhConverter.HKToHans(textBoxContent.Text);
                }
            }
            else if (sourceType == 3)
            {
                if (targetType == 1)
                {
                    textBoxContent.Text = ZhConverter.TWToHans(textBoxContent.Text, checkBoxWordChange.Checked);
                }
                else if (targetType == 2)
                {
                    textBoxContent.Text = ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked);
                }
                else if (targetType == 3)
                {
                    textBoxContent.Text = ZhConverter.HansToHK(ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked));
                }
            }
        }

    }
}