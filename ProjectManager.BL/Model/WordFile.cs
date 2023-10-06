using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System;

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


        public override void Open()
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

        public override void Save()
        {
            _document.SaveAs(Path, MsoTriState.msoTrue);
        }
    }
}