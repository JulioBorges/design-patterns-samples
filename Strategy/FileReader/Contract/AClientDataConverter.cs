using Strategy.Entities;

namespace Strategy.FileReader.Contract
{
    public abstract class AClientDataConverter
    {
        public abstract ClientData ConvertStringToClientData(string content);
    }
}
