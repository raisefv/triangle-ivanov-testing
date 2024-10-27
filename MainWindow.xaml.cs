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

namespace Triangle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            int strA, strB, strC;
            try
            {
                strA = Convert.ToInt32(n1.Text);
                strB = Convert.ToInt32(n2.Text);
                strC = Convert.ToInt32(n3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите числовое значение");
                return;
            }
            if (strA + strB < strC || strA + strC < strB || strB + strC < strA) { MessageBox.Show("Треугольника с такими сторонами не существует"); return; }
            if (strA < 0 || strB < 0 || strC < 0) { MessageBox.Show("Введите положительные числа"); return; }
            if (strA == 0 || strB == 0 || strC == 0) { MessageBox.Show("Треугольника с такими сторонами не существует"); return; }
            if (strA == strB && strB == strC && strA == strC)
            {
                t.Content = "Треугольник равносторонний";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                s1.Visibility = Visibility.Hidden;
                s2.Visibility = Visibility.Hidden;
                s3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
                return;
            }
            if (strA == strB || strB == strC || strA == strC)
            {
                t.Content = "Треугольник равнобедренный";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                s1.Visibility = Visibility.Hidden;
                s2.Visibility = Visibility.Hidden;
                s3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
                return;
            }
            if (strA != strB && strB != strC && strB != strC)
            {
                t.Content = "Треугольник разносторонний";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                s1.Visibility = Visibility.Hidden;
                s2.Visibility = Visibility.Hidden;
                s3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
                return;
            }
        }

        private void again_Click(object sender, RoutedEventArgs e)
        {
            proverka.Visibility = Visibility.Visible;
            again.Visibility = Visibility.Hidden;
            n1.Visibility = Visibility.Visible;
            n2.Visibility = Visibility.Visible;
            n3.Visibility = Visibility.Visible;
            s1.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Hidden;
            s3.Visibility = Visibility.Hidden;
            t.Content = "Введите длины сторон треугольника";
        }
    }
}
