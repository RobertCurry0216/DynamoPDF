﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using Dyn = Autodesk.DesignScript.Geometry;

namespace DynamoPDF.Geometries
{
    /// <summary>
    /// Geometry Print Settings
    /// </summary>
    public class PrintSettings 
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public double Thickness;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DSCore.Color Stroke;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DSCore.Color Fill;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Create new Print Settings for PDF Geometry
        /// </summary>
        /// <param name="thickness"></param>
        /// <param name="stroke"></param>
        /// <param name="fill"></param>
        private PrintSettings(double thickness, DSCore.Color stroke = null, DSCore.Color fill = null)
        {
            this.Thickness = thickness;
            this.Fill = fill;
            this.Stroke = stroke;
        }

        /// <summary>
        /// Print Geometry with Stroke only
        /// </summary>
        /// <param name="thickness"></param>
        /// <param name="stroke"></param>
        /// <returns></returns>
        public static PrintSettings PrintStroke(double thickness, DSCore.Color stroke)
        {
            return new PrintSettings(thickness, stroke);
        }

        /// <summary>
        /// Print Geometry with Filling
        /// </summary>
        /// <param name="thickness"></param>
        /// <param name="fill"></param>
        /// <returns></returns>
        public static PrintSettings PrintFilling(double thickness, DSCore.Color fill)
        {
            return new PrintSettings(thickness, null, fill);
        }

        /// <summary>
        /// Print Geometry with Stroke and Filling
        /// </summary>
        /// <param name="thickness"></param>
        /// <param name="stroke"></param>
        /// <param name="fill"></param>
        /// <returns></returns>
        public static PrintSettings PrintStrokeAndFilling(double thickness, DSCore.Color stroke, DSCore.Color fill)
        {
            return new PrintSettings(thickness, stroke, fill);
        }

    }
}
