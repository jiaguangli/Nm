namespace GenerateDoc.Models;

public class Document
{
    public string Url { get; set; } = string.Empty;

    public Title? Title { get; set; }

    public ICollection<InputParameter>? InputParameter { get; set; } = [];

    public OutputParameter? OutputParameter { get; set; }

    public CSharpClass? CSharpClass { get; set; }

    public TypeScriptInterface? TypeScriptInterface { get; set; }
}