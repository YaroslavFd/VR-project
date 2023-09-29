using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject objectToToggle;
    public Text buttonText;

    private bool isObjectActive = true;

    private void Start()
    {
        UpdateButtonText();
    }

    public void ToggleObjectVisibility()
    {
        isObjectActive = !isObjectActive;
        objectToToggle.SetActive(isObjectActive);
        UpdateButtonText();
    }

    private void UpdateButtonText()
    {
        if (isObjectActive)
        {
            buttonText.text = "Скрыть куб";
        }
        else
        {
            buttonText.text = "Показать куб";
        }
    }
}