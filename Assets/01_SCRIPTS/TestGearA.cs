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
        //print($"{nowCog}��° ��� �Ҵ� ����: {nowCogNumber}");

        base.Tick();
    }

    public override void Round()
    {
        //print("�� ����");
    }
}
