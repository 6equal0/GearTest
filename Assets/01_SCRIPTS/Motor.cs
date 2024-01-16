using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Motor : MonoBehaviour
{
    [SerializeField] private Gear[] gears;
    [SerializeField] private float speed = 2;

    private float curTime = 0;

    private void FixedUpdate()
    {
        curTime += Time.deltaTime;
        if (curTime >= speed)
        {
            curTime = 0;

            foreach(Gear item in gears)
            {
                item.Tick();
            }
        }
    }
}
