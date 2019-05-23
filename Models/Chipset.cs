using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ComputerHardware.Models
{
	public class Chipset
    {
        [Key]
        [JsonIgnore]
        public int ChipsetId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string LaunchDate {get;set;}
        [Required]
        public string BusSpeed {get;set;}
        [Required]
        public string TDP {get;set;}
        [Required]
        public bool Overclock {get;set;}
        [Required]
        public string DIMMsPerChannel {get;set;}
        [Required]
        public string DisplaysSupported {get;set;}
        [Required]
        public string PCIExpressRevision {get;set;}
        [Required]
        public string MaxPCIExpressLanes {get;set;}
        [Required]
        public int NumberOfUSBPorts {get;set;}
        [Required]
        public string USBRevision {get;set;}
        [Required]
        public int MaxSata3Ports {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelOptaneMemorySupported {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelvProPlatformEligibility {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IntelMEFirmwareVersion {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelHDAudioTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelRapidStorageTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelRapidStorageTechnologyForPCIStorage {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelSmartSoundTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelPlatformTTTrustTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelBootGuard {get;set;}
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