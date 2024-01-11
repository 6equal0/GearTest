using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gear : MonoBehaviour
{
    public int[] cogNumbers;
    public int cogs;
    public int nowCog = 1;
    public int nowCogNumber;

    private float tickAngle;

    protected virtual void Start()
    {
        cogs = cogNumbers.Length;
        nowCogNumber = cogNumbers[nowCog - 1];

        tickAngle = 360 / cogs;
    }

    public virtual void Tick()
    {
        nowCog++;
        transform.Rotate(new Vector3(0,0,tickAngle));

        if(nowCog > cogs)
        {
            nowCog = 1;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            Round();
        }

        nowCogNumber = cogNumbers[nowCog - 1];

    }

    public abstract void Round();
}
