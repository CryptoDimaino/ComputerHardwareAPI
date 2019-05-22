using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ComputerHardware.Models
{
	public class Socket
    {
        [Key]
        [JsonIgnore]
        public int SocketId {get;set;}
        public string Name {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;}
        [JsonIgnore]
        public DateTime UpdatedAt {get;set;}
        [JsonIgnore]
        public List<CPU> CPUs {get;set;}
    }
}