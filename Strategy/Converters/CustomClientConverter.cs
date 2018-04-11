using Strategy.Contract;
using Strategy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Converters
{
    public class CustomClientConverter : AClientDataConverter
    {
        public override ClientData ConvertStringToClientData(string content)
        {
            return null;
        }
    }
}
