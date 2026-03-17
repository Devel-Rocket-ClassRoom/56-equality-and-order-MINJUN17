using System;
using System.Collections.Generic;
using System.Text;

class Color:IEquatable<Color>
{
    public int R;
    public int G;
    public int B;
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public bool Equals(Color other)
    {
        if(other == null)
        {
            return false;
        }
        return R == other.R && G == other.G && B == other.B;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as Color);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(R, G, B);
    }
    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
    public bool IsSimilar(Color other, int threshold)
    {
        if(Math.Abs(other.R - R) < threshold && Math.Abs(other.G - G) < threshold && Math.Abs(other.B - B) < threshold)
        {
            return true;
        }
        return false;
    }
}
