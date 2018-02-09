using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace FontSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 24, 28, 36, 48, 72, 144 };
        private int currentFontSize = 24;

        public MainWindow()
        {
            InitializeComponent();

            Prep();
            PopulateCB();
        }

        private void Prep()
        {
            foreach(int i in fontSizes)
            {
                FontSizeSelector.Items.Add(i);
            }

            TextPreview.FontSize = currentFontSize;
            TextPreview.TextWrapping = TextWrapping.Wrap;
            TextPreview.LineStackingStrategy = LineStackingStrategy.BlockLineHeight;
            FontSizeSelector.SelectedIndex = 10;
            CBSamples.SelectedIndex = 0;
        }

        private void PopulateCB()
        {
            

            foreach (FontFamily family in Fonts.SystemFontFamilies)
            {
                Dictionary<string, FontFamily> fontList = new Dictionary<string, FontFamily>();

                IEnumerator<string> fontNames = family.FamilyNames.Values.GetEnumerator();

                while(fontNames.MoveNext())
                {
                    string font = fontNames.Current.ToString();

                    if (!fontList.ContainsKey(font))
                    {
                        FontFamily currentFamily = new FontFamily(font);

                        fontList.Add(font, currentFamily);

                        Label label = new Label();
                        label.Content = font;
                        label.FontFamily = currentFamily;
                        label.FontSize = 24;

                        CBSamples.Items.Add(label);
                    }
                }
            }
        }



        private void CBSamples_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Label label = (Label)CBSamples.SelectedItem;
            string family = label.Content.ToString();
            TextPreview.FontFamily = new FontFamily(family);
        }

        private void SampleText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CBSamples.SelectedItem != null)
            {
                TextPreview.Text = SampleText.Text;
            }
        }

        private void FontSizeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentFontSize = (int)FontSizeSelector.SelectedItem;
            TextPreview.FontSize = currentFontSize;
        }
    }
}
