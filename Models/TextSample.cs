using System.ComponentModel;
using System.Windows.Media;

namespace FontSamples.Models
{
    class TextSample : INotifyPropertyChanged
    {
        private string text;
        private FontFamily font;
        private int pointSize;

        public int PointSize
        {
            get { return pointSize; }
            set { pointSize = value; }
        }

        public FontFamily Font
        {
            get { return font; }
            set { font = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RasiePropertChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
