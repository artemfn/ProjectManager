using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System;

namespace ProjectManager.BL.Model
{
    public class PowerPointFile : ProjectFile
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


        public override void Open()
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

        public override void Save()
        {
            _presentation.SaveAs(Path, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
        }
    }
}