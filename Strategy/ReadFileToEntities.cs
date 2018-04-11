using Strategy.Contract;
using Strategy.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class ReadFileToEntities
    {
        AClientDataConverter _converter;

        public ReadFileToEntities(AClientDataConverter converter)
        {
            _converter = converter;
        }

        public List<ClientData> ReadFile(List<string> fileContentInLines)
        {
            return fileContentInLines
                .Select(linha => _converter.ConvertStringToClientData(linha))
                .ToList();
        }
    }
}
