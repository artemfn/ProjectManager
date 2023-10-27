using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System;
using System.Diagnostics;
using System.IO;

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


        public override void Save()
        {
            if (!File.Exists(Path))
            {
                try
                {
                    _workbook.SaveAs(Path, MsoTriState.msoTrue);
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
            if (File.Exists(Path))
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

            throw new InvalidOperationException(nameof(Open));
        }

        public override void Close()
        {
            if (File.Exists(Path))
            {
                foreach (var process in Process.GetProcesses("EXCEL"))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
            else
            {
                throw new InvalidOperationException(nameof(Close));
            }
        }
    }
}
