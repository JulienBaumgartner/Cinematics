using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightControlBehaviour : PlayableBehaviour
{
    public Color color = Color.white;
    public float intensity = 1f;
    public bool auto = false;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Light light = playerData as Light;
        if (light != null)
        {
            if (auto)
            {
                light.color = Color.HSVToRGB(((float)(playable.GetTime())/5f)%1, 1f, 1f);
            }
            else
            {
                light.color = Color.Lerp(light.color, color, info.weight);
                light.intensity = Mathf.Lerp(light.intensity, intensity, info.weight);
            }
        }
    }
}
