using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class MyVector2D 
{
    public float x;
    public float y;

    public MyVector2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return ("(" + x + ", " + y + ")");
    }


    //SUMA

    public static MyVector2D operator +(MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(a.x + b.x, a.y + b.y);
    }
    public MyVector2D add(MyVector2D vector)
    {
        MyVector2D result = new MyVector2D(x + vector.x, y + vector.y);
        return result;
    }


    //Resta

    public static MyVector2D operator -(MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(a.x - b.x, a.y - b.y);
    }
    public MyVector2D substract(MyVector2D vector)
    {
        MyVector2D result2 = new MyVector2D(x - vector.x, y - vector.y);
        return result2;
    }


    //Multiplicacion por Escalar

    public static MyVector2D operator *(MyVector2D a, float b)
    {
        return new MyVector2D(a.x * b, a.y * b);
    }
    public MyVector2D multiplyScalar(float scalar)
    {
        MyVector2D result3 = new MyVector2D(x * scalar, y * scalar);
        return result3;
    }


    //Magnitud

    public float magnitud()
    {
        float result4 = Mathf.Sqrt((x * x) + (y * y));
        return result4;
    }


    //Normalizar

    public MyVector2D normalizar()
    {

        MyVector2D result5 = new MyVector2D(x / Mathf.Sqrt((x * x) + (y * y)), y / Mathf.Sqrt((x * x) + (y * y)));
        return result5;
    }


    //Lerp

    public MyVector2D Lerp(MyVector2D other, float escalar)
    {
        MyVector2D result = new MyVector2D((x * (1 - escalar) + (other.x * escalar)), (y * (1 - escalar) + (other.y * escalar)));
        return result;
    }


    //Draw

    public void Draw(Vector2 origin, Color color)
    {
        if (origin == null)
        {
            Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y), color);
        }
        Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x + origin.x, y + origin.y), color);
    }

    
}
