using System;
namespace Develop02
{


    public class Entries
{
    public DateTime _Date { get; set; }
    public string _PromptText { get; set; }
    public string _Response { get; set; }

    public Entries(DateTime date)
    {
        _Date = date;
    }

    // New constructor added to handle three arguments
    public Entries(DateTime date, string promptText, string response)
    {
        _Date = date;
        _PromptText = promptText;
        _Response = response;
    }
}
}