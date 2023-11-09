using Microsoft.Office.Interop.Excel;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public sealed class ExcelFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Workbook _workbook;


        public ExcelFile(string name, string path, bool visible) : base(name, path)
        {
            _application = new Application()
            {
                Visible = visible
            };
            _workbook = _application.Workbooks.Add();
        }

        public ExcelFile(string fullPath, bool visible) : base(fullPath)
        {
            _application = new Application()
            {
                Visible = visible
            };
            _workbook = _application.Workbooks.Add();
        }


        public override void Save()
        {
            if (!File.Exists(FullPath))
            {
                try
                {
                    _workbook.SaveAs(FullPath);
                }
                catch (IOException e)
                {
                    throw new InvalidOperationException(nameof(Save), e);
                }
            }
            else
            {
                throw new InvalidOperationException(nameof(Save));
            }
        }

        public override void Open()
        {
            if (File.Exists(FullPath))
            {
                while (true)
                {
                    try
                    {
                        _application.Workbooks.Open(FullPath);
                        return;
                    }
                    catch (Exception e)
                    {
                        _workbook.Close();
                    }
                }
            }

            throw new InvalidOperationException(nameof(Open));
        }

        public override void Dispose() // !?
        {
            _application.Quit();
            Marshal.ReleaseComObject(_application);
        }
    }
}
