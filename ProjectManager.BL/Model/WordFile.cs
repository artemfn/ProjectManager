using Microsoft.Office.Interop.Word;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public sealed class WordFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Document _document;


        public WordFile(string name, string path, bool visible) : base(name, path)
        {
            _application = new Application()
            {
                Visible = visible
            };
            _document = _application.Documents.Add();
        }

        public WordFile(string fullPath, bool visible) : base(fullPath)
        {
            _application = new Application()
            {
                Visible = visible
            };
            _document = _application.Documents.Add();
        }


        public override void Save()
        {
            if (!File.Exists(FullPath))
            {
                try
                {
                    _document.SaveAs(FullPath);
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
                        _application.Documents.Open(FullPath, ReadOnly: false);
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

        public override void Dispose()
        {
            _application.Quit();
            Marshal.ReleaseComObject(_application);
        }
    }
}