using System;

namespace HydroCore
{
    public class Crop
    {
        private string _name;
        private string _variety;
        private DateTime _plantedDate;
        private DateTime _sproutDate;
        private bool _isClone;
        private string _id;

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }

        public string Variety
        {
            get => this._variety;
            set => this._variety = value;
        }

        public DateTime PlantedDate
        {
            get => this._plantedDate;
            set => this._plantedDate = value;
        }

        public DateTime SproutDate
        {
            get => this._sproutDate;
            set => this._sproutDate = value;
        }

        public bool IsClone
        {
            get => this._isClone;
            set => this._isClone = value;
        }

        public string Id
        {
            get => this._id;
            set => this._id = value;
        }
    }
}