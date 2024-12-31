using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f; // ���������������� ����
    public Transform playerBody; // ������ �� ���� ������ (���������)
    private float xRotation = 0f; // �������� �� ��� X

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // �������� ������ � ��������� ��� � ������ ������
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // �������� ���� �� ��� X
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // �������� ���� �� ��� Y

        xRotation -= mouseY; // ��������� �������� �� ��� X
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // ������������ �������� �� ��� X

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // ��������� �������� � ������
        playerBody.Rotate(Vector3.up * mouseX); // ������������ ���� ������ �� ��� Y
    }
}