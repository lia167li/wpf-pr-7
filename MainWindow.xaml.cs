using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Math_practice7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskPanel.Children.Clear();

            switch (TaskComboBox.SelectedIndex)
            {
                case 0:
                    AddTask1Controls();
                    break;
                case 1:
                    AddTask2Controls();
                    break;
                case 2:
                    AddTask3Controls();
                    break;
                case 3:
                    AddTask4Controls();
                    break;
                case 4:
                    AddTask5Controls();
                    break;
                case 5:
                    AddTask6Controls();
                    break;
                case 6:
                    AddTask7Controls();
                    break;
                case 7:
                    AddTask8Controls();
                    break;
                case 8:
                    AddTask9Controls();
                    break;
                case 9:
                    AddTask10Controls();
                    break;
                case 10:
                    AddTask11Controls();
                    break;
                case 11:
                    AddTask12Controls();
                    break;
                case 12:
                    AddTask13Controls();
                    break;
                case 13:
                    AddTask14Controls();
                    break;
                case 14:
                    AddTask15Controls();
                    break;
                case 15:
                    AddTask16Controls();
                    break;
                case 16:
                    AddTask17Controls();
                    break;
                case 17:
                    AddTask18Controls();
                    break;
                case 18:
                    AddTask19Controls();
                    break;
                case 19:
                    AddTask20Controls();
                    break;
                case 20:
                    AddTask21Controls();
                    break;
                case 21:
                    AddTask22Controls();
                    break;
                case 22:
                    AddTask23Controls();
                    break;
                case 23:
                    AddTask24Controls();
                    break;
                case 24:
                    AddTask25Controls();
                    break;
                case 25:
                    AddTask26Controls();
                    break;
                case 26:
                    AddTask27Controls();
                    break;
                case 27:
                    AddTask28Controls();
                    break;
                case 28:
                    AddTask29Controls();
                    break;
                case 29:
                    AddTask30Controls();
                    break;
                default:
                    break;
            }
        }

        private void AddTask1Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа:" });
            var num1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(num1TextBox);
            TaskPanel.Children.Add(num2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);

                double sumOfSquares = Math.Pow(num1, 2) + Math.Pow(num2, 2);
                double squareOfSum = Math.Pow(num1 + num2, 2);

                if (sumOfSquares > squareOfSum)
                {
                    resultLabel.Content = "Сумма квадратов больше квадрата суммы.";
                }
                else if (sumOfSquares < squareOfSum)
                {
                    resultLabel.Content = "Квадрат суммы больше суммы квадратов.";
                }
                else
                {
                    resultLabel.Content = "Сумма квадратов равна квадрату суммы.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask2Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите зарплату:" });
            var salaryTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(salaryTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите стаж (в годах):" });
            var experienceTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(experienceTextBox);

            var bonusLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(bonusLabel);

            var totalSalaryLabel = new Label { Margin = new Thickness(0, 5, 0, 0) };
            TaskPanel.Children.Add(totalSalaryLabel);

            var button = new Button { Content = "Рассчитать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double salary = double.Parse(salaryTextBox.Text);
                int experience = int.Parse(experienceTextBox.Text);

                double bonus = 0;

                if (experience >= 2 && experience < 5)
                {
                    bonus = salary * 0.02;
                }
                else if (experience >= 5 && experience < 10)
                {
                    bonus = salary * 0.05;
                }

                double totalSalary = salary + bonus;

                bonusLabel.Content = $"Надбавка: {bonus:C}";
                totalSalaryLabel.Content = $"Сумма к выплате: {totalSalary:C}";
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask3Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A (x0, y0):" });
            var x0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x0TextBox);
            TaskPanel.Children.Add(y0TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки B (x1, y1):" });
            var x1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x1TextBox);
            TaskPanel.Children.Add(y1TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x0 = double.Parse(x0TextBox.Text);
                double y0 = double.Parse(y0TextBox.Text);
                double x1 = double.Parse(x1TextBox.Text);
                double y1 = double.Parse(y1TextBox.Text);

                double distanceA = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2));
                double distanceB = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

                if (distanceA > distanceB)
                {
                    resultLabel.Content = "Точка A наиболее удалена от начала координат.";
                }
                else if (distanceA < distanceB)
                {
                    resultLabel.Content = "Точка B наиболее удалена от начала координат.";
                }
                else
                {
                    resultLabel.Content = "Точки A и B находятся на одинаковом расстоянии от начала координат.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask4Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                    Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                    Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    resultLabel.Content = "Треугольник является прямоугольным.";
                }
                else
                {
                    resultLabel.Content = "Треугольник не является прямоугольным.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask5Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа:" });
            var num1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(num1TextBox);
            TaskPanel.Children.Add(num2TextBox);
            TaskPanel.Children.Add(num3TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Обработать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);
                double num3 = double.Parse(num3TextBox.Text);

                num1 = num1 > 0 ? Math.Pow(num1, 2) : num1;
                num2 = num2 > 0 ? Math.Pow(num2, 2) : num2;
                num3 = num3 > 0 ? Math.Pow(num3, 2) : num3;

                resultLabel.Content = $"Результаты: {num1}, {num2}, {num3}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask6Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить четверть", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (x > 0 && y > 0)
                {
                    resultLabel.Content = "Точка находится в первой четверти.";
                }
                else if (x < 0 && y > 0)
                {
                    resultLabel.Content = "Точка находится во второй четверти.";
                }
                else if (x < 0 && y < 0)
                {
                    resultLabel.Content = "Точка находится в третьей четверти.";
                }
                else if (x > 0 && y < 0)
                {
                    resultLabel.Content = "Точка находится в четвертой четверти.";
                }
                else
                {
                    resultLabel.Content = "Точка находится на оси.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask7Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите радиус окружности (R):" });
            var rTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(rTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);
                double R = double.Parse(rTextBox.Text);

                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if (distance <= R)
                {
                    resultLabel.Content = "Точка лежит внутри окружности.";
                }
                else
                {
                    resultLabel.Content = "Точка лежит вне окружности.";
                }
            };
            TaskPanel.Children.Add(button);
        }

        private void AddTask8Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны первого треугольника (a1, b1, c1):" });
            var a1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var b1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var c1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(a1TextBox);
            TaskPanel.Children.Add(b1TextBox);
            TaskPanel.Children.Add(c1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите стороны второго треугольника (a2, b2, c2):" });
            var a2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var b2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var c2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(a2TextBox);
            TaskPanel.Children.Add(b2TextBox);
            TaskPanel.Children.Add(c2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a1 = double.Parse(a1TextBox.Text);
                double b1 = double.Parse(b1TextBox.Text);
                double c1 = double.Parse(c1TextBox.Text);

                double a2 = double.Parse(a2TextBox.Text);
                double b2 = double.Parse(b2TextBox.Text);
                double c2 = double.Parse(c2TextBox.Text);

                double p1 = (a1 + b1 + c1) / 2;
                double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));

                double p2 = (a2 + b2 + c2) / 2;
                double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

                if (area1 > area2)
                {
                    resultLabel.Content = "Первый треугольник имеет большую площадь.";
                }
                else if (area1 < area2)
                {
                    resultLabel.Content = "Второй треугольник имеет большую площадь.";
                }
                else
                {
                    resultLabel.Content = "Треугольники имеют одинаковую площадь.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask9Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите сторону квадрата (a):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите радиус окружности (R):" });
            var rTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(rTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double R = double.Parse(rTextBox.Text);

                double squareArea = Math.Pow(a, 2);
                double circleArea = Math.PI * Math.Pow(R, 2);

                if (squareArea > circleArea)
                {
                    resultLabel.Content = "Площадь квадрата больше площади окружности.";
                }
                else if (squareArea < circleArea)
                {
                    resultLabel.Content = "Площадь окружности больше площади квадрата.";
                }
                else
                {
                    resultLabel.Content = "Площади равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask10Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа:" });
            var num1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num3TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(num1TextBox);
            TaskPanel.Children.Add(num2TextBox);
            TaskPanel.Children.Add(num3TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Обработать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);
                double num3 = double.Parse(num3TextBox.Text);

                num1 = num1 > 0 ? Math.Pow(num1, 3) : 0;
                num2 = num2 > 0 ? Math.Pow(num2, 3) : 0;
                num3 = num3 > 0 ? Math.Pow(num3, 3) : 0;

                resultLabel.Content = $"Результаты: {num1}, {num2}, {num3}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask11Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите натуральное число:" });
            var numberTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(numberTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int number = int.Parse(numberTextBox.Text);

                if (number % 2 == 0)
                {
                    resultLabel.Content = "Число четное.";
                }
                else if (number % 10 == 3)
                {
                    resultLabel.Content = "Число оканчивается на 3.";
                }
                else
                {
                    resultLabel.Content = "Число нечетное и не оканчивается на 3.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask12Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (x > 0 && y > 0)
                {
                    resultLabel.Content = "Точка лежит в первой четверти.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит в первой четверти.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask13Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите сумму вклада:" });
            var depositTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(depositTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите срок договора (6 или 12 месяцев):" });
            var termTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(termTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Рассчитать", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double depositAmount = double.Parse(depositTextBox.Text);
                int term = int.Parse(termTextBox.Text);

                double interestRate = term == 6 ? 0.06 : 0.08;
                double monthlyInterest = (depositAmount * interestRate) / 12;

                resultLabel.Content = $"Ежемесячные выплаты: {monthlyInterest:C}";
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask14Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите два числа:" });
            var num1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var num2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(num1TextBox);
            TaskPanel.Children.Add(num2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);

                double differenceOfSquares = Math.Pow(num1, 2) - Math.Pow(num2, 2);
                double squareOfDifference = Math.Pow(num1 - num2, 2);

                if (differenceOfSquares > Math.Abs(squareOfDifference))
                {
                    resultLabel.Content = "Разность квадратов больше модуля квадрата разности.";
                }
                else if (differenceOfSquares < Math.Abs(squareOfDifference))
                {
                    resultLabel.Content = "Модуль квадрата разности больше разности квадратов.";
                }
                else
                {
                    resultLabel.Content = "Разность квадратов равна модулю квадрата разности.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask15Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки A (x0, y0):" });
            var x0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y0TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x0TextBox);
            TaskPanel.Children.Add(y0TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки B (x1, y1):" });
            var x1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var y1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(x1TextBox);
            TaskPanel.Children.Add(y1TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x0 = double.Parse(x0TextBox.Text);
                double y0 = double.Parse(y0TextBox.Text);
                double x1 = double.Parse(x1TextBox.Text);
                double y1 = double.Parse(y1TextBox.Text);

                double distanceA = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2));
                double distanceB = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

                if (distanceA < distanceB)
                {
                    resultLabel.Content = "Точка A наименее удалена от начала координат.";
                }
                else if (distanceA > distanceB)
                {
                    resultLabel.Content = "Точка B наименее удалена от начала координат.";
                }
                else
                {
                    resultLabel.Content = "Точки A и B находятся на одинаковом расстоянии от начала координат.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask16Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите внутренний радиус тора (r):" });
            var rTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(rTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите внешний радиус тора (R):" });
            var RTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(RTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);
                double r = double.Parse(rTextBox.Text);
                double R = double.Parse(RTextBox.Text);

                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if (distance >= r && distance <= R)
                {
                    resultLabel.Content = "Точка лежит внутри тора.";
                }
                else
                {
                    resultLabel.Content = "Точка лежит вне тора.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask17Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите координаты точки (x, y):" });
            var xTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var yTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(xTextBox);
            TaskPanel.Children.Add(yTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double x = double.Parse(xTextBox.Text);
                double y = double.Parse(yTextBox.Text);

                if (x > 0 && y < 0)
                {
                    resultLabel.Content = "Точка лежит в четвертой четверти.";
                }
                else
                {
                    resultLabel.Content = "Точка не лежит в четвертой четверти.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask18Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите стороны треугольника (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (a == b || a == c || b == c)
                {
                    resultLabel.Content = "Треугольник является равнобедренным.";
                }
                else
                {
                    resultLabel.Content = "Треугольник не является равнобедренным.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask19Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите три числа (a, b, c):" });
            var aTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var bTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            var cTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(aTextBox);
            TaskPanel.Children.Add(bTextBox);
            TaskPanel.Children.Add(cTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = double.Parse(cTextBox.Text);

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                    Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                    Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    resultLabel.Content = "Числа являются тройкой Пифагора.";
                }
                else
                {
                    resultLabel.Content = "Числа не являются тройкой Пифагора.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask20Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите первую объемную скорость (л/с):" });
            var flowRate1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(flowRate1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите вторую объемную скорость (м³/мин):" });
            var flowRate2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(flowRate2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double flowRate1 = double.Parse(flowRate1TextBox.Text);
                double flowRate2 = double.Parse(flowRate2TextBox.Text);

                double flowRate2Converted = flowRate2 * 1000 / 60;

                if (flowRate1 > flowRate2Converted)
                {
                    resultLabel.Content = "Первая скорость больше.";
                }
                else if (flowRate1 < flowRate2Converted)
                {
                    resultLabel.Content = "Вторая скорость больше.";
                }
                else
                {
                    resultLabel.Content = "Скорости равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask21Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите площадь круга:" });
            var circleAreaTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(circleAreaTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите площадь квадрата:" });
            var squareAreaTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(squareAreaTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double circleArea = double.Parse(circleAreaTextBox.Text);
                double squareArea = double.Parse(squareAreaTextBox.Text);

                double circleRadius = Math.Sqrt(circleArea / Math.PI);
                double squareSide = Math.Sqrt(squareArea);

                if (2 * circleRadius <= squareSide)
                {
                    resultLabel.Content = "Круг уместится в квадрате.";
                }
                else
                {
                    resultLabel.Content = "Круг не уместится в квадрате.";
                }

                if (squareSide <= circleRadius * Math.Sqrt(2))
                {
                    resultLabel.Content += " Квадрат уместится в круге.";
                }
                else
                {
                    resultLabel.Content += " Квадрат не уместится в круге.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask22Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите массу первого тела (г):" });
            var mass1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(mass1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите объем первого тела (см³):" });
            var volume1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(volume1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите массу второго тела (г):" });
            var mass2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(mass2TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите объем второго тела (см³):" });
            var volume2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(volume2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double mass1 = double.Parse(mass1TextBox.Text);
                double volume1 = double.Parse(volume1TextBox.Text);
                double mass2 = double.Parse(mass2TextBox.Text);
                double volume2 = double.Parse(volume2TextBox.Text);

                double density1 = mass1 / volume1;
                double density2 = mass2 / volume2;

                if (density1 > density2)
                {
                    resultLabel.Content = "Первый материал имеет большую плотность.";
                }
                else if (density1 < density2)
                {
                    resultLabel.Content = "Второй материал имеет большую плотность.";
                }
                else
                {
                    resultLabel.Content = "Плотности материалов равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask23Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите первую скорость (км/ч):" });
            var speed1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(speed1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите вторую скорость (м/с):" });
            var speed2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(speed2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Сравнить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double speed1 = double.Parse(speed1TextBox.Text);
                double speed2 = double.Parse(speed2TextBox.Text);

                // Переводим км/ч в м/с (1 км/ч = 1000 м / 3600 с ≈ 0.2778 м/с)
                double speed1Converted = speed1 * 1000 / 3600;

                if (speed1Converted > speed2)
                {
                    resultLabel.Content = "Первая скорость больше.";
                }
                else if (speed1Converted < speed2)
                {
                    resultLabel.Content = "Вторая скорость больше.";
                }
                else
                {
                    resultLabel.Content = "Скорости равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask24Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите площадь равностороннего треугольника:" });
            var triangleAreaTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(triangleAreaTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите площадь круга:" });
            var circleAreaTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(circleAreaTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double triangleArea = double.Parse(triangleAreaTextBox.Text);
                double circleArea = double.Parse(circleAreaTextBox.Text);

                double side = Math.Sqrt((4 * triangleArea) / Math.Sqrt(3));
                double circleRadius = Math.Sqrt(circleArea / Math.PI);

                if (circleRadius <= side * Math.Sqrt(3) / 6)
                {
                    resultLabel.Content = "Круг уместится в треугольнике.";
                }
                else
                {
                    resultLabel.Content = "Круг не уместится в треугольнике.";
                }

                if (side <= circleRadius * 2 * Math.Sqrt(3))
                {
                    resultLabel.Content += " Треугольник уместится в круге.";
                }
                else
                {
                    resultLabel.Content += " Треугольник не уместится в круге.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask25Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите сопротивление первого участка (Ом):" });
            var resistance1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(resistance1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите напряжение первого участка (В):" });
            var voltage1TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(voltage1TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите сопротивление второго участка (Ом):" });
            var resistance2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(resistance2TextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите напряжение второго участка (В):" });
            var voltage2TextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(voltage2TextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double resistance1 = double.Parse(resistance1TextBox.Text);
                double voltage1 = double.Parse(voltage1TextBox.Text);
                double resistance2 = double.Parse(resistance2TextBox.Text);
                double voltage2 = double.Parse(voltage2TextBox.Text);

                double current1 = voltage1 / resistance1;
                double current2 = voltage2 / resistance2;

                if (current1 < current2)
                {
                    resultLabel.Content = "На первом участке ток меньше.";
                }
                else if (current1 > current2)
                {
                    resultLabel.Content = "На втором участке ток меньше.";
                }
                else
                {
                    resultLabel.Content = "Токи на участках равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask26Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите массу Венеры (г):" });
            var massVenusTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(massVenusTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите радиус Венеры (км):" });
            var radiusVenusTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(radiusVenusTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите массу Сатурна (г):" });
            var massSaturnTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(massSaturnTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите радиус Сатурна (км):" });
            var radiusSaturnTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(radiusSaturnTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double massVenus = double.Parse(massVenusTextBox.Text);
                double radiusVenus = double.Parse(radiusVenusTextBox.Text) * 1e5; // Переводим км в см
                double massSaturn = double.Parse(massSaturnTextBox.Text);
                double radiusSaturn = double.Parse(radiusSaturnTextBox.Text) * 1e5; // Переводим км в см

                double gVenus = (6.7e-8 * massVenus) / Math.Pow(radiusVenus, 2);
                double gSaturn = (6.7e-8 * massSaturn) / Math.Pow(radiusSaturn, 2);

                if (gVenus > gSaturn)
                {
                    resultLabel.Content = "Ускорение силы тяжести на Венере больше.";
                }
                else if (gVenus < gSaturn)
                {
                    resultLabel.Content = "Ускорение силы тяжести на Сатурне больше.";
                }
                else
                {
                    resultLabel.Content = "Ускорения силы тяжести равны.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask27Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите текущее время (часы, 0-23):" });
            var timeTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(timeTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int time = int.Parse(timeTextBox.Text);

                if (time >= 0 && time < 12)
                {
                    resultLabel.Content = "Время суток: AM.";
                }
                else if (time >= 12 && time < 24)
                {
                    resultLabel.Content = "Время суток: PM.";
                }
                else
                {
                    resultLabel.Content = "Некорректное время.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask28Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите географическую долготу (градусы):" });
            var longitudeTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(longitudeTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double longitude = double.Parse(longitudeTextBox.Text);

                if (longitude >= 0)
                {
                    resultLabel.Content = "Место находится в восточном полушарии.";
                }
                else
                {
                    resultLabel.Content = "Место находится в западном полушарии.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask29Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите расстояние до Сириуса (км):" });
            var siriusDistanceTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(siriusDistanceTextBox);

            TaskPanel.Children.Add(new Label { Content = "Введите расстояние до Арктура (парсеки):" });
            var arcturusDistanceTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(arcturusDistanceTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Определить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                double siriusDistance = double.Parse(siriusDistanceTextBox.Text);
                double arcturusDistance = double.Parse(arcturusDistanceTextBox.Text);

                // Переводим парсеки в километры (1 парсек ≈ 3.086e+13 км)
                double arcturusDistanceKm = arcturusDistance * 3.086e+13;

                if (siriusDistance > arcturusDistanceKm)
                {
                    resultLabel.Content = "Сириус находится дальше.";
                }
                else if (siriusDistance < arcturusDistanceKm)
                {
                    resultLabel.Content = "Арктур находится дальше.";
                }
                else
                {
                    resultLabel.Content = "Звезды находятся на одинаковом расстоянии.";
                }
            };
            TaskPanel.Children.Add(button);
        }
        private void AddTask30Controls()
        {
            TaskPanel.Children.Add(new Label { Content = "Введите натуральное число:" });
            var numberTextBox = new TextBox { Margin = new Thickness(0, 5, 0, 5) };
            TaskPanel.Children.Add(numberTextBox);

            var resultLabel = new Label { Margin = new Thickness(0, 10, 0, 0) };
            TaskPanel.Children.Add(resultLabel);

            var button = new Button { Content = "Проверить", Margin = new Thickness(0, 10, 0, 0) };
            button.Click += (s, e) =>
            {
                int number = int.Parse(numberTextBox.Text);

                if (number % 2 == 0)
                {
                    resultLabel.Content = "Число четное.";
                }
                else if (number % 10 == 7)
                {
                    resultLabel.Content = "Число оканчивается на 7.";
                }
                else
                {
                    resultLabel.Content = "Число нечетное и не оканчивается на 7.";
                }
            };
            TaskPanel.Children.Add(button);
        }
    }
}