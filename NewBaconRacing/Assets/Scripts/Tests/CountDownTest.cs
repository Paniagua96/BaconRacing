using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CountDownTest {

    [Test]
    public void CountDownTestSimplePasses() {
        // Use the Assert class to test conditions.
        float initialCounter;
        float minus;
        bool activateMovement;
        bool result;

        initialCounter = 5;
        minus = 5;
        activateMovement = false;

        result=ActivateMovement(initialCounter,minus, activateMovement);

        Assert.True(result);

    }

    public bool ActivateMovement(float initialCounter,float minus, bool activateMovement)
    {
        

        initialCounter -= minus;
        if (initialCounter <= 0)
        {
            activateMovement = true;
            initialCounter = 0;
        }

        return activateMovement;
    }


}
