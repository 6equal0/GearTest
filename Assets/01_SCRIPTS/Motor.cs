using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Motor : MonoBehaviour
{
    [SerializeField] private Gear[] gears;
    [SerializeField] private Slider slider;

    private float speed = 1;

    private void Start()
    {
        StartCoroutine(Spin());
    }

    private void Update()
    {
        speed = 1 / slider.value * 5;
    }

    private IEnumerator Spin()
    {
        while (true)
        {
            print(speed);
            transform.Rotate(new Vector3(0, 0, 0.5f));
            yield return new WaitForSeconds(speed);

            if(transform.rotation.z >= 360)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                print("0");
            }
        }
    }
}
