using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGearA : Gear
{
    protected override void Start()
    {
        base.Start();
    }

    public override void Tick()
    {
        //print($"{nowCog}번째 톱니 할당 숫자: {nowCogNumber}");

        base.Tick();
    }

    public override void Round()
    {
        //print("한 바퀴");
    }
}
