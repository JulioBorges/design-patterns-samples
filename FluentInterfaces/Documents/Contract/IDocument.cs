namespace FluentInterfaces.Contract
{
    public interface IDocument
    {
        IDocument SetTitle(string title);
        IDocument SetHeader(string header);
        IDocument AddLine(string line);
        IDocument SetFooter(string footer);
    }
}

