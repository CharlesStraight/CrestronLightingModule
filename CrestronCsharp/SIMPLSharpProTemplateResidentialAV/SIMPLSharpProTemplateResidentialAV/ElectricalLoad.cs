using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace SIMPLSharpProTemplate
{
    public class ElectricalLoad
    {
        public string crosspointSigName { get; set; }
        public ushort area { get; set; }
        public ushort associatedZoneIndex { get; set; }
        public ushort loadState { get; set; }
        public ushort isDimmable { get; set; }
        public ushort currentLevel { get; set; }

        public ElectricalLoad()
        {
        }

        public void InitializeLoad(string crosspointSigName, ushort area, ushort associatedZoneIndex, ushort isDimmable)
        {
            this.crosspointSigName = crosspointSigName;
            this.area = area;
            this.associatedZoneIndex = associatedZoneIndex;
            this.isDimmable = isDimmable;
        }
         
    }
}