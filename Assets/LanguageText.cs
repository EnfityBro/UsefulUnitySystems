using System;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class LanguageText : MonoBehaviour
{
    [SerializeField] private string[] textArray;
    private TextMeshProUGUI textField;
    private const int defaultLanguageIndex = 0;

    private static event Action OnLanguageChanged;

    private void Awake()
    {
        textField = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        OnLanguageChanged += UpdateLanguageText;
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("LanguageIndex"))
            PlayerPrefs.SetInt("LanguageIndex", defaultLanguageIndex);

        UpdateLanguageText();
    }

    private void OnDisable()
    {
        OnLanguageChanged -= UpdateLanguageText;
    }

    private void UpdateLanguageText()
    {
        if ((textField != null) && (textArray != null))
        {
            int languageIndex = PlayerPrefs.GetInt("LanguageIndex");

            if (languageIndex < textArray.Length)
                textField.text = textArray[languageIndex];
        }
    }

    /// <summary>
    /// Sets translations for all texts in the language of the specified index.
    /// </summary>
    public static void SetLanguage(int languageIndex)
    {
        PlayerPrefs.SetInt("LanguageIndex", languageIndex);
        OnLanguageChanged?.Invoke();
    }
}



/*

How to use:
1. Attach this script to TextMeshPro game object.
2. Add text elements to the "textArray" field in the Inspector window.
   (These elements are translations of the source text into other languages)
3. When the player changes the language (for example, by clicking on a button in a menu), just call the SetLanguage() method.


Documentation:
- The 'textArray' field contains text translations into other languages.


Comment:
- Instead of PlayerPrefs you can use another save/load system (see also InternalParams: https://github.com/EnfityBro/InternalParams).
- Instead of this class you can use more professional Localization package from Unity.

*/