namespace Nm.SequentialGenerator;

/// <summary>
/// SequentialGenerator
/// </summary>;
public class SequentialGenerator
{
    private readonly string _sequence;
    public SequentialGenerator(string sequence)
    {
        _sequence = sequence;
    }

    public string GenerateNext(string currentValue, int length)
    {
        var value = SequenceToNumber(currentValue);
        return NumberToSequence(value + 1, length);
    }

    /// <summary>
    ///  sequence to int
    /// </summary>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int SequenceToNumber(string currentValue)
    {
        var number = 0;
        var realValueStr = currentValue.TrimStart(_sequence.First());
        foreach (var (realValue,index) in realValueStr.Select((value, index) => (value,index)))
        {
            var pow = realValueStr.Length - index -1;
            var powResult = (int)Math.Pow(_sequence.Length, pow);
            number += _sequence.IndexOf(realValue) * powResult;
        }
        return number;
    }

    /// <summary>
    /// int to sequence
    /// </summary>
    /// <param name="value"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public string NumberToSequence(int value,int length)
    {
        var pow = _sequence.Length;
        var sequenceArr = _sequence.ToCharArray();
        var result = "";
        while (value >= 1)
        {
            int index = Convert.ToInt16(value - (value / pow) * pow);
            result = sequenceArr[index] + result;
            value /= pow;
        }
        return result.PadLeft(length, sequenceArr.First());
    }
}