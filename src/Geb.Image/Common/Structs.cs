﻿/*************************************************************************
 *  Copyright (c) 2010 Hu Fei(xiaotie@geblab.com; geblab, www.geblab.com)
 ************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Geb.Image
{
    /// <summary>
    /// 点。横纵坐标都是UInt16格式。
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct PointS
    {
        [FieldOffset(0)]
        public UInt16 X;
        [FieldOffset(2)]
        public UInt16 Y;

        public PointS(UInt16 x, UInt16 y)
        {
            X = x; Y = y;
        }

        public PointS(Int32 x, Int32 y)
        {
            X = (UInt16)x; Y = (UInt16)y;
        }

        public PointS(Int64 x, Int64 y)
        {
            X = (UInt16)x; Y = (UInt16)y;
        } 
    }

    public struct Size<T> where T : struct
    {
        public T Width;
        public T Height;

        public Size(T width, T height)
        {
            Width = width;
            Height = height;
        }
    }

    public struct Rect
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Width;
        public Int32 Height;

        public Rect(Int32 x = 0, Int32 y = 0, Int32 w = 0, Int32 h = 0)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }
    }

    public struct RectS
    {
        public Int16 X;
        public Int16 Y;
        public Int16 Width;
        public Int16 Height;

        public RectS(Int16 x = 0, Int16 y = 0, Int16 w = 0, Int16 h = 0)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }
    }

    public struct RectD
    {
        public double X;
        public double Y;
        public double Width;
        public double Height;

        public RectD(double x = 0, double y = 0, double w = 0, double h = 0)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }

        public RectF ToRectF()
        {
            return new RectF((float)X, (float)Y, (float)Width, (float)Height);
        }
    }

    public struct RectF
    {
        public float X;
        public float Y;
        public float Width;
        public float Height;

        public RectF(float x = 0, float y = 0, float w = 0, float h = 0)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }

        public RectD ToRectD()
        {
            return new RectD(X, Y, Width, Height);
        }
    }

    /// <summary>
    /// Region of Interest (ROI)
    /// </summary>
    public struct ROI
    {
        public UInt16 X { get; private set; }
        public UInt16 Y { get; private set; }
        public UInt16 Width { get; private set; }
        public UInt16 Height { get; private set; }
    }

    /// <summary>
    /// 极坐标点
    /// </summary>
    public struct PolarPointD
    {
        /// <summary>
        /// 半径
        /// </summary>
        public double Radius;

        /// <summary>
        /// 角度
        /// </summary>
        public double Angle;

        public PolarPointD(double radius, double angle)
        {
            Radius = radius;
            Angle = angle;
        }
    }
}
