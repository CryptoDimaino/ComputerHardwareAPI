using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ComputerHardware.Models
{
	public class Manufacturer
    {
        [Key]
        [JsonIgnore]
        public int ManufacturerId {get;set;}
        public string Name {get;set;}
        public string URL {get;set;}
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CPU> CPUs {get;set;}
        public bool ShouldSerializeCPUs()
        {
            return CPUs.Count > 0;
        }
    }
}