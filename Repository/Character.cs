using System;
using System.Collections.Generic;

namespace Repository
{

    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public double? Zen { get; set; }
        public string Class { get; set; }

        public override string ToString()
        {
            return $"CharacterId : {CharacterId} \nName : {Name} \nLevel : {Level} \nGender : {Gender} \nZen : {Zen} \nClass : {Class}";
        }
    }
}
