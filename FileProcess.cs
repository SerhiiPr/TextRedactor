using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;


namespace TextRedactor
{
    // class (tool) for working with file
    public class FileProcess
    {
        // open file (richtexbox, label)
        public void Open(RichTextBox docBox, Label LabelShowFileName)
        {
            // object open file
            OpenFileDialog ofd = new OpenFileDialog();
            // filter .txt .rtf .pdf in open dialog
            ofd.Filter = "TXT File (*.txt)|*.txt|RTF File (*.rtf)|*.rtf|PDF File (*.pdf)|*.pdf";
            // load text from .rtf / .txt / .pdf to RichTextBox (according to choice)
            if (ofd.ShowDialog() == true)
            { // Show file name
                LabelShowFileName.Content = System.IO.Path.GetFileName(ofd.FileName);
                // document for load to docBox
                TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
                // process load to docBox
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    // triggered if open file was .rtf format
                    if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        doc.Load(fs, DataFormats.Rtf);
                    // triggered if open file was .txt format
                    else if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                        doc.Load(fs, DataFormats.Text);
                }
                // triggered if open file was .pdf format
                if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".pdf")
                {
                    // for process load to docBox
                    FlowDocument objFlowDoc = new FlowDocument();
                    Paragraph objParagraph = new Paragraph();
                    string strText = string.Empty;
                    //
                    // load from .pdf file
                    PdfReader reader = new PdfReader(ofd.FileName.ToString());
                    // parsing .pdf file
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                        string s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                        s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s))); // Encoding s
                        strText += s; // s it one page
                    }
                    reader.Close();
                    //
                    // process load to docBox
                    objParagraph.Inlines.Add(new Run(strText));
                    objFlowDoc.Blocks.Add(objParagraph);
                    docBox.Document = objFlowDoc;
                    //
                }
            }
        }

        //public void Creat()
        //{

        //}

        //public void Save()
        //{

        //}
    }
}
