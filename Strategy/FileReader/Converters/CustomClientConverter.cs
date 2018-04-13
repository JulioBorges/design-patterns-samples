using Strategy.FileReader.Contract;
using Strategy.Entities;
using System;

namespace Strategy.FileReader.Converters
{
    public class CustomClientConverter : AClientDataConverter
    {
        public override ClientData ConvertStringToClientData(string content)
        {
            Int32.TryParse(content.Substring(0, 5).Trim(), out int id);

            var name = content.Substring(5, 10).Trim();

            Int32.TryParse(content.Substring(15).Trim(), out int age);

            return new ClientData(id, name, Convert.ToInt32(age));
        }
    }
}
