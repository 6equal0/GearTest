using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public abstract class Gear : MonoBehaviour
{
    public int[] cogNumbers;
    public int cogs;
    public int nowCog = 1;
    public int nowCogNumber;
    public GameObject cogImage;
    public bool isClockwise = true;

    public TextMeshProUGUI text;

    public float nowAngle;
    public float tickAngle;

    protected virtual void Start()
    {
        cogs = cogNumbers.Length;
        nowCogNumber = cogNumbers[nowCog - 1];

        tickAngle = 360 / cogs;
        nowAngle = transform.rotation.z;

        if (isClockwise) tickAngle *= -1;

        for(int i = 0; i< cogs; i++)
        {
            GameObject asdf = Instantiate(cogImage, transform.position, Quaternion.Euler(new Vector3(0, 0, i * tickAngle * -1)));
            asdf.transform.parent = this.transform;

            if(cogNumbers[i] == 1)
            {
                asdf.GetComponent<SpriteRenderer>().color = Color.red;
            }
            else if(cogNumbers[i] == 2)
            {
                asdf.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }

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

        if (nowCogNumber == 1) Skill();
        if (nowCogNumber == 2) CollaborateSkill();
    }

    public abstract void Skill();

    public abstract void CollaborateSkill();

    public abstract void Round();
}
