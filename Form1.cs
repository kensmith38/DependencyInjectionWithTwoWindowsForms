using Microsoft.Extensions.Configuration;

namespace DependencyInjectionWithTwoWindowsForms
{
    public partial class Form1 : Form
    {
        private IConfiguration? _configuration;
        private IGetNextNumber? _getNextNumber;
        public Form1(IConfiguration? configuration, IGetNextNumber? getNextNumber)
        {
            InitializeComponent();
            _configuration = configuration;
            _getNextNumber = getNextNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSettingValue.Text = _configuration.GetValue<string>("MyTestKey:Message");
            textBoxNextNumber.Text = _getNextNumber.GetNextNumber().ToString();
        }

        private void buttonLaunchForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
