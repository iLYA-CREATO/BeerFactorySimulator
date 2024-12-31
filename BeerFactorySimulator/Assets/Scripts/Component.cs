using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Component : MonoBehaviour
{
    [Header("������ ����� ������")]
    public Companents companents;
    [Header("�������� ����������")]
    public string nameComponent;
    [Header("��������� ����������")]
    public float priceComponent;
    [Header("�������� ����������")]
    public Sprite spriteComponent;
    [Header("���������� � �����")]
    public float stackComponent;
    [Header("id ������")]
    public int idCompanents;

    [Header("���������� � �����")]
    public TextMeshProUGUI textName;
    [Header("���������� � �����")]
    public TextMeshProUGUI textPrice;

    [Header("���������� � �����")]
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
            textPrice.text = priceComponent + " �";
            icon.sprite = spriteComponent;
        }
        else
        {
            Debug.LogError("Companents is null");
        }
    }
}
