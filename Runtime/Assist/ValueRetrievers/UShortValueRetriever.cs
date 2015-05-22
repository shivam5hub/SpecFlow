﻿using System;

namespace TechTalk.SpecFlow.Assist.ValueRetrievers
{
    public class UShortValueRetriever : IValueRetriever
    {
        public virtual ushort GetValue(string value)
        {
            ushort returnValue;
            ushort.TryParse(value, out returnValue);
            return returnValue;
        }

        public object ExtractValueFromRow(TableRow row, Type targetType)
        {
            return GetValue(row[1]);
        }
    }
}