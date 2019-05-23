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
        [Required]
        public string Name {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime CreatedAt {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime UpdatedAt {get;set;}
        [JsonIgnore]
        public List<CPU> CPUs {get;set;}
    }
}