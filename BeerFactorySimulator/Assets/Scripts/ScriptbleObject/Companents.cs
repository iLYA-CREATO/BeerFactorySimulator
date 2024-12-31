using UnityEngine;

[CreateAssetMenu(fileName = "Companents", menuName = "ScriptableObjects/Companents")]
public class Companents : ScriptableObject
{
    // � �������� ���� ����� ����� ������� ������ � ����������� ������ ��� ������������� ������
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
}
