using System;
using UnityEngine;

public class AllRaycast : MonoBehaviour
{
    public static event Action<GameObject> OnRayPC;

    [SerializeField]
    [Header("Дальность пуска райкаста")]
    private LayerMask m_Mask;

    [SerializeField]
    [Header("Tag")]
    private string tagObject;

    [SerializeField]
    [Header("Дальность пуска райкаста")]
    private float distance;

    [SerializeField]
    [Header("Место хранение всех данных")]
    private PanelData panelData;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, m_Mask))
        {
            if (hit.collider.tag == tagObject)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    OnRayPC?.Invoke(panelData.panelPC);
                }
            }
        }
    }
}
