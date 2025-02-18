// ANKINIMBOM YUWENYOH
// 02/16/2025

using System;
namespace VinFletchers;
public class Arrow
{
    private string Arrowhead { get; set; }
    private string Fletching { get; set; }
    private float ShaftLength { get; set; }

 
    public Arrow(string arrowhead, string fletching, float shaftLength)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        ShaftLength = shaftLength;
    }

    public float GetCost()
    {

        float arrowheadCost = 0;
        if (Arrowhead.ToLower() == "steel") 
                arrowheadCost = 10;
        else if (Arrowhead.ToLower() == "wood")
            arrowheadCost = 3;
        else if (Arrowhead.ToLower() == "obsidian")
            arrowheadCost = 5;


        float fletchingCost = 0;
        if (Fletching.ToLower() == "plastic")
            fletchingCost = 10;
        else if (Fletching.ToLower() == "turkeyfeathers")
            fletchingCost = 5;
        else if (Fletching.ToLower() == "goosefeathers")
            fletchingCost = 3;


        float shaftCost = 0.05f * ShaftLength;

        float totalCost = arrowheadCost + fletchingCost + shaftCost;
        return totalCost;
    }
}
