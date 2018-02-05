using System.Collections.Generic;

namespace HydroCore
{
    public class GreenHouse
    {
        private string _id;
        private List<CropContainer> cropContains = null;

        public GreenHouse()
        {
            
        }
        
        public List<CropContainer> CropContains
        {
            get => cropContains;
            set => cropContains = value;
        }
    }
}