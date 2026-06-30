using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace Enfity.UsefulUnitySystems
{
    public class SliderSoundSystem : MonoBehaviour
    {
        [SerializeField] private List<AudioType> audioTypes;

        private void Start()
        {
            SetUpSoundSlidersValues();
        }

        private void SetUpSoundSlidersValues()
        {
            for (int i = 0; i < audioTypes.Count; i++)
            {
                if (PlayerPrefs.HasKey($"SoundType{i}Volume"))
                    audioTypes[i].slider.value = PlayerPrefs.GetFloat($"SoundType{i}Volume");
                else
                    audioTypes[i].slider.value = audioTypes[i].defaultVolumeValue;
            }

            SetSoundVolumeValues();
        }

        /// <summary>
        /// Sets the current volume for all types of sounds.
        /// </summary>
        public void SetSoundVolumeValues()
        {
            for (int i = 0; i < audioTypes.Count; i++)
            {
                for (int j = 0; j < audioTypes[i].audioSources.Length; j++)
                    audioTypes[i].audioSources[j].volume = audioTypes[i].slider.value;

                PlayerPrefs.SetFloat($"SoundType{i}Volume", audioTypes[i].slider.value);
            }
        }

        [Serializable]
        public class AudioType
        {
            public AudioSource[] audioSources;
            public Slider slider;
            public float defaultVolumeValue;
        }
    }
}



/*

How to use:
1. Copy this script into your project.
2. Attach this script to any game object.
3. Add new element of audioTypes array and fill in all fields in the Inspector window:
   3.1. In the 'audioSources' field, assign the AudioSource components corresponding to this type of game sound.
   3.2. In the 'slider' field, assign the Slider components that will be responsible for controlling the volume of this type of game sound.
   3.3. In the 'defaultVolumeValue' field, assign a default volume value for this type of game sound.
4. Add SetSoundVolumeValues method in OnValueChanged event on each slider.


Comment:
- This system allows you to control the volume of each type of game sounds. Each type of game sound can contain multiple AudioSources.
- You can use this system instead of Audio Mixer.
- Instead of PlayerPrefs you can use another save/load system (see also InternalParams: https://github.com/EnfityBro/InternalParams).

*/