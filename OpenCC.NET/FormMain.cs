using OpenCCNET;

namespace OpenCC.NET
{
    public partial class FormMain : Form
    {
        bool settingUpdateLock = false;
        public FormMain()
        {
            //view设置
            InitializeComponent();

            //controller设置
            KeyPreview = true;
            KeyDown += FormMain_KeyDown;
            ZhConverter.Initialize();

            //读取setting文件
            Setting setting = Setting.GetInstance();
            setting.Load();
            setting = Setting.GetInstance();
            //应用setting文件
            switch (setting.SourceType)
            {
                case "s":
                    comboBoxSourceType.SelectedIndex = 0;
                    break;
                case "t":
                    comboBoxSourceType.SelectedIndex = 1;
                    break;
                case "hk":
                    comboBoxSourceType.SelectedIndex = 2;
                    break;
                case "tw":
                    comboBoxSourceType.SelectedIndex = 3;
                    break;
            }
            switch (setting.TargetType)
            {
                case "s":
                    comboBoxTargetType.SelectedIndex = 0;
                    break;
                case "t":
                    comboBoxTargetType.SelectedIndex = 1;
                    break;
                case "hk":
                    comboBoxTargetType.SelectedIndex = 2;
                    break;
                case "tw":
                    comboBoxTargetType.SelectedIndex = 3;
                    break;
            }
            checkBoxWordChange.Checked = setting.EnableWordChange;
            checkBoxCopy.Checked = setting.EnableCopyToClip;
            settingUpdateLock = true;
        }

        //快捷键
        private void FormMain_KeyDown(object? sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = (e.KeyData == (Keys.Control | Keys.Enter));
            if (e.KeyData == (Keys.Control | Keys.Enter))
            { btnApply.PerformClick(); }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
            int sourceType = comboBoxSourceType.SelectedIndex;
            int targetType = comboBoxTargetType.SelectedIndex;

            switch (sourceType)
            {
                //Hans
                case 0:
                    switch (targetType)
                    {
                        case 1:
                            textBoxContent.Text = ZhConverter.HansToHant(textBoxContent.Text);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.HansToHK(textBoxContent.Text);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HansToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                    }
                    break;
                //Hant
                case 1:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.HantToHans(textBoxContent.Text);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.HantToHK(textBoxContent.Text);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HantToTW(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                    }
                    break;
                //HK
                case 2:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.HKToHans(textBoxContent.Text);
                            break;
                        case 1:
                            textBoxContent.Text = ZhConverter.HKToHant(textBoxContent.Text);
                            break;
                        case 3:
                            textBoxContent.Text = ZhConverter.HansToTW(ZhConverter.HKToHans(textBoxContent.Text));
                            break;
                    }
                    break;
                //TW
                case 3:
                    switch (targetType)
                    {
                        case 0:
                            textBoxContent.Text = ZhConverter.TWToHans(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 1:
                            textBoxContent.Text = ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked);
                            break;
                        case 2:
                            textBoxContent.Text = ZhConverter.HansToHK(ZhConverter.TWToHant(textBoxContent.Text, checkBoxWordChange.Checked));
                            break;
                    }
                    break;
            }
            textBoxContent.Focus();
            textBoxContent.SelectAll();
            if (checkBoxCopy.Checked)
            { Clipboard.SetDataObject(textBoxContent.Text); }
            btnApply.Enabled = true;
        }
        //界面设置修改
        private void SettingsChanged(object sender, EventArgs e)
        {
            if (settingUpdateLock)
            {
                Setting setting = Setting.GetInstance();
                string UiSourceType = "s";
                string UiTargetType = "tw";
                switch (comboBoxSourceType.SelectedIndex)
                {
                    case 0:
                        UiSourceType = "s";
                        break;
                    case 1:
                        UiSourceType = "t";
                        break;
                    case 2:
                        UiSourceType = "hk";
                        break;
                    case 3:
                        UiSourceType = "tw";
                        break;
                }
                switch (comboBoxTargetType.SelectedIndex)
                {
                    case 0:
                        UiTargetType = "s";
                        break;
                    case 1:
                        UiTargetType = "t";
                        break;
                    case 2:
                        UiTargetType = "hk";
                        break;
                    case 3:
                        UiTargetType = "tw";
                        break;
                    default:
                        break;
                }
                bool UiEnableWordChange = checkBoxWordChange.Checked;
                bool UienableCopyToClip = checkBoxCopy.Checked;
                Setting.GetInstance(UiSourceType, UiTargetType, UiEnableWordChange, UienableCopyToClip);
                _ = setting.SaveAsync();
            }
        }
    }
}