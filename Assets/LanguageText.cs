using System;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class LanguageText : MonoBehaviour
{
    [SerializeField] private string[] textArray;
    private TextMeshProUGUI textField;
    private const int defaultLanguageIndex = 0;

    private static event Action<int> OnLanguageChanged;

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

        UpdateLanguageText(PlayerPrefs.GetInt("LanguageIndex"));
    }

    private void OnDisable()
    {
        OnLanguageChanged -= UpdateLanguageText;
    }

    /// <summary>
    /// Sets translations for all texts in the language of the specified index.
    /// </summary>
    public static void SetLanguage(int languageIndex)
    {
        PlayerPrefs.SetInt("LanguageIndex", languageIndex);
        OnLanguageChanged?.Invoke(languageIndex);
    }

    private void UpdateLanguageText(int languageIndex)
    {
        if (textArray.Length == 0)
        {
            Debug.LogError($"The '{nameof(textArray)}' field is an empty array in the {gameObject.name} text. " +
                $"The language won't be changed on this text.");
            return;
        }

        if (languageIndex < textArray.Length)
            textField.text = textArray[languageIndex];
    }
}



/*

How to use:
1. Copy this script into your project.
2. Attach this script to TextMeshPro game object.
3. Add text elements to the "textArray" field in the Inspector window.
   (These elements are translations of the source text into other languages)
4. When the player changes the language (for example, by clicking on a button in a menu), just call the SetLanguage() method.


Documentation:
- The 'textArray' field contains text translations into other languages.


Comment:
- Instead of PlayerPrefs you can use another save/load system (see also InternalParams: https://github.com/EnfityBro/InternalParams).
- Instead of this class you can use more professional Localization package from Unity.

*/