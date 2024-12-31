using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость передвижения
    public float jumpForce = 5f; // Сила прыжка
    public float gravity = -9.81f; // Сила тяжести

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded; // Проверяем, на земле ли персонаж

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Устанавливаем небольшое значение для предотвращения "падения"
        }

        Move();
        Jump();

        // Применяем гравитацию
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Move()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal"); // Получаем ввод по горизонтали (влево/вправо)
        float moveVertical = Input.GetAxis("Vertical"); // Получаем ввод по вертикали (вперед/назад)

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical; // Создаем вектор движения
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * moveSpeed * 1.6f * Time.deltaTime); // Двигаем персонажа
        }
        else
        {
            controller.Move(move * moveSpeed * Time.deltaTime); // Двигаем персонажа
        }

    }

    void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) // Проверяем, на земле ли персонаж и нажата ли пробел
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity); // Расчет прыжка
        }
    }
}