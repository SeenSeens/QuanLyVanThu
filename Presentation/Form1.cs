using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CoQuan_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UICoQuan());
            Title.Controls.Clear();
            Title.Controls.Add(new CoQuanTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new Horizontal());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }

        private void DonViNhan_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UIDonViNhan());
            Title.Controls.Clear();
            Title.Controls.Add(new DonViNhanTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new Horizontal());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }

        private void LoaiCongVan_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UILoaiCongVan());
            Title.Controls.Clear();
            Title.Controls.Add(new LoaiCongVanTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new Horizontal());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }

        private void PhieuGui_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UIPhieuGui());
            Title.Controls.Clear();
            Title.Controls.Add(new PhieuGuiTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new Horizontal());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }

        private void PhieuNhan_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UIPhieuNhan());
            Title.Controls.Clear();
            Title.Controls.Add(new PhieuNhanTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new Horizontal());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }

        private void VanThu_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(new UIVanThu());
            Title.Controls.Clear();
            Title.Controls.Add(new VanThuTitle());
            pnHori.Controls.Clear();
            pnHori.Controls.Add(new VanThu.OptionsVanThu());
            pnBottom.Controls.Clear();
            pnBottom.Controls.Add(new Move());
        }    
    }
}
