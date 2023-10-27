using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System;
using System.IO;
using System.Diagnostics;

namespace ProjectManager.BL.Model
{
    public sealed class PowerPointFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Presentation _presentation;


        public PowerPointFile(string path) : base(path)
        {
            _application = new Application()
            {
                Visible = MsoTriState.msoTrue
            };
            _presentation = _application.Presentations.Add(MsoTriState.msoTrue);
        }


        public override void Save()
        {
            if (!File.Exists(Path))
            {
                while (true)
                {
                    try
                    {
                        _presentation.SaveAs(Path, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
                    }
                    catch (IOException e)
                    {
                        throw new InvalidOperationException(nameof(Save), e);
                    }
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
                        _application.Presentations.Open(Path);
                        return;
                    }
                    catch (Exception e)
                    {
                        _presentation.Close();
                    }
                }
            }

            throw new InvalidOperationException(nameof(Open));
        }

        public override void Close()
        {
            if (File.Exists(Path))
            {
                foreach (var process in Process.GetProcesses("powerpnt"))
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