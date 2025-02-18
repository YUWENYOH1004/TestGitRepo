using System;
namespace VinFletchers
{
	public class VinsTrouble
	{
        private string Arrowhead { get; set; }
        private string Fletching { get; set; }
        private float ShaftLength { get; set; }

        // Constructor to initialize the arrow
        public VinsTrouble(string arrowhead, string fletching, float shaftLength)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            ShaftLength = shaftLength;
        }

        // Getter method for Arrowhead
        public string GetArrowhead()
        {
            return Arrowhead;
        }

        // Getter method for Fletching
        public string GetFletching()
        {
            return Fletching;
        }

        // Getter method for ShaftLength
        public float GetShaftLength()
        {
            return ShaftLength;
        }

        // Method to calculate the cost of the arrow
        public float GetCost()
        {
            // Determine the cost of the arrowhead
            float arrowheadCost = 0;
            if (GetArrowhead().ToLower() == "steel") arrowheadCost = 10;
            else if (GetArrowhead().ToLower() == "wood") arrowheadCost = 3;
            else if (GetArrowhead().ToLower() == "obsidian") arrowheadCost = 5;

            // Determine the cost of the fletching
            float fletchingCost = 0;
            if (GetFletching().ToLower() == "plastic") fletchingCost = 10;
            else if (GetFletching().ToLower() == "turkeyfeathers") fletchingCost = 5;
            else if (GetFletching().ToLower() == "goosefeathers") fletchingCost = 3;

            // Shaft cost is 0.05 gold per cm
            float shaftCost = 0.05f * GetShaftLength();

            // Total cost calculation
            float totalCost = arrowheadCost + fletchingCost + shaftCost;
            return totalCost;
        }
    }
}

