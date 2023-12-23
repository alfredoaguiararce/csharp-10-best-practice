﻿using carvedrock.bl.principles.Solid.DependencyInversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class SalesReport
    {
        private IDatabase _database;

        public SalesReport(IDatabase database)
        {
            _database = database;
        }

        public void CreateReport(DateTime from, DateTime to)
        {
            // Create a very important report
        }

        public void SaveReport()
        {
            // Create a very important report
        }
    }
}
