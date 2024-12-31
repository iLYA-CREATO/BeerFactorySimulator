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
    /// ��� ����� ��������� ������ � �������
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
                Debug.Log("��� ������ ����� � �������");
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
                        Debug.Log("����� ����� ��� ���� ���������");

                        componentsDataCart[i].ValueCart++;
                        return;
                    }
                }
                // ��� ��� �� � ������ ���� ����� ������� ��� �� �������� � ������� �� ��� ������

                Debug.Log("��� ����� ����� � �������");

                componentsDataCart.Add(newComponents);
                newComponents.ValueCart = 1;
            }
        }
    }
    public bool BuyCompanents()
    {

        // ���� �� ������ ������ 
        return false;
    }
}

[Serializable]
public class ComponentsData
{
    [Header("������ ����� ������")]
    public Companents companents;
    [Header("id ������")]
    public int idCompanents;
    [Header("�������� ����������")]
    public string nameComponent;
    [Header("��������� ����������")]
    public float priceComponent;
    [Header("���������� � �����")]
    public float stackComponent;

    [Header("���������� � �������")]
    public float ValueCart;
    // �� � ������ ��� ��� �� �����
}