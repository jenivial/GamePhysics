using System.Diagnostics;
using System.Numerics;

namespace Vector;

public struct Vec2
{
    public float X;
    public float Y;

    public Vec2(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float Dot(Vec2 other) => X * other.X + Y * other.Y;

    public float Magnitude() => MathF.Sqrt(Dot(this));

    public float MagnitudeSQR() => Dot(this);

    public Vec2 Normalized() 
    { 
        float mag = Magnitude();
        if (mag == 0) return new Vec2(0, 0);
        return new Vec2(X / mag, Y / mag);
    }

    public static Vec2 operator +(Vec2 a, Vec2 b) => new Vec2(a.X + b.X, a.Y + b.Y);
    public static Vec2 operator -(Vec2 a, Vec2 b) => new Vec2(a.X - b.X, a.Y - b.Y);
    public static Vec2 operator *(Vec2 a, float scalar) => new Vec2(a.X * scalar, a.Y * scalar);
    public static Vec2 operator *(Vec2 a, Vec2 b) => new Vec2(a.X * b.X, a.Y * b.Y);
    public static bool operator ==(Vec2 a, Vec2 b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Vec2 a, Vec2 b) => !(a == b);
}
