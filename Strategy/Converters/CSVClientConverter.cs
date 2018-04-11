﻿using Strategy.Contract;
using Strategy.Entities;
using System;

namespace Strategy.Converters
{
    public class CSVClientConverter : AClientDataConverter
    {

        public override ClientData ConvertStringToClientData(string content)
        {
            var data = content.Split(';');

            return new ClientData(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[3]));
        }
    }
}
