﻿using MovieTutorial.Northwind.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace MovieTutorial.Northwind.Lookups
{
    [LookupScript]
    public class CustomerLookup : RowLookupScript<CustomerRow>
    {
        public CustomerLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = CustomerRow.Fields.CustomerID.PropertyName;
            TextField = CustomerRow.Fields.CompanyName.PropertyName;
        }
    }
}