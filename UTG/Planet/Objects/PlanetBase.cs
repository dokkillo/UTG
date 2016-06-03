using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Planet.Objects
{
    public class PlanetBase
    {
        public PlanetBase()
        {

        }

        public PlanetBase(string _name, bool _canHandleLive, double _frecuency, bool _canHandleCities,
            double _minSize, double _maxSize, double _heliumProportion, double _hidrogenProportion, double _ironProportion,
            double _oxygenProportion,double _platiniumProportion, double _uraniumProportion, double _vanadiumProportion, PlanetType _planetType)
        {
            this.Name = _name;
            this.CanHandleLive = _canHandleLive;
            this.Frequency = _frecuency;
            this.CanHandleCities = _canHandleCities;
            this.MinSize = _minSize;
            this.MaxSize = _maxSize;
            this.HeliumProportion = _heliumProportion;
            this.HidrogenProportion = _hidrogenProportion;
            this.IronProportion = _ironProportion;
            this.OxygenProportion = _oxygenProportion;
            this.PlatiniumProportion = _platiniumProportion;
            this.VanadiumProportion = _vanadiumProportion;
            this.UraniumProportion = _uraniumProportion;
            this.Type = _planetType;
        }

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
