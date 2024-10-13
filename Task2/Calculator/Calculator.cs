/// <summary>
/// Класс для выполнения операции сложения с логированием.
/// </summary>
public class Calculator : ICalculator
{
    private readonly ILogger _logger;

    /// <summary>
    /// Конструктор, принимающий логгер для логирования операций.
    /// </summary>
    /// <param name="logger">Экземпляр логгера.</param>
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Складывает два числа.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма чисел a и b.</returns>
    public int Add(int a, int b)
    {
        _logger.Event("Произведена операция сложения.");
        return a + b;
    }
}