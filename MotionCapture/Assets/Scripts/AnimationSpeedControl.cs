﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedControl : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _animator.SetTrigger("Regular");
        if (Input.GetKeyDown(KeyCode.Alpha2))
            _animator.SetTrigger("Fast");
        if (Input.GetKeyDown(KeyCode.Alpha3))
            _animator.SetTrigger("Slow");
    }
}
