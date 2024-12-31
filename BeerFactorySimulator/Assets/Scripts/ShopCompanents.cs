using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using static UnityEditor.Progress;

public class ShopCompanents : MonoBehaviour
{
    [SerializeField]
    private List<ComponentsData> componentsDataCart;
    /// <summary>
    /// Тут будем добавлять товары в корзину
    /// </summary>
    public void AddCartComponents(Component component)
    {
        if(componentsDataCart.Count < 10)
        {
            ComponentsData newComponents = new ComponentsData()
            {
                companents = component.companents,
                nameComponent = component.nameComponent,
                priceComponent = component.priceComponent,
                stackComponent = component.stackComponent,
                idCompanents = component.idCompanents
            };

            if (componentsDataCart.Count == 0)
            {
                Debug.Log("Это первый товар в корзине");
                componentsDataCart.Add(newComponents);
                newComponents.ValueCart = 1;
                return;
            }
           
            if (componentsDataCart.Count > 0)
            {
                for(int i = 0; i < componentsDataCart.Count; i++)
                {
                    if (componentsDataCart[i].idCompanents == newComponents.idCompanents)
                    {
                        Debug.Log("Такой товар уже есть прибовляю");

                        componentsDataCart[i].ValueCart++;
                        return;
                    }
                }
                // Тут как бы я сделал если такой предмет ещё не добавлен в корзину то его создаю

                Debug.Log("Это новый товар в корзине");

                componentsDataCart.Add(newComponents);
                newComponents.ValueCart = 1;
            }
        }
    }
    public bool BuyCompanents()
    {

        // Если не смогли купить 
        return false;
    }
}

[Serializable]
public class ComponentsData
{
    [Header("Откуда брать данные")]
    public Companents companents;
    [Header("id товара")]
    public int idCompanents;
    [Header("Название компонента")]
    public string nameComponent;
    [Header("Стоимость компанента")]
    public float priceComponent;
    [Header("Количество в стаке")]
    public float stackComponent;

    [Header("Количество в корзине")]
    public float ValueCart;
    // Ну а иконка мне тут не нужна
}