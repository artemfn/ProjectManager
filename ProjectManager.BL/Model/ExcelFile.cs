using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System;

namespace ProjectManager.BL.Model
{
    public sealed class ExcelFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Workbook _workbook;


        public ExcelFile(string path) : base(path)
        {
            _application = new Application()
            {
                Visible = true
            };
            _workbook = _application.Workbooks.Add();
        }


        public override void Open()
        {
            while (true)
            {
                try
                {
                    _application.Workbooks.Open(Path);
                    return;
                }
                catch (Exception e)
                {
                    _workbook.Close();
                }
            }
        }

        public override void Save()
        {
            _workbook.SaveAs(Path, MsoTriState.msoTrue);
        }
    }
}
