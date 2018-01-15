using System;
using System.Collections.Generic;

namespace HydroCore
{
    public abstract class CropContainer
    {
        private string _id;
        // TODO create that object
        // private object dimensions;
        private int _cropCount;
        private bool _inService;
        private List<Crop> _crops = new List<Crop>();
        private DateTime _lastFeeding;
        private DateTime _nextFeeding;

        public string Id
        {
            get => this._id;
            set => this._id = value;
        }

        public int CropCount
        {
            get => this._cropCount;
            set => this._cropCount = value;
        }

        public bool InService
        {
            get => this._inService;
            set => this._inService = value;
        }
        
        public DateTime LastFeeding
        {
            get => _lastFeeding;
            set => _lastFeeding = value;
        }
        
        public DateTime NextFeeding
        {
            get => _nextFeeding;
            set => _nextFeeding = value;
        }
    }
}