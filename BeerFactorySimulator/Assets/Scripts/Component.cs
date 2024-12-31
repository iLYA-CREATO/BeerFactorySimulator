using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Component : MonoBehaviour
{
    [Header("Откуда брать данные")]
    public Companents companents;
    [Header("Название компонента")]
    public string nameComponent;
    [Header("Стоимость компанента")]
    public float priceComponent;
    [Header("Картинка компанента")]
    public Sprite spriteComponent;
    [Header("Количество в стаке")]
    public float stackComponent;
    [Header("id товара")]
    public int idCompanents;

    [Header("Количество в стаке")]
    public TextMeshProUGUI textName;
    [Header("Количество в стаке")]
    public TextMeshProUGUI textPrice;

    [Header("Количество в стаке")]
    public Image icon;

    public void Start()
    {
        if (companents!=null)
        {
            nameComponent = companents.nameComponent;
            spriteComponent = companents.spriteComponent;
            priceComponent = companents.priceComponent;
            stackComponent = companents.stackComponent;
            idCompanents = companents.idCompanents;

            textName.text = nameComponent;
            textPrice.text = priceComponent + " Р";
            icon.sprite = spriteComponent;
        }
        else
        {
            Debug.LogError("Companents is null");
        }
    }
}
