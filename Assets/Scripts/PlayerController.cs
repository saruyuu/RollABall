using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // �v���C���[�̈ړ����x
    public float speed = 10f;

    // Rigidbody�R���|�[�l���g�ւ̎Q��
    private Rigidbody sphereRigidbody;

    // ���͂��ꂽ�ړ��x�N�g��
    private Vector2 moveInput = Vector2.zero;

    public GameOverManager gameOverManager;
    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾
        sphereRigidbody = GetComponent<Rigidbody>();
    }

    // Input System����̈ړ����͂��������郁�\�b�h
    void OnMove(InputValue movementValue)
    {
        // ���͒l��2D�x�N�g���Ƃ��Ď擾
        moveInput = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        // ���̓x�N�g����3D��Ԃ̈ړ��x�N�g���ɕϊ�
        // Y���i���������j�̈ړ���0�ɐݒ�
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);

        // Rigidbody�ɗ͂������ăv���C���[���ړ�
        sphereRigidbody.AddForce(movement * speed);

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        //�G���ڐG���Ă�����
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOverManager.GameOver();
        }
    }
}