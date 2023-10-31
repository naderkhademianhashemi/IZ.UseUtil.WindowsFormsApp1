using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IZ_ORM.Utility;

namespace IZ.UseUtil.WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x =DateTime.Now.ToHourMinute();
            var y = DateTime.Now.ToShamsi();
            var z = DateTime.Now.GetDateName();
            var c=DateConverter.PersianDatewithTime();
            var d=DateTime.Now.PersianDatewithGivenTime();
            var s = DateConverter.ShamsiToMiladi(y, true);
            var f = Application.ExecutablePath;
            var path = "C:\\Users\\lenovo\\Documents\\job bank\\teknoresources\\contact.docx";
            //var fi = File.Read(path);
            var sep = 123456.SeperateNumberWithComma();
            var id = NumberToString.CreateRandomSaleReferenceId();
            var Hunthree=NumberToString.ConvertIntNumberToFarsiAlphabatic("303");
            var url = new FixedUrl().FixedUrlHelper("qwe uu ii");
        }
    }
}
