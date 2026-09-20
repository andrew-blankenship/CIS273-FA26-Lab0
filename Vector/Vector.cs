using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

namespace Vector;



public struct Vector
{

    public Vector(double x, double y)
    {
        X=x;
        Y=y;
    }

    public double Magnitude
    {
        get
        {
            return Math.Sqrt(X*X + Y*Y);
        }
    } 
    public double Direction => Math.Atan2(Y, X) * (180.0 / Math.PI);
    public double X { get; set; }
    public double Y { get; set; }

    

    // Methods

    //INSTANCE METHODS

    public Vector Add(Vector v)
    {
        Vector v3 = new Vector(this.X + v.X, this.Y + v.Y);
        return v3;
    }

    public Vector Subtract(Vector v)
    {
        Vector v3 = new Vector(this.X - v.X, this.Y - v.Y);
        return v3;
    }

    public double Dot(Vector v)
    {
        double result = X * v.X + Y * v.Y;
        return result;
    }

    public double AngleBetween(Vector v)
    {
       return Math.Abs(Direction - v.Direction);
    }

    public Vector Multiply(double scalar)
    {
        Vector result = new Vector(X * scalar, Y * scalar);
        return result;
    }

    public Vector Divide(double scalar)
    {
        Vector result = new Vector(X / scalar, Y / scalar);
        return result;
    }

    public Vector Normalize()
    {
        double scalar = this.Magnitude;
        return this.Divide(scalar);
    }

    // CLASS METHODS
    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

    public static Vector Multiply(Vector v1, double scalar)
    {
        return v1.Multiply(scalar);
    }

    public static Vector Divide(Vector v1, double scalar)
    {
        return v1.Divide(scalar);
    }
    public static Vector Normalize(Vector v1)
    {
        return v1.Normalize();
    }







    


    // OPERATORS
    
    public static Vector operator+(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

     public static Vector operator-(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

     public static double operator*(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

     public static Vector operator*(Vector v1, double scalar)
    {
        return v1.Multiply(scalar);
    }


    public static Vector operator/(Vector v1, double scalar)
    {
        return v1.Divide(scalar);
    }

    //ToString
    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }


}