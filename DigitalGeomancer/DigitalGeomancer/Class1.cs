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
                return GetFigureType();
            }
        }

        private FigureType GetFigureType()
        {
            if (Parts[FigurePart.Head])
            {
                if (Parts[FigurePart.Neck])
                {
                    if (Parts[FigurePart.Body])
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Via;
                        }
                        else
                        {
                            return FigureType.CaudaDraconis;
                        }
                    }
                    else
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Puer;
                        }
                        else
                        {
                            return FigureType.FortunaMinor;
                        }
                    }
                }
                else
                {
                    if (Parts[FigurePart.Body])
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Puella;
                        }
                        else
                        {
                            return FigureType.Amissio;
                        }
                    }
                    else
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Carcer;
                        }
                        else
                        {
                            return FigureType.Laetitia;
                        }
                    }
                }
            }
            else
            {
                if (Parts[FigurePart.Neck])
                {
                    if (Parts[FigurePart.Body])
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.CaputDraconis;
                        }
                        else
                        {
                            return FigureType.Conjunctio;
                        }
                    }
                    else
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Acquisitio;
                        }
                        else
                        {
                            return FigureType.Rubeus;
                        }
                    }
                }
                else
                {
                    if (Parts[FigurePart.Body])
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.FortunaMajor;
                        }
                        else
                        {
                            return FigureType.Albus;
                        }
                    }
                    else
                    {
                        if (Parts[FigurePart.Feet])
                        {
                            return FigureType.Tristitia;
                        }
                        else
                        {
                            return FigureType.Populus;
                        }
                    }
                }
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
