using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dossier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbDespegable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbDespegable.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }
        DataTableCollection tableCollection;
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog=new OpenFileDialog() { Filter="Excel 97-2016 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    txtArchivo.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using(IExcelDataReader reader=ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbDespegable.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbDespegable.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
