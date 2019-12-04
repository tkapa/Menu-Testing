using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class GameButton : MonoBehaviour
{
    Animation anim = null;

    // Start is called before the first frame update
    void Start()
    {
        if(TryGetComponent<Animation>(out Animation animation)){
            anim = animation;
        }
    }
}
