/// <summary>
/// Класс для выполнения операции сложения.
/// </summary>
public class Calculator : ICalculator
{

    /// <summary>
    /// Складывает два числа.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма чисел a и b.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
}