namespace ComputerHardware.DTOs
{
    public class CPUDTO
    {
        public int CPUId {get;set;}
        public string Name {get;set;}
        public int CoreCount {get;set;}
        public int ThreadCount {get;set;}
        public double BaseFrequency {get;set;}        
        public double MaxFrequency {get;set;}
        public double L3Cache {get;set;}
        public int TDP {get;set;}
    }
}