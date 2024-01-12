using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gear : MonoBehaviour
{
    public int[] cogNumbers;
    public int cogs;
    public int nowCog = 1;
    public int nowCogNumber;

    [SerializeField] private GameObject cogImage;

    private float tickAngle;

    protected virtual void Start()
    {
        cogs = cogNumbers.Length;
        nowCogNumber = cogNumbers[nowCog - 1];

        tickAngle = 360 / cogs;

        for(int i = 0; i < cogs; i++)
        {
            GameObject asdf = Instantiate(cogImage, transform.position, Quaternion.identity);
            asdf.transform.parent = transform;
            asdf.transform.rotation = Quaternion.Euler(new Vector3(0, 0, tickAngle * i));

            if(cogNumbers[i] != 0)
            {
                asdf.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
        }
    }

    public virtual void Tick()
    {
        nowCog++;

        if(nowCog > cogs)
        {
            nowCog = 1;
            Round();
        }

        nowCogNumber = cogNumbers[nowCog - 1];

    }

    public abstract void Round();
}
