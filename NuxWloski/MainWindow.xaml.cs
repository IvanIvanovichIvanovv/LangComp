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

namespace NuxWloski
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomWord = new Random();
        Random randomLanguage = new Random();
        public MainWindow()
        {
            InitializeComponent();
            Methods.LoadData();
            int rWord = randomWord.Next(Methods.words.Count);
            int rLanguage = randomLanguage.Next(0, 2);
            Methods.SelectedWord = Methods.words[rWord];
            Methods.Language = rLanguage;
            if (Methods.Language == 0)
            {
                Lbl_Word.Content = Methods.SelectedWord.Italian;
            }
            else
            {
                Lbl_Word.Content = Methods.SelectedWord.Polish;
            }
        }

        private void Btn_submit_Click(object sender, RoutedEventArgs e)
        {
            if (Methods.Language == 0) 
            {
                if (Methods.SelectedWord.Polish == TB_Answer.Text)
                {
                    Lbl_Result.Content = "Correct";
                    Lbl_Result.Foreground = Brushes.Green;
                }
                else 
                {
                    Lbl_Result.Content = "Wrong";
                    Lbl_Result.Foreground = Brushes.Red;
                }
            }
            if (Methods.Language == 1)
            {
                if (Methods.SelectedWord.Italian == TB_Answer.Text)
                {
                    Lbl_Result.Content = "Correct";
                    Lbl_Result.Foreground = Brushes.DarkGreen;
                }
                else
                {
                    Lbl_Result.Content = "Wrong";
                    Lbl_Result.Foreground = Brushes.Red;
                }
            }
            TB_Answer.Text = "";
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            int rWord = randomWord.Next(Methods.words.Count);
            int rLanguage = randomLanguage.Next(0,2);
            Methods.SelectedWord=Methods.words[rWord];
            Methods.Language = rLanguage;
            if (Methods.Language == 0)
            {
                Lbl_Word.Content = Methods.SelectedWord.Italian;
            }
            else 
            {
                Lbl_Word.Content = Methods.SelectedWord.Polish;
            }
        }

        private void TB_Answer_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter) 
            {
                Btn_submit_Click(sender, e);
            }
            if (e.Key == System.Windows.Input.Key.F1)
            {
                Btn_Next_Click(sender, e);
            }
        }
    }
}
