using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SliderSoundSystem : MonoBehaviour
{
    [SerializeField] private AudioSource[] audioSourcesType0, audioSourcesType1, audioSourcesType2;
    [SerializeField] private Slider[] sliders;
    [SerializeField] private float[] defaultValues;

    private List<AudioSource[]> allAudioSourcesList;

    private void Start()
    {
        allAudioSourcesList = new List<AudioSource[]>() { audioSourcesType0, audioSourcesType1, audioSourcesType2 };

        SetSoundVolumeValues(true);
    }

    public void SetSoundVolumeValues(bool onStart)
    {
        if (onStart)
        {
            for (int i = 0; i < allAudioSourcesList.Count; i++)
            {
                if (PlayerPrefs.HasKey($"SoundsVolumeType{i}")) { sliders[i].value = PlayerPrefs.GetFloat($"SoundsVolumeType{i}"); }
                else { sliders[i].value = defaultValues[i]; }
            }

            SetSoundVolumeValues(false);
        }
        else
        {
            for (int i = 0; i < allAudioSourcesList.Count; i++)
            {
                for (int j = 0; j < allAudioSourcesList[i].Length; j++) { allAudioSourcesList[i][j].volume = sliders[i].value; }
                PlayerPrefs.SetFloat($"SoundsVolumeType{i}", sliders[i].value);
            }
        }
    }
}



/*

How to use:
1. Attach this script to any game object.
2. If you want, rename the arrays like "audioSourcesType0" for your needs (because in this script these are the names for the example).
3. Fill in all fields in the "Inspector" window:
   3.1. In the fields like "audioSourcesType0, audioSourcesType1, audioSourcesType2", assign the "AudioSource" components corresponding to the same type of game sound.
   3.2. In the "sliders" field, assign the "Slider" components that will be responsible for controlling the volume of each type of game sound.
   3.3. In the "defaultValues" field, assign a default volume value for each type of game sound.
4. Configure the "Event Trigger" component on each of the sliders:
   4.1. Assign the "Event Trigger" component to each of the sliders.
   4.2. In the "Event Trigger" component, click on "Add New Event Type" and select "Drag".
   4.3. Add a new event by clicking on the "+".
   4.4. Attach the object with this script to the "Drag" event field.
   4.5. Click on function field in the "Drag" event field, select this script and select the "SetSoundVolumeValues" method.
   4.6. Set value to false in this field.


How to expand:
1. You can add more types of game sounds just by:
   1.1. Adding new arrays like "audioSourcesType3" in the code (lines 7 and 15).
   1.2. Assigning new "AudioSource" components, sliders and default volume values in the "Inspector" window in the appropriate fields.
2. Remember: 1 type of the game sound = 1 new "audioSourcesType_" array (with any number of AudioSource components), 1 new slider and 1 new default volume value.


Documentation:
- The arrays like "audioSourcesType0, audioSourcesType1, audioSourcesType2" is the arrays with the "AudioSource" components corresponding to the same type of game sound.
- The "sliders" array is the array of "Slider" components that will be responsible for controlling the volume of each type of game sound.
- The "defaultValues" array is the array containing default volume value for each type of game sound.


Comment:
- This system allows you to control the volume of each type of game sounds. Each type of game sound can contain multiple AudioSources.
- Instead of PlayerPrefs you can use another save/load system.
- You can use this system instead of an "Audio Mixer".

*/