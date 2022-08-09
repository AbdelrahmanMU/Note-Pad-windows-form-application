using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frm_info : Form
    {
        public int id { get; set; }
        public frm_info(int id)
        {
            InitializeComponent();

            this.id = id;
            lbl_id.Text = Convert.ToString(id);
        }
        
    }
}
