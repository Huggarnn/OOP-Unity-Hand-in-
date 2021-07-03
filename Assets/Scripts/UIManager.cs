using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class UIManager : Manager<UIManager> // INHERITANCE
{
    [SerializeField] GameObject panel;
    [SerializeField] FlexibleColorPicker colorPicker;
    [SerializeField] Slider sizeSlider;
    private Decor selected; 


    public void ShowPanel()
    {
        panel.gameObject.SetActive(true);
        Debug.Log(colorPicker.color); 
    }

    public void HidePanel()
    {
        panel.gameObject.SetActive(false); 
    }

    public void ShowColor(Color color)
    {
        colorPicker.SetColor(color); 
        
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
