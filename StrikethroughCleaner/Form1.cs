using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace StrikethroughCleaner {
    public partial class Form1:Form {

        private string fileLocation;
        Microsoft.Office.Interop.Excel.Application app;
        Workbook workbook;

        public Form1() {
            InitializeComponent();
        }

        private void buttonSelectExcelWorksheet_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Filter = "Excel Worksheets (*.xls,*.xlsx)|*.xls;*.xlsx";
                DialogResult result = dialog.ShowDialog();
                if(result == DialogResult.OK) {
                    fileLocation = dialog.FileName;
                    textBoxFileLocation.Text = fileLocation;
                    buttonClean.Enabled = true;
                    buttonClean.BackColor = Color.LimeGreen;
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e) {
            if(fileLocation != null) {
                app = new Microsoft.Office.Interop.Excel.Application();
                workbook = app.Workbooks.Open(fileLocation);
                Worksheet worksheet = (Worksheet)workbook.Worksheets.get_Item(1);
                Range range = worksheet.UsedRange;

                for(int rCnt = 1; rCnt <= range.Rows.Count; rCnt++) {
                    for(int cCnt = 1; cCnt <= range.Columns.Count; cCnt++) {
                        toolStripStatusLabel.Text = "Cleaning cell: " + rCnt.ToString() + ", " + cCnt.ToString();
                        Range currentCell = range.Cells[rCnt, cCnt];
                        string cleanString = "";

                        for(int pos = 0; pos < currentCell.ToString().Length; pos++) {
                            if(!(bool)currentCell.Characters[pos, 1].Font.Strikethrough) {
                                cleanString += currentCell.Characters[pos, 1];
                                worksheet.Cells[rCnt,cCnt] = cleanString;
                            }
                        }
                    }
                }
            }

            using(SaveFileDialog saveDialog = new SaveFileDialog()) {
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                DialogResult saveResult = saveDialog.ShowDialog();
                if(saveResult == DialogResult.OK) {
                    fileLocation = saveDialog.FileName;
                    workbook.SaveAs(fileLocation);
                }

                if(workbook != null) {
                    workbook.Close();
                }
                if(app != null) {
                    app.Quit();
                }
            }

            GC.Collect();
        }

        ~Form1() {
            if(workbook != null) {
                workbook.Close();
            }
            if(app != null) {
                app.Quit();
            }
        }
    }
}
