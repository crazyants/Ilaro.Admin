﻿using System.Collections.Generic;
using System.Linq;
using Ilaro.Admin.Core;
using Ilaro.Admin.Core.Data;
using Ilaro.Admin.Filters;
using Ilaro.Admin.Tests.TestModels.Northwind;
using Xunit;

namespace Ilaro.Admin.Tests.Core.Data
{
    public class RecordsSource_BoolEntityFilters : SqlServerDatabaseTest
    {
        private readonly IFetchingRecords _source;
        private Entity _entity;
        private Property _property;

        public RecordsSource_BoolEntityFilters()
        {
            DB.Products.Insert(ProductName: "Product", Discontinued: true);
            DB.Products.Insert(ProductName: "Product2", Discontinued: false);

            _source = new RecordsSource(new Notificator());
            Admin.AddEntity<Product>();
            Admin.SetForeignKeysReferences();
            Admin.ConnectionStringName = ConnectionStringName;
            _entity = Admin.EntitiesTypes
                .FirstOrDefault(x => x.Name == "Product");
            _property = _entity["Discontinued"];
        }

        [Fact]
        public void empty_bool_filter_should_return_two_records()
        {
            var result = _source.GetRecords(_entity);
            Assert.Equal(2, result.Records.Count);

            var filters = new List<IEntityFilter>();
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(2, result.Records.Count);

            filters = new List<IEntityFilter>
            {
                new BoolEntityFilter()
            };
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(2, result.Records.Count);

            var filter = new BoolEntityFilter();
            filter.Initialize(_property);
            filters = new List<IEntityFilter>
            {
                filter
            };
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(2, result.Records.Count);
        }

        [Fact]
        public void true_bool_filter_should_return_one_records()
        {
            var filter = new BoolEntityFilter();
            filter.Initialize(_property, "1");
            var filters = new List<IEntityFilter>
            {
                filter
            };
            var result = _source.GetRecords(_entity, filters);
            Assert.Equal(1, result.Records.Count);
            Assert.Equal("Product", result.Records[0].Values[1].AsString);
        }

        [Fact]
        public void false_bool_filter_should_return_one_records()
        {
            var filter = new BoolEntityFilter();
            filter.Initialize(_property, "0");
            var filters = new List<IEntityFilter>
            {
                filter
            };
            var result = _source.GetRecords(_entity, filters);
            Assert.Equal(1, result.Records.Count);
            Assert.Equal("Product2", result.Records[0].Values[1].AsString);
        }
    }
}