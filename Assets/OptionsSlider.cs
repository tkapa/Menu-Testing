using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsSlider : MonoBehaviour
{
    public TextMeshProUGUI sliderText = null;
    public string text = "New String";

    Slider slider = null;

    // Start is called before the first frame update
    void Start()
    {
        if(TryGetComponent<Slider>(out Slider result)){
            slider = result;
            slider.onValueChanged.AddListener(delegate {UpdateText();});
            UpdateText();
        } else {
            Debug.LogError(gameObject + " doesn't have a slider component");
        }
    }

    void UpdateText(){
        sliderText.text = text + " " + slider.value.ToString("F2");
    }
}
