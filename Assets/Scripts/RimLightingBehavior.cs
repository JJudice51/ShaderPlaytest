using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Renderer _renderer;

    [SerializeField, Range(0.01f, 10.0f)]
    private float _speed = 1;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_renderer == null || _renderer.material == null)
            return;

        float value = (Mathf.Sin(Time.time * _speed) + 1) / 2;
        _renderer.material.SetFloat("_RimPower", value * 9 + 1);
        _renderer.material.SetFloat("_RimIntensity", value * 10);
       
    }
}
