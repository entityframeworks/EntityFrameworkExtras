﻿using System.Collections.Generic;
using System.Data;

namespace EntityFrameworkExtras.EF6.Tests.Integration.StoredProcedures
{
    [StoredProcedure("UserDefinedTableStoredProcedure")]
    public class UserDefinedTableInvalidColumnCountStoredProcedure
    {
        [StoredProcedureParameter(SqlDbType.Udt)]
        public List<InvalidColumnCountUserDefinedTable> UserDefinedTableParameter { get; set; } 
    }
}