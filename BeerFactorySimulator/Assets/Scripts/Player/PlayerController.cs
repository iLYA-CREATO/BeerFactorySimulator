using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ������������
    public float jumpForce = 5f; // ���� ������
    public float gravity = -9.81f; // ���� �������

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded; // ���������, �� ����� �� ��������

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // ������������� ��������� �������� ��� �������������� "�������"
        }

        Move();
        Jump();

        // ��������� ����������
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Move()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal"); // �������� ���� �� ����������� (�����/������)
        float moveVertical = Input.GetAxis("Vertical"); // �������� ���� �� ��������� (������/�����)

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical; // ������� ������ ��������
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * moveSpeed * 1.6f * Time.deltaTime); // ������� ���������
        }
        else
        {
            controller.Move(move * moveSpeed * Time.deltaTime); // ������� ���������
        }

    }

    void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) // ���������, �� ����� �� �������� � ������ �� ������
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity); // ������ ������
        }
    }
}