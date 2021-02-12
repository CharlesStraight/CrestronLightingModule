using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace SIMPLSharpProTemplate
{
    public class LightingZone
    {
        public string name { get; set; }
        public string crosspointSigName { get; set; }
        public ushort area { get; set; }
        public ushort scenes { get; set; }
        public ushort saveable { get; set; }
        public ushort associatedZoneIndex { get; set; }
        private ushort state = 0;

        //create class to parse data and create keypad, loads, and zone objects
        //May need to look into delegates to register events between each class
        //All classes will be linked between each other by the associatedZoneIndex
        //Need to think of how to handles scenes as well.

        public LightingZone()
        {
        }

        public void InitializeZone(string name, string crosspointSigName, ushort area, ushort saveable, ushort associatedZoneIndex)
        {
            this.name = name;
            this.crosspointSigName = crosspointSigName;
            this.area = area;
            this.saveable = saveable;
            this.associatedZoneIndex = associatedZoneIndex;
        }


    }
}