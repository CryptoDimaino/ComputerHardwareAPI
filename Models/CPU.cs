using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ComputerHardware.Models
{
	public class CPU
    {
        [Key]
        [JsonIgnore]
        public int CPUId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public int CoreCount {get;set;}
        [Required]
        public int ThreadCount {get;set;}
        [Required]
        public double BaseFrequency {get;set;}
        [Required]
        public double MaxFrequency {get;set;}
        [Required]
        public double L3Cache {get;set;}
        [Required]
        public int TDP {get;set;}
        [Required]
        public string Series {get;set;}
        [Required]
        public string Family {get;set;}
        [Required]
        public string Type {get;set;}
        [Required]
        public bool ECC {get;set;}
        [Required]
        public bool SMT {get;set;}
        [Required]
        public string Lithography {get;set;}
        [Required]
        public string MaxMemory {get;set;}
        [Required]
        public string MaxMemoryChannel {get;set;}
        public string IntegratedGraphics {get;set;}
        public string MaxGPUClockRate {get;set;}
        [Required]
        public double MSRPPrice {get;set;}
        [Required]
        public double PCIExpressLanes {get;set;}
        [Required]
        public string ReleaseDate {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime CreatedAt {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime UpdatedAt {get;set;}

        [JsonIgnore]
        public int SocketId {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Socket Socket {get;set;}

        [JsonIgnore]
        public int ManufacturerId {get;set;}
        public Manufacturer Manufacturer {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual CPUDetail CPUDetail {get;set;}
        [JsonIgnore]
        public int ChipsetId {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Chipset Chipset {get;set;}
    }
}