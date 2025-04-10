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
using System.Windows.Shapes;

namespace App_Practice.Windows
{
    /// <summary>
    /// Логика взаимодействия для Practice11Window.xaml
    /// </summary>
    public partial class Practice11Window : Window
    {
        public Practice11Window()
        {
            InitializeComponent();
            for (int i = 1; i <= 29; i++)
            {
                TaskSelector.Items.Add(new { Content = $"Задание {i}" });
            }
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskSelector.SelectedIndex == -1) return;

            int taskNumber = TaskSelector.SelectedIndex + 1;
            ResultBox.Text = SolveTask(taskNumber);
        }

        private string SolveTask(int taskNumber)
        {
            try
            {
                switch (taskNumber)
                {
                    case 1: return SolveTask1();
                    case 2: return SolveTask2();
                    case 3: return SolveTask3();
                    case 4: return SolveTask4();
                    case 5: return SolveTask5();
                    case 6: return SolveTask6();
                    case 7: return SolveTask7();
                    case 8: return SolveTask8();
                    case 9: return SolveTask9();
                    case 10: return SolveTask10();
                    case 11: return SolveTask11();
                    case 12: return SolveTask12();
                    case 13: return SolveTask13();
                    case 14: return SolveTask14();
                    case 15: return SolveTask15();
                    case 16: return SolveTask16();
                    case 17: return SolveTask17();
                    case 18: return SolveTask18();
                    case 19: return SolveTask19();
                    case 20: return SolveTask20();
                    case 21: return SolveTask21();
                    case 22: return SolveTask22();
                    case 23: return SolveTask23();
                    case 24: return SolveTask24();
                    case 25: return SolveTask25();
                    case 26: return SolveTask26();
                    case 27: return SolveTask27();
                    case 28: return SolveTask28();
                    case 29: return SolveTask29();
                    default: return "Задание не реализовано";
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private string SolveTask1()
        {
            int[] array = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int evenCount = array.Count(x => x % 2 == 0);
            return $"Количество четных элементов: {evenCount}";
        }

        private string SolveTask2()
        {
            int[] array = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            double average = array.Average();
            int[] newArray = array.ToArray();
            newArray[4] = (int)average;
            return $"Новый массив: {string.Join(", ", newArray)}";
        }

        private string SolveTask3()
        {
            int[] array = new int[11] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            double average = array.Average();
            int count = array.Count(x => Math.Abs(x) > average);
            return $"Количество элементов, абсолютное значение которых больше среднего: {count}";
        }

        private string SolveTask4()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int maxIndex = Array.IndexOf(array, array.Max());
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;
            return $"Массив после замены: {string.Join(", ", array)}";
        }

        private string SolveTask5()
        {
            int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            return $"Массив после замены: {string.Join(", ", array)}";
        }

        private string SolveTask6()
        {
            int[] array = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int evenCount = array.Count(x => x % 2 == 0);
            int oddCount = array.Length - evenCount;
            return evenCount > oddCount ? "Четных больше" : "Нечетных больше";
        }

        private string SolveTask7()
        {
            double[] array = new double[15] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.1, 11.2, 12.3, 13.4, 14.5, 15.6 };
            int count = array.Count(x => x > array[0]);
            return $"Количество элементов, больших первого: {count}";
        }

        private string SolveTask8()
        {
            double[] array = new double[16] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.1, 11.2, 12.3, 13.4, 14.5, 15.6, 16.7 };
            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());
            return $"Индекс максимального элемента: {maxIndex}, индекс минимального элемента: {minIndex}";
        }

        private string SolveTask9()
        {
            int[] array = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            double average = array.Average();
            int[] newArray = array.Select(x => x - (int)average).ToArray();
            return $"Новый массив: {string.Join(", ", newArray)}";
        }

        private string SolveTask10()
        {
            int[] array = new int[17] { -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            double average = array.Where(x => x < 0).Select(Math.Abs).Average();
            int sum = array.Where(x => Math.Abs(x) > average).Sum();
            return $"Сумма элементов, абсолютное значение которых больше среднего: {sum}";
        }

        private string SolveTask11()
        {
            int[] array = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int evenCount = array.Count(x => x % 2 == 0 && x > 0);
            int sum = array.Where(x => x % 2 == 0 && x > 0).Sum();
            return $"Количество четных положительных элементов: {evenCount}, их сумма: {sum}";
        }

        private string SolveTask12()
        {
            double[] array = new double[12] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.1, 11.2, 12.3 };
            Array.Sort(array);
            Array.Reverse(array);
            double sum = array.Max() + array.Min();
            return $"Массив в порядке убывания: {string.Join(", ", array)}, сумма максимального и минимального: {sum}";
        }

        private string SolveTask13()
        {
            int[] array = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int max = array.Max();
            int min = array.Min();
            return $"Сумма: {max + min}, разность: {max - min}";
        }

        private string SolveTask14()
        {
            int[] array = new int[17] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int sumOdd = array.Where(x => x % 2 != 0).Sum();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = sumOdd;
                }
            }
            return $"Массив после замены: {string.Join(", ", array)}";
        }

        private string SolveTask15()
        {
            double[] array = new double[14];
            Array.Sort(array, 0, 7);
            Array.Sort(array, 7, 7);
            Array.Reverse(array, 7, 7);
            return $"Массив после сортировки: {string.Join(", ", array)}";
        }
        private string SolveTask16()
        {
            double[] array = new double[12];
            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());
            int count = Math.Abs(maxIndex - minIndex) - 1;
            return $"Количество элементов между максимальным и минимальным: {count}";
        }

        private string SolveTask17()
        {
            int[] array = new int[15];
            int negativeCount = array.Count(x => x < 0);
            int zeroCount = array.Count(x => x == 0);
            int product = array.Where(x => x > 0).Aggregate(1, (acc, x) => acc * x);
            return $"Количество отрицательных: {negativeCount}, произведение положительных: {product}, количество нулевых: {zeroCount}";
        }

        private string SolveTask18()
        {
            double[] array = new double[12];
            double min = array.Min();
            double max = array.Max();
            return $"Интервал значений: [{min}, {max}]";
        }

        private string SolveTask19()
        {
            int[] array = new int[19];
            int sum = 0;
            bool foundNegative = false;
            foreach (int x in array)
            {
                if (x < 0)
                {
                    foundNegative = true;
                    break;
                }
                sum += x;
            }
            return foundNegative ? $"Сумма до первого отрицательного: {sum}" : "Отрицательных элементов нет";
        }
        private string SolveTask20()
        {
            int[] array = new int[16];
            int replaceCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = 0;
                    replaceCount++;
                }
            }
            return $"Массив после замены: {string.Join(", ", array)}, количество замен: {replaceCount}";
        }

        private string SolveTask21()
        {
            double[] array = new double[12];
            int minIndex = Array.IndexOf(array, array.Min());
            array[minIndex] *= 3;
            double temp = array[minIndex];
            array[minIndex] = array[array.Length - 1];
            array[array.Length - 1] = temp;
            return $"Массив после изменений: {string.Join(", ", array)}";
        }

        private string SolveTask22()
        {
            double[] array = new double[15];
            Array.Reverse(array);
            return $"Массив в обратном порядке: {string.Join(", ", array)}";
        }

        private string SolveTask23()
        {
            int[] array = new int[14];
            int sumEvenIndex = array.Where((x, i) => i % 2 == 0).Sum();
            int productOddValue = array.Where(x => x % 2 != 0).Aggregate(1, (acc, x) => acc * x);
            return $"Сумма элементов с четными индексами: {sumEvenIndex}, произведение нечетных по значению: {productOddValue}";
        }

        private string SolveTask24()
        {
            double[] array = new double[12];
            double lastElement = array.Last();
            int count = array.Count(x => x < lastElement);
            double sum = array.Where(x => x < lastElement).Sum();
            return $"Количество элементов меньше последнего: {count}, их сумма: {sum}";
        }

        private string SolveTask25()
        {
            int[] array = new int[15];
            int sumPositive = array.Where(x => x > 0).Sum();
            int[] newArray = array.Select(x => x - sumPositive).ToArray();
            return $"Новый массив: {string.Join(", ", newArray)}";
        }

        private string SolveTask26()
        {
            double[] array = new double[15];
            double productPositive = array.Where(x => x > 0).Aggregate(1.0, (acc, x) => acc * x);
            double productNegative = array.Where(x => x < 0).Select(Math.Abs).Aggregate(1.0, (acc, x) => acc * x);
            double difference = productPositive - productNegative;
            return $"Разность произведений: {difference}";
        }

        private string SolveTask27()
        {
            int[] array = new int[19];
            int max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = max;
                }
            }
            return $"Массив после замены: {string.Join(", ", array)}";
        }

        private string SolveTask28()
        {
            int[] array = new int[17];
            double averagePositive = array.Where(x => x > 0).Average();
            int sum = array.Where(x => Math.Abs(x) > averagePositive).Sum();
            int count = array.Count(x => Math.Abs(x) > averagePositive);
            return $"Сумма: {sum}, количество: {count}";
        }

        private string SolveTask29()
        {
            double[] array = new double[18];
            double productPositive = array.Where(x => x > 0).Aggregate(1.0, (acc, x) => acc * x);
            double sumNegative = array.Where(x => x < 0).Select(Math.Abs).Sum();
            double quotient = productPositive / sumNegative;
            return $"Частное: {quotient}";
        }
    }
}

