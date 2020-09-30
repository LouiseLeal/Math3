using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{ 

    public Vector2 position;
    public Image image;

    public RectTransform rect;

    public void SetPosition(float positionX, float positionY)
    {
        rect.position = position;
    }

    public void SetSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }

    public Vector2 GetSpriteBounds()
    {
        return rect.sizeDelta;
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if(rect == null)
        {
            rect = GetComponent<RectTransform>();
        }
        if (image == null)
        {
            image = GetComponent<Image>();
        }
    }
#endif
}
