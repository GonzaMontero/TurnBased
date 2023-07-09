using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField;
    public TextMeshProUGUI textField;
    public LayoutElement layoutElement;
    public int characterWrapLimit;

    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();   
    }

    private void Update()
    {
        Vector2 position = Input.mousePosition;

        float pivotX = position.x / Screen.width;
        float pivotY = position.y / Screen.height;

        rectTransform.pivot = new Vector2(pivotX, pivotY);

        transform.position = position;
    }

    public void ShowTooltip(string headerKey, string contentKey)
    {
        gameObject.SetActive(true);

        if (string.IsNullOrEmpty(headerKey))
            headerField.gameObject.SetActive(false);
        else
        {
            headerField.gameObject.SetActive(true);
            headerField.text = headerKey;
        }

        if (string.IsNullOrEmpty(contentKey))
            textField.gameObject.SetActive(false);
        else
        {
            textField.gameObject.SetActive(true);
            textField.text = contentKey;
        }


        int headerlength = headerField.text.Length;
        int contentlength = textField.text.Length;

        layoutElement.enabled = (headerlength > characterWrapLimit || contentlength > characterWrapLimit);
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}
