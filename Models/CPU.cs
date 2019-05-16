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
        public string Name {get;set;}
        public int CoreCount {get;set;}
        public int ThreadCount {get;set;}
        public double BaseFrequency {get;set;}
        public double MaxFrequency {get;set;}
        public double L3Cache {get;set;}
        public int TDP {get;set;}
        public string Series {get;set;}
        public string Family {get;set;}
        public string Type {get;set;}
        public bool ECC {get;set;}
        public bool SMT {get;set;}
        public string Lithography {get;set;}
        public string MaxMemory {get;set;}
        public string MaxMemoryChannel {get;set;}
        public string IntegratedGraphics {get;set;}
        public string MaxGPUClockRate {get;set;}
        public double MSRPPrice {get;set;}
        public double PCIExpressLanes {get;set;}
        public string ReleaseDate {get;set;}

        [JsonIgnore]
        public int SocketId {get;set;}
        public Socket Socket {get;set;}

        [JsonIgnore]
        public int ManufacturerId {get;set;}
        public Manufacturer Manufacturer {get;set;}
        public virtual CPUDetail CPUDetail {get;set;}
        [JsonIgnore]
        public int ChipsetId {get;set;}
        public Chipset Chipset {get;set;}
    }
}