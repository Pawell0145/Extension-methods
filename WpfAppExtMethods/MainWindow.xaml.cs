using System;
using System.Linq;
using System.Windows;

namespace ExtensionMethodsTester
{
    public partial class MainWindow : Window
    {
        StringManipulator _manipulator = new StringManipulator();

        private void BtnCapitalize_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = _manipulator.CapitalizeLetter(InputTextBox.Text);
        }

        private void BtnRemoveVowels_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = _manipulator.RemoveVowels(InputTextBox.Text);
        }

        private void BtnLengthOfWords_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = _manipulator.LengthOfWords(InputTextBox.Text);
        }

        private void BtnIsProperSentence_Click(object sender, RoutedEventArgs e)
        {
            bool isProper = _manipulator.IsProperSentence(InputTextBox.Text);
            OutputTextBox.Text = isProper ? "True - It is a proper sentence." : "False - It is NOT a proper sentence.";
        }
    }
}