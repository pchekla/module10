/// <summary>
/// Главная программа калькулятора.
/// </summary>
class Program
{
    static ILogger? Logger { get; set; }

    static void Main(string[] args)
    {
        // Инициализация логгера
        Logger = new Logger();

        // Создание калькулятора с внедрением логгера
        ICalculator calculator = new Calculator(Logger);

        int num1 = GetValidNumber("Введите первое число:");
        int num2 = GetValidNumber("Введите второе число:");

        // Вызов метода Add для расчета суммы
        int result = calculator.Add(num1, num2);

        // Логируем успешное завершение расчета
        Logger.Event($"Сумма {num1} и {num2} = {result}");

        Console.WriteLine("Программа завершила выполнение.");
    }

    /// <summary>
    /// Запрашивает ввод числа у пользователя и обрабатывает ошибки ввода.
    /// Если ввод некорректен, просит ввести число снова.
    /// </summary>
    /// <param name="prompt">Сообщение с подсказкой для ввода числа.</param>
    /// <returns>Целое число, введенное пользователем.</returns>
    /// 
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
                // Логируем ошибку
                Logger.Error($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Логируем общую ошибку
                Logger.Error($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}