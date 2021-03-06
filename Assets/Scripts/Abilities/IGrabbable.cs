﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGrabbable
{
    void Grab();
    void Release();
    (Grabbable.GrabEffect, float) GetGrabEffect();

}
