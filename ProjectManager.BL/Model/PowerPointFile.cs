using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public sealed class PowerPointFile : ProjectFile
    {
        private readonly Application _application;
        private readonly Presentation _presentation;


        public PowerPointFile(string name, string path, MsoTriState visible) : base(name, path)
        {
            _application = new Application();
            _presentation = _application.Presentations.Add(MsoTriState.msoTrue);
        }

        public PowerPointFile(string fullPath, MsoTriState visible) : base(fullPath)
        {
            _application = new Application()
            {
                Visible = visible
            };
            _presentation = _application.Presentations.Add(MsoTriState.msoTrue);
        }


        public override void Save()
        {
            if (!File.Exists(FullPath))
            {
                try
                {
                    _presentation.SaveAs(FullPath, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
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
                        _application.Presentations.Open(FullPath);
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

        public override void Dispose()
        {
            // ???
        }
    }
}