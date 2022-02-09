using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    Vector2 origin = new Vector2(0, 0);
   
    [SerializeField] MyVector2D first = new MyVector2D(1, 3);
    [SerializeField] MyVector2D second = new MyVector2D(2, -1);
    [SerializeField] [Range(0, 1)] float escalar = 1;

    MyVector2D suma;
    MyVector2D resta;
    MyVector2D multEscalar;
    MyVector2D normalizar;
    float magnitud;


    void Update()
    {
        first.Draw(origin, Color.white);
        second.Draw(origin, Color.white);

        suma = first.add(second);
        var vectorSum = first + second;

        resta = first.substract(second);
        var vectorSubs = first - second;

        multEscalar = first.multiplyScalar(2);
        var vectorMult = first * escalar; 

        magnitud = first.magnitud();
        normalizar = first.normalizar();

        Debug.Log("magnitud = " + magnitud);
        Debug.Log("normalizado = " + normalizar);


        //suma.Draw(origin, Color.grey); 
        //suma.Draw(new Vector2 (firstVector.x, firstVector.y), Color.black);

        //resta.Draw(origin, Color.blue);
        //resta.Draw(new Vector2(second.x, second.y), Color.cyan);

        //multEscalar.Draw(origin, Color.green);

        var sliderResta = resta * escalar;
        sliderResta.Draw(new Vector2(second.x, second.y), Color.cyan);

        var sliderLerp = first.Lerp(second, escalar);
        sliderLerp.Draw(new Vector2(origin.x, origin.y), Color.blue);

        
    }
}
