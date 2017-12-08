﻿using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace DataFlow.Web.Models
{
    public class DataMapper
    {
        public DataMapper()
        {
            SubDataMappers = new List<DataMapper>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DataMapperProperty DataMapperProperty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DataMapper> SubDataMappers { get; set; }
    }

    public class DataMapperProperty
    {
        [JsonProperty(PropertyName = "data-type")]
        public string DataType { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "source-column")]
        public string SourceColumn { get; set; }

        [JsonProperty(PropertyName = "source-table", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTable { get; set; }

        [JsonProperty(PropertyName = "default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }

        [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonIgnore]
        public string ChildType { get; set; }

        [JsonIgnore]
        public string ParentType { get; set; }
    }

    public class DataMapperEnums
    {
        public enum Sources
        {
            [Description("column")]
            Column,
            [Description("lookup_table")]
            LookupTable,
            [Description("static")]
            Static
        }

        public enum DataTypes
        {
            [Description("boolean")]
            Boolean,
            [Description("date")]
            Date,
            [Description("date-time")]
            DateTime,
            [Description("integer")]
            Integer,
            [Description("string")]
            String
        }
    }
}