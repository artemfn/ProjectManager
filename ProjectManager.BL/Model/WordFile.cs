using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System;
using System.IO;
using System.Diagnostics;

namespace ProjectManager.BL.Model
{
    public sealed class WordFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Document _document;


        public WordFile(string path) : base(path)
        {
            _application = new Application();
            _document = _application.Documents.Add(Visible: true);
        }


        public override void Save()
        {
            if (!File.Exists(Path))
            {
                try
                {
                    _document.SaveAs(Path, MsoTriState.msoTrue);
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
                        _application.Documents.Open(Path);
                        return;
                    }
                    catch (Exception e)
                    {
                        _document.Close();
                    }
                }
            }

            throw new InvalidOperationException(nameof(Open));
        }

        public override void Close()
        {
            if (File.Exists(Path))
            {
                foreach (var process in Process.GetProcessesByName("winword"))
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