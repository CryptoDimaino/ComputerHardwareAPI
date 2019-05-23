using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ComputerHardware.Models
{
	public class CPUDetail
    {
        [ForeignKey("CPU")]
        [JsonIgnore]
        public int CPUDetailId {get;set;}
        [Required]
        public string TJunction {get;set;}
        [Required]
        public int MaxCPUs {get;set;}
        [Required]
        public string PackageSizeX {get;set;}
        [Required]
        public string PackageSizeY {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelOptaneMemorySupported {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelTurboBoostTechnology2 {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelTurboBoostTechnology1 {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelvProPlatformEligibility {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelHyperThreadingTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelVirtualizationTechnologyforDirectIO {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? VTxWithExtendedPageTables {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelTSXNI {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intel64 {get;set;}
        public string InstructionSet {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IdleStates {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhancedIntelSpeedStepTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThermalMonitoringTechnologies {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelIdentityProtectionTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? StableImagePlatformProgram {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelAESNewInstructions {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureKey {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelSoftwareGuardExtentions {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelMemoryProtectionExtensions {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelOSGuard {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelTrustedExecutionTechnology {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteDisableBit {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntelBootGuard {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime CreatedAt {get;set;}
        [JsonIgnore]
        [Required]
        public DateTime UpdatedAt {get;set;}


        public virtual CPU CPU {get;set;}
    }
}