namespace TmbAnalyst.ClientApp.Razor.Models;

public class Modal
{
    public Modal() : this(DefaultId)
    {}
    public Modal(string key)
    {
        Key = key;
    }
    public const string DefaultId = "rootModal";
    public string Title { get; set; }
    public string CloseText { get; set; } = "Close";
    public string SubmitText { get; set; } = "Submit";
    public Partial Content { get; set; }
    public string Key { get; init; } 
}