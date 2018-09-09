using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace Presentation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string server = "";
        string database = "";
        string connect = "";
        static string duongDan = System.IO.Directory.GetCurrentDirectory() + "\\QuanLyVanThu.mdf;";
        string DEFAULT = @"Data Source=.\SQLEXPRESS  ;AttachDbFilename=" + duongDan + "Integrated Security=True;Connect Timeout=30";
        private void Form2_Load(object sender, EventArgs e)
        {
            //cbAuthentication.SelectedIndex = 0;
        }
        //private void connectWindows()
        //{
        //    server = cbTenmaychu.Text.Trim();
        //    database = cbCSDL.Text.Trim();
        //    connect = @"Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=True";
        //    DataProvider.
        //}
    }
}
