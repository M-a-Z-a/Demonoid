using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxObject : Parallax
{

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        base.Start();
    }
    protected override void Update()
    {
        base.Update();
        transform.position = targetPosition;
    }
}
