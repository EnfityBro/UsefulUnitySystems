using UnityEngine;
using TMPro;

public class LanguageText : MonoBehaviour
{
    // static translation - it's more efficient, but when the player changes the language, it's necessary to restart the current game scene
    /*
    [SerializeField] private string[] textArray;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("LanguageIndex")) { PlayerPrefs.SetInt("LanguageIndex", 0); } // set the default language index (for example, it's 0)
        GetComponent<TextMeshProUGUI>().text = "" + textArray[PlayerPrefs.GetInt("LanguageIndex")];
    }
    */



    // dynamic translation - less effective if you have a huge number of texts, but more convenient for the player
    // you can also add some "if()" construction in update(), which will act as a limiter for a more efficient result
    /*
    [SerializeField] private string[] textArray;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("LanguageIndex")) { PlayerPrefs.SetInt("LanguageIndex", 0); } // set the default language index (for example, it's 0)
    }

    private void Update() => GetComponent<TextMeshProUGUI>().text = "" + textArray[PlayerPrefs.GetInt("LanguageIndex")];
    */
}



/*

How to use:
1. Attach this script to TextMeshPro game object.
2. Add text elements to the "textArray" field in the Inspector window.
   (These elements are translations of the source text into other languages)
3. When the player changes the language (for example, by clicking on a button in a menu), just change the language index in your script.


Documentation:
- The "textArray" variable contains text translations into other languages.


Comment:
- Instead of PlayerPrefs you can use another save/load system.

*/