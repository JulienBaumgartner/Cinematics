using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightControlAsset : PlayableAsset
{

    public Color color = Color.white;
    public float intensity = 1f;
    public bool auto = false;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<LightControlBehaviour>.Create(graph);

        var lightControlBehaviour = playable.GetBehaviour();
        lightControlBehaviour.color = color;
        lightControlBehaviour.intensity = intensity;
        lightControlBehaviour.auto = auto;

        return playable;
    }
}
