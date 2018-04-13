using FluentInterfaces.Contract;
using System.Collections.Generic;

namespace FluentInterfaces.Documents.Contract
{
    public abstract class ADocument : IDocument
    {
        public string Header { get; private set; }
        public string Footer { get; private set; }
        public string Title { get; private set; }

        public List<string> DocumentLines { get; private set; }

        public ADocument()
        {
            DocumentLines = new List<string>();
        }

        public string ReadDocument()
        {
            var document = Title + "\r\n";
            document += Header + "\r\n";
            document += string.Join("\r\n", DocumentLines) + "\r\n";
            document += Footer;

            return document;
        }

        public IDocument SetTitle(string title)
        {
            Title = "TITLE: " + title;
            return this;
        }

        public IDocument SetHeader(string header)
        {
            Header = "HEADER: " + header;
            return this;
        }

        public IDocument AddLine(string line)
        {
            DocumentLines.Add("LINE: " + line);
            return this;
        }

        public IDocument SetFooter(string footer)
        {
            Footer = "FOOTER: " + footer;
            return this;
        }
    }
}
