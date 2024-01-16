using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public abstract class Gear : MonoBehaviour
{
    public int[] cogNumbers;
    public int cogs;
    public int nowCog = 1;
    public int nowCogNumber;

    private float nowAngle;
    private float tickAngle;

    protected virtual void Start()
    {
        cogs = cogNumbers.Length;
        nowCogNumber = cogNumbers[nowCog - 1];

        tickAngle = 360 / cogs;
        nowAngle = transform.rotation.z;
    }


    public virtual void Tick()
    {
        nowCog++;
        nowAngle += tickAngle;

        if(nowCog > cogs)
        {
            nowCog = 1;
            nowAngle = 0;
            Round();
        }

        transform.DORotate(new Vector3(0, 0, nowAngle), 0.5f);
        nowCogNumber = cogNumbers[nowCog - 1];

    }

    public abstract void Round();
}
