using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Motor : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Gear[] gears;
    [SerializeField] private float speed = 1;

    private float _nextTick;
    private float _nowTick = 0;

    private void Update()
    {
        _nextTick = 1 / _slider.value;
    }

    private void FixedUpdate()
    {
        _nowTick += Time.deltaTime * speed;
        if(_nowTick >= _nextTick && _nextTick != 0)
        {
            _nowTick = 0;

            foreach(var item in gears)
            {
                item.GetComponent<Gear>().Tick();
            }
        }
    }
}
