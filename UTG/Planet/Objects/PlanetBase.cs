using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Planet.Objects
{
    public class PlanetBase
    {
        public string Name {get;set;}

        public bool CanHandleLive  {get;set;}       

        public double Frequency  {get;set;}   

        public bool CanHandleCities  {get;set;}
   
        public double MinSize  {get;set;}      

        public double MaxSize  {get;set;}
      
        public double HeliumProportion  {get;set;}
    
        public double HidrogenProportion  {get;set;}
    
        public double IronProportion  {get;set;}
  
        public double OxygenProportion  {get;set;}
   
        public double PlatiniumProportion  {get;set;}
  
        public double VanadiumProportion  {get;set;}

        public double UraniumProportion  {get;set;}

        public PlanetType Type {get;set;}
    }
}
