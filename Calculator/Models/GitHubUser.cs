﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class GitHubUser
    {
        public string Name { get; set; }
        public string Blog { get; set; }

        // This is deserialized using Json.NET, so use attributes as necessary
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
