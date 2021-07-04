using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class UIManager : Manager<UIManager> // INHERITANCE
{
    [SerializeField] GameObject panel;
    [SerializeField] FlexibleColorPicker colorPicker;
    [SerializeField] Button InteractButton;
    private Decor selected;

    [SerializeField] GameObject startScreen;

    public void RemoveStartScreen()
    {
        startScreen.gameObject.SetActive(false); 
    }


    public void ShowPanel()
    {
        panel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        panel.gameObject.SetActive(false); 
    }

    public void ShowColor(Color color)
    {
        colorPicker.SetColor(color); 
        
    }

    public void ActivateInteractionButton()
    {
        if (!InteractButton.IsInteractable()) InteractButton.interactable = true; 
    }
    public void DeactivateInteractionButton()
    {
        if (InteractButton.IsInteractable()) InteractButton.interactable = false;
    }


    public Color GetColor()
    {
        return colorPicker.GetColor();
    }

    public void SetSelected(Decor sel)
    {
        selected = sel; 
    }

    public void Interaction()
    {
        selected.Interaction(); 
    }
}
