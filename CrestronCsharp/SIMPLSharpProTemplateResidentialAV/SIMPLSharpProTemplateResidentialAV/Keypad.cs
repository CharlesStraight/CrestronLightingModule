using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace SIMPLSharpProTemplate
{
    public class Keypad
    {
        public string crosspointSigName { get; set; }
        public ushort area { get; set; }
        public ushort associatedZoneIndex { get; set; }
        public ushort numberOfButtons { get; set; }
        public ushort[] buttonState;

        public Keypad()
        {
        }

        public void InitializeKeypad(string crosspointSigName, ushort area, ushort associatedZoneIndex, ushort numberOfButtons, ushort[] buttonState)
        {
            this.crosspointSigName = crosspointSigName;
            this.area = area;
            this.associatedZoneIndex = associatedZoneIndex;
            this.numberOfButtons = numberOfButtons;
            this.buttonState = new ushort[numberOfButtons];
        }
    }
}