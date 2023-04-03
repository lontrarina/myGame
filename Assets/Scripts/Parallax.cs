using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float _length, _startposition;
    public GameObject CameraForParallax;
    public float ParallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        _startposition = transform.position.x;
        _length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        //float temp = (CameraForParallax.transform.position.x* (1-ParallaxEffect));
        float dist = (CameraForParallax.transform.position.x * ParallaxEffect);

        transform.position= new Vector3(_startposition + dist, transform.position.y, transform.position.z);

       // if (temp > _startposition + _length) _startposition += _length;
       // else if (temp< _startposition - _length) _startposition -= _length; 

    }
}
