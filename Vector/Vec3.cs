namespace Vector;

public struct Vec3
{
    public float X;
    public float Y;
    public float Z;

    public Vec3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float Dot(Vec3 other) => X * other.X + Y * other.Y + Z * other.Z;

    public float Magnitude() => MathF.Sqrt(Dot(this));

    public float MagnitudeSQR() => Dot(this);

    public Vec3 Normalized()
    {
        float mag = Magnitude();
        if (mag == 0) return new Vec3(0, 0, 0);
        return new Vec3(X / mag, Y / mag, Z / mag);
    }

    public static Vec3 operator +(Vec3 a, Vec3 b) => new Vec3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vec3 operator -(Vec3 a, Vec3 b) => new Vec3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    public static Vec3 operator *(Vec3 a, float scalar) => new Vec3(a.X * scalar, a.Y * scalar, a.Z * scalar);
    public static Vec3 operator *(Vec3 a, Vec3 b) => new Vec3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    public static bool operator ==(Vec3 a, Vec3 b) => a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    public static bool operator !=(Vec3 a, Vec3 b) => !(a == b);
}
