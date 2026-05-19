using System;
using System.Linq;
using System.Windows;

namespace ExtensionMethodsTester
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCapitalize_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = InputTextBox.Text.CapitalizeLetter();
        }

        private void BtnRemoveVowels_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = InputTextBox.Text.RemoveVowels();
        }

        private void BtnLengthOfWords_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = InputTextBox.Text.LengthOfWords();
        }

        private void BtnIsProperSentence_Click(object sender, RoutedEventArgs e)
        {
            bool isProper = InputTextBox.Text.IsProperSentence();
            OutputTextBox.Text = isProper ? "True - It is a proper sentence." : "False - It is NOT a proper sentence.";
        }
    }
}