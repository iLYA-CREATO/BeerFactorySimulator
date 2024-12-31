using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Чувствительность мыши
    public Transform playerBody; // Ссылка на тело игрока (персонажа)
    private float xRotation = 0f; // Вращение по оси X

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Скрываем курсор и блокируем его в центре экрана
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // Получаем ввод по оси X
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // Получаем ввод по оси Y

        xRotation -= mouseY; // Обновляем вращение по оси X
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Ограничиваем вращение по оси X

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Применяем вращение к камере
        playerBody.Rotate(Vector3.up * mouseX); // Поворачиваем тело игрока по оси Y
    }
}