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
        public string Name {get;set;}
        public string LaunchDate {get;set;}
        public string BusSpeed {get;set;}
        public string TDP {get;set;}
        public bool Overclock {get;set;}
        public string DIMMsPerChannel {get;set;}
        public string DisplaysSupported {get;set;}
        public string PCIExpressRevision {get;set;}
        public string MaxPCIExpressLanes {get;set;}
        public int NumberOfUSBPorts {get;set;}
        public string USBRevision {get;set;}
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
        public List<CPU> CPUs {get;set;}
    }
}