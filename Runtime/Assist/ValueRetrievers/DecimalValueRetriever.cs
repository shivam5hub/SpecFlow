﻿using System;

namespace TechTalk.SpecFlow.Assist.ValueRetrievers
{
    public class DecimalValueRetriever : IValueRetriever
    {
        public virtual decimal GetValue(string value)
        {
            var returnValue = 0M;
            Decimal.TryParse(value, out returnValue);
            return returnValue;
        }

        public object ExtractValueFromRow(TableRow row, Type targetType)
        {
            return GetValue(row[1]);
        }
    }
}