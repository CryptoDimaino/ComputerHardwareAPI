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
        [Required]
        public string Name {get;set;}
        [Required]
        public string URL {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime CreatedAt {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime UpdatedAt {get;set;}
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CPU> CPUs {get;set;}
        // public bool ShouldSerializeCPUs()
        // {
        //     return CPUs.Count > 0;
        // }
    }
}