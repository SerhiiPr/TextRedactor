using iTextSharp.text;
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
        public string Open(RichTextBox docBox, Label LabelShowFileName)
        {
            // object open file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // filter .txt .rtf .pdf in open dialog
            openFileDialog.Filter = "TXT File (*.txt)|*.txt|RTF File (*.rtf)|*.rtf|PDF File (*.pdf)|*.pdf";
            // load text from .rtf / .txt / .pdf to RichTextBox (according to choice)
            if (openFileDialog.ShowDialog() == true)
            { 
                // Show file name
                LabelShowFileName.Content = System.IO.Path.GetFileName(openFileDialog.FileName);
                // document for load to docBox
                TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
                // process load to docBox
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    // triggered if open file was .rtf format
                    if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".rtf")
                        doc.Load(fileStream, DataFormats.Rtf);
                    // triggered if open file was .txt format
                    else if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                        doc.Load(fileStream, DataFormats.Text);
                }
                // triggered if open file was .pdf format
                if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".pdf")
                {
                    //tmp string for process load to docBox
                    string strText = string.Empty;
                    // load from .pdf file
                    PdfReader reader = new PdfReader(openFileDialog.FileName.ToString());
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
                    // add text to docBox
                    FlowDocument flowDocument = new FlowDocument();
                    flowDocument.Blocks.Add(new System.Windows.Documents.Paragraph(new Run(strText)));
                    docBox.Document = flowDocument;
                    //
                }
            }
            return openFileDialog.FileName;
        }

        public string Create(RichTextBox docBox, Label LabelShowFileName)
        {
            //for new file
            if ((string)LabelShowFileName.Content != "")
            {
                LabelShowFileName.Content = "";
                docBox.Document.Blocks.Clear();
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //settings saveFileDialog
            saveFileDialog.FileName = "new file.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "TXT File (*.txt)|*.txt|RTF File (*.rtf)|*.rtf|PDF File (*.pdf)|*.pdf";
            //open file after create
            if (saveFileDialog.ShowDialog() == true)
            {
                using (var create = System.IO.File.OpenWrite(saveFileDialog.FileName))
                    LabelShowFileName.Content = System.IO.Path.GetFileName(saveFileDialog.FileName);
                    MessageBox.Show("Файл создан");
            }
            return saveFileDialog.FileName;
        }

        public string Save(RichTextBox docBox, Label LabelShowFileName, string PathToFile)
        {
            //if no file is specified
            if ((string)LabelShowFileName.Content == "")
            {
                if (MessageBox.Show("Сохранить в новый файл?", "Не указан файл!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    PathToFile = Create(docBox, LabelShowFileName);
                    PathToFile = Save(docBox, LabelShowFileName, PathToFile);
                }
            }
            else
            {
                ////save
                var docBoxTextRange = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
                switch (System.IO.Path.GetExtension(PathToFile).ToLower())
                {
                    case ".txt":
                        {
                            // сохраняем текст в файл
                            System.IO.File.WriteAllText(PathToFile, docBoxTextRange.Text);
                            MessageBox.Show("Файл сохранен");
                            break;
                        }
                    case ".rtf":
                        {
                            // сохраняем текст в файл
                            System.IO.File.WriteAllText(PathToFile, docBoxTextRange.Text);
                            MessageBox.Show("Файл сохранен");
                            break;
                        }
                    case ".pdf":
                        {
                            // step 1: creation of a document-object
                            Document document = new Document(PageSize.A4.Rotate());
                            try
                            {
                                // step 2:
                                // Now create a writer that listens to this doucment and writes the document to desired Stream.
                                PdfWriter.GetInstance(document, new FileStream(PathToFile, FileMode.Create));
                                // step 3:  Open the document now using
                                document.Open();
                                // step 4: Now add some contents to the document
                                document.Add(new iTextSharp.text.Paragraph(docBoxTextRange.Text));
                            }
                            catch (DocumentException de)
                            {
                                MessageBox.Show(de.Message);
                            }
                            catch (IOException ioe)
                            {
                                MessageBox.Show(ioe.Message);
                            }
                            // step 5: Remember to close the documnet
                            document.Close();
                            MessageBox.Show("Файл сохранен");
                            break;
                        }
                    default: { break; }
                }



            }
            return PathToFile;
        }
    }
}
