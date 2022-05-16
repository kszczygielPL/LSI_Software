using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSI_Software.Data;

namespace LSI_Software
{
    public partial class SimpleReport : Form
    {
        public SimpleReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void sbConfirm_Click(object sender, EventArgs e)
        {
            string _searchCriteriaForLocal = teLocalName.EditValue != null? teLocalName.EditValue.ToString() : String.Empty;
            DateTime? dateTimeFrom = deDateFrom.EditValue == null ? null: deDateFrom.DateTime ;
            DateTime? dateTimeTo = deDateTo.EditValue == null ? null : deDateTo.DateTime.AddDays(1);


            exportHistoryElementBindingSource.DataSource =
                DataSource.LoadExportHistoryList(_searchCriteriaForLocal, dateTimeFrom, dateTimeTo);
        }
    }
}
