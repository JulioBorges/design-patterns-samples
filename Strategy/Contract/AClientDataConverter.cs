
using Strategy.Entities;

namespace Strategy.Contract
{
    public abstract class AClientDataConverter
    {
        public abstract ClientData ConvertStringToClientData(string content);
    }
}
