﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


[TrackClipType(typeof(LightControlAsset))]
[TrackBindingType(typeof(Light))]
public class LightControlTrack : ControlTrack{}
