using System;
using System.Windows;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

    namespace Excel2 
    {
        class Program
        {
            static void Main(string[] args)
            {
                _Application excel = new _Excel.Application();
                Workbook wb;
                Worksheet ws;
                int i = 1, j = 1;
                wb = excel.Workbooks.Open(@"C:\Users\бююбт\Desktop\C#.xlsx");
                ws = wb.Worksheets[1];
                if (ws.Cells[i, j].Value2 != null)
                    MessageBox.Show(ws.Cells[i, j].Value2);
                else
                    MessageBox.Show("");
            }
        }


    }

