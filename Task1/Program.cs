using System;

class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Программа запрашивает два числа у пользователя, обрабатывает исключения, и если ввод некорректен, просит ввести данные заново.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();

        int num1 = GetValidNumber("Введите первое число:");
        int num2 = GetValidNumber("Введите второе число:");

        // Вызов метода Add для расчета суммы
        int result = calculator.Add(num1, num2);

        // Вывод результата
        Console.WriteLine($"Сумма {num1} и {num2} = {result}");

        Console.WriteLine("Программа завершила выполнение.");
    }

    /// <summary>
    /// Запрашивает ввод числа у пользователя и обрабатывает ошибки ввода.
    /// Если ввод некорректен, просит ввести число снова.
    /// </summary>
    /// <param name="prompt">Сообщение с подсказкой для ввода числа.</param>
    /// <returns>Целое число, введенное пользователем.</returns>
    static int GetValidNumber(string prompt)
    {
        while (true)
        {
            try
            {
                // Ввод числа
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();

                // Попытка преобразования строки в число
                if (!int.TryParse(input, out int number))
                {
                    throw new FormatException("Некорректное значение. Пожалуйста, введите целое число.");
                }

                return number; // Возвращаем корректное число
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}"); // Вывод ошибки, если введено некорректное число
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}"); // Общий блок для отлавливания любых других ошибок
            }
        }
    }
}
