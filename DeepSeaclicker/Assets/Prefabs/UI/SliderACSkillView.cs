using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderACSkillView : MonoBehaviour
{
    public ACSkill acskill;
    public Slider slider;
    
    // Update is called once per frame
    void Update()
    {
        slider.value = acskill.cooldownTime;
    }
}
