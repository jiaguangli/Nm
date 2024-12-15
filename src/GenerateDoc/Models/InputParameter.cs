namespace GenerateDoc.Models;

public class InputParameter
{
    public InputType InputType { get; set; }


    public override string ToString()
    {
        return base.ToString();
    }

}

public enum InputType
{
    Body,
    Query,
    Route
}