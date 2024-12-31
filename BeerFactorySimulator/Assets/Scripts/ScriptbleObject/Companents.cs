using UnityEngine;

[CreateAssetMenu(fileName = "Companents", menuName = "ScriptableObjects/Companents")]
public class Companents : ScriptableObject
{
    // В основном этот срипт будет хранить данные о компонентах нужных для приготовления товара
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
}
