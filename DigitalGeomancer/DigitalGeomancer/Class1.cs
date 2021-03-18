using System;
using System.Collections.Generic;

namespace DigitalGeomancer
{
    public class Figure
    {
        public Dictionary<FigurePart, bool> Parts { get; set; } = new Dictionary<FigurePart, bool>()
        {
            {FigurePart.Head, false },
            {FigurePart.Neck, false },
            {FigurePart.Body, false },
            {FigurePart.Feet, false }
        };

        public FigureType Type 
        { 
            get 
            {
                //if (Parts[FigurePart.Head])
                //{

                //}
                return FigureType.Via;
            } 
        }
    }

    public enum FigurePart
    {
        Head,
        Neck,
        Body,
        Feet
    }
     public enum FigureType
    {
        Puer,
        Amissio,
        Albus,
        Populus,
        FortunaMajor,
        Conjunctio,
        Puella,
        Rubeus,
        Acquisitio,
        Carcer,
        Tristitia,
        Laetitia,
        CaudaDraconis,
        CaputDraconis,
        FortunaMinor,
        Via
    }
}
