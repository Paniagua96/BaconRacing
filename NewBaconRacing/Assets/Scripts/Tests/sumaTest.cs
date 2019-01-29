using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class sumaTest
{

    [Test]
    public void SumaTestSimplePasses()
    {
        // Use the Assert class to test conditions.
        int resultado;
        resultado = suma(2, 3);

        Assert.AreEqual(5, resultado);

    }

    public int suma(int a, int b)
    {
        int suma1;

        suma1 = a + b;


        return suma1;
    }


}