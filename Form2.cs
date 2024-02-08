using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjectionWithTwoWindowsForms
{
    public partial class Form2 : Form
    {
        private IConfiguration? _configuration;
        private ILogger<Form2> _logger;
        private IGetNextNumber? _getNextNumber;
        /*
        public Form2(IConfiguration? configuration, ILogger<Form2> logger, IGetNextNumber? getNextNumber)
        {
            InitializeComponent();
            _configuration = configuration;
            _logger = logger;
            _getNextNumber = getNextNumber;
        }
        */
        public Form2()
        {
            InitializeComponent();
            _configuration = Program.ServiceProvider.GetRequiredService<IConfiguration>();
            _logger = Program.ServiceProvider.GetRequiredService<ILogger<Form2>>();
            _getNextNumber = Program.ServiceProvider.GetRequiredService<IGetNextNumber>();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxNextNumber.Text = _getNextNumber.GetNextNumber().ToString();
            textBoxSettingValue.Text = _configuration.GetValue<string>("MyTestKey:Message");
            _logger.LogInformation("This is a logged message from form2");
        }
    }
}
