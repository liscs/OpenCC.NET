using OpenCCNET;

namespace OpenCC.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZhConverter.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourceType = comboBox1.SelectedItem.ToString();
            string targetType = comboBox2.SelectedItem.ToString();
            if (sourceType == "简体中文") 
            {
                if (targetType == "繁体中文（台湾）")
                    textBox1.Text = ZhConverter.HansToTW(textBox1.Text, checkBox1.Checked);
                else if (targetType == "简体中文") ;
                else if (targetType == "繁体中文") 
                {
                    textBox1.Text = ZhConverter.HansToHant(textBox1.Text);
                }
                else if(targetType == "繁体中文（香港）")
                {
                    textBox1.Text = ZhConverter.HansToHK(textBox1.Text);
                }
            }
            else if(sourceType == "繁体中文")
            {
                if (targetType == "繁体中文（台湾）")
                    textBox1.Text = ZhConverter.HantToTW(textBox1.Text, checkBox1.Checked);
                else if (targetType == "简体中文")
                {
                    textBox1.Text = ZhConverter.HantToHans(textBox1.Text);
                }
                else if (targetType == "繁体中文") ;
                else if (targetType == "繁体中文（香港）")
                {
                    textBox1.Text = ZhConverter.HantToHK(textBox1.Text);
                }
            }
            else if(sourceType == "繁体中文（香港）")
            {
                if (targetType == "繁体中文（台湾）")
                {
                    textBox1.Text = ZhConverter.HansToTW(ZhConverter.HKToHans(textBox1.Text));
                }
                else if (targetType == "简体中文")
                {
                    textBox1.Text = ZhConverter.HKToHans(textBox1.Text);
                }
                else if (targetType == "繁体中文")
                {
                    textBox1.Text = ZhConverter.HKToHans(textBox1.Text);
                }
                else if (targetType == "繁体中文（香港）") ;
            }
            else if(sourceType == "繁体中文（台湾）")
            {
                if (targetType == "繁体中文（台湾）") ;
                else if (targetType == "简体中文")
                {
                    textBox1.Text = ZhConverter.TWToHans(textBox1.Text, checkBox1.Checked);
                }
                else if (targetType == "繁体中文")
                {
                    textBox1.Text = ZhConverter.TWToHant(textBox1.Text, checkBox1.Checked);
                }
                else if (targetType == "繁体中文（香港）")
                {
                    textBox1.Text = ZhConverter.HansToHK(ZhConverter.TWToHant(textBox1.Text, checkBox1.Checked));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}