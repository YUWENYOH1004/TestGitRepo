using System;
namespace VinFletchers
{
	public class Properties
	{
        // Private fields with properties
        public string Arrowhead { get; private set; }
        public string Fletching { get; private set; }
        public float ShaftLength { get; private set; }

        // Constructor to initialize the arrow
        public Properties(string arrowhead, string fletching, float shaftLength)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            ShaftLength = shaftLength;
        }

        // Method to calculate the cost of the arrow
        public float GetCost()
        {
            // Determine the cost of the arrowhead
            float arrowheadCost = 0;
            if (Arrowhead.ToLower() == "steel") arrowheadCost = 10;
            else if (Arrowhead.ToLower() == "wood") arrowheadCost = 3;
            else if (Arrowhead.ToLower() == "obsidian") arrowheadCost = 5;

            // Determine the cost of the fletching
            float fletchingCost = 0;
            if (Fletching.ToLower() == "plastic") fletchingCost = 10;
            else if (Fletching.ToLower() == "turkeyfeathers") fletchingCost = 5;
            else if (Fletching.ToLower() == "goosefeathers") fletchingCost = 3;

            // Shaft cost is 0.05 gold per cm
            float shaftCost = 0.05f * ShaftLength;

            // Total cost calculation
            float totalCost = arrowheadCost + fletchingCost + shaftCost;
            return totalCost;
        }
    }
}


