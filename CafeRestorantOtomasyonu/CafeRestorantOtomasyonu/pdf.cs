using CafeRestorantOtomasyonu.DbContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestorantOtomasyonu
{
    public partial class pdf : Form
    {
        public pdf()
        {
            InitializeComponent();
        }

        private void pdf_Load(object sender, EventArgs e)
        {
            if(TableForm.odeme)
                axAcroPDF1.LoadFile(TableForm.receiptID.ToString()+".pdf");
        }
    }
}
