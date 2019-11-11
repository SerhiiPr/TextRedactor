using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        //path for current file
        public string PathToFile;

        public MainWindow()
        {
            InitializeComponent();
            PathToFile = "";
            cmbFontSize.ItemsSource = new List<double>() 
            { 
                8, 9, 10, 11, 12, 14, 16, 18, 20, 
                22, 24, 26, 28, 36, 48, 72 
            };
        }

        private void ButtonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            // FileProcess tool for work with file
            FileProcess fileProcess = new FileProcess();
            //  fp.Save(richtexbox, label, string)
            PathToFile = fileProcess.Save(docBox, LabelShowFileName, PathToFile);
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // FileProcess tool for work with file
            FileProcess fileProcess = new FileProcess();
            //  fp.Open(richtexbox, label)
            PathToFile = fileProcess.Open(docBox, LabelShowFileName);
        }

        private void ButtonNewFile_Click(object sender, RoutedEventArgs e)
        {
            // FileProcess tool for work with file
            FileProcess fileProcess = new FileProcess();
            //  fp.Create(richtexbox, label)
            PathToFile = fileProcess.Create(docBox, LabelShowFileName);
        }

        private void docBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(docBox.Selection.Text);
            
            //docBox.FontSize=double.Parse(cmbFontSize.Text);
      
        }

        private void fonts_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.
            range.ApplyPropertyValue(RichTextBox.FontFamilyProperty,
                fonts.SelectedValue);

        }

        private void fonts_MouseDown(object sender, MouseButtonEventArgs e)
        {
       
        }

        private void fonts_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void colorPicker_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void docBox_LostFocus(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void colorPicker_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (colorPicker.SelectedColor != null)
            {
                SolidColorBrush b = new SolidColorBrush(colorPicker.SelectedColor.Value);
                //Brushes brush = new SolidColorBrush(colorPicker.SelectedColor.Value);
                TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.
                range.ApplyPropertyValue(RichTextBox.ForegroundProperty, b);
            }
        }

        private void fonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.
            range.ApplyPropertyValue(RichTextBox.FontFamilyProperty,
                fonts.SelectedValue);
        }

        private void bold_ico_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.
            

            if(range.GetPropertyValue(RichTextBox.FontWeightProperty).ToString() == FontWeights.Bold.ToString())
            {
                range.ApplyPropertyValue(RichTextBox.FontWeightProperty,
                   FontWeights.Regular);
            }
            else
            {
                range.ApplyPropertyValue(RichTextBox.FontWeightProperty,
                   FontWeights.Bold);
            }
        }

        private void italic_ico_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.

            if (range.GetPropertyValue(Inline.FontStyleProperty).ToString() == FontStyles.Italic.ToString())
            {
                range.ApplyPropertyValue(Inline.FontStyleProperty,
                 FontStyles.Italic);
            }
            else
            {
                range.ApplyPropertyValue(Inline.FontStyleProperty,
                   FontStyles.Normal);
            }
        }

        private void underline_ico_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // TextDecorations

        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange range = new TextRange(docBox.Selection.Start, docBox.Selection.End);    // Get RichTextBox content.


            try
            {

                range.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
            }
            catch
            {

            }


            //if (docBox.FontSize != double.Parse(cmbFontSize.Text))
            //{
            //    range.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
            //}

            
        }

       
    }
}
