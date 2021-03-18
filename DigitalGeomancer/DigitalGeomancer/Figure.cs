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

        /// <summary>
        /// Constructs a Figure by specifying their parts.
        /// </summary>
        public Figure(bool head, bool neck, bool body, bool feet)
        {
            Parts[FigurePart.Head] = head;
            Parts[FigurePart.Neck] = neck;
            Parts[FigurePart.Body] = body;
            Parts[FigurePart.Feet] = feet;
        }

        /// <summary>
        /// Constructs a Figure by combining two.
        /// </summary>
        public Figure(Figure figure1, Figure figure2)
        {
            Parts[FigurePart.Head] = !(figure1.Parts[FigurePart.Head] == figure2.Parts[FigurePart.Head]);
            Parts[FigurePart.Neck] = !(figure1.Parts[FigurePart.Neck] == figure2.Parts[FigurePart.Neck]);
            Parts[FigurePart.Body] = !(figure1.Parts[FigurePart.Body] == figure2.Parts[FigurePart.Body]);
            Parts[FigurePart.Feet] = !(figure1.Parts[FigurePart.Feet] == figure2.Parts[FigurePart.Feet]);
        }

        /// <summary>
        /// Constructs a Figure by using a specific Part of four figures. 
        /// </summary>
        public Figure(Figure figure1, Figure figure2, Figure figure3, Figure figure4, FigurePart part)
        {
            Parts[FigurePart.Head] = figure1.Parts[part];
            Parts[FigurePart.Neck] = figure2.Parts[part];
            Parts[FigurePart.Body] = figure3.Parts[part];
            Parts[FigurePart.Feet] = figure4.Parts[part];
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

    /// <summary>
    /// The four parts of a geomantic Figure.
    /// </summary>
    public enum FigurePart
    {
        Head,
        Neck,
        Body,
        Feet
    }

    /// <summary>
    /// The sixteen geomantic Figures.
    /// </summary>
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
