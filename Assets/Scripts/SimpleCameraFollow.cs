using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    // �ǐՂ���ΏہiPlayer�I�u�W�F�N�g�j
    public Transform target;

    // �J�����ƃ^�[�Q�b�g�̏������Έʒu
    private Vector3 offset;

    void Start()
    {
        // �Q�[���J�n���̃J�����ƃ^�[�Q�b�g�̑��Έʒu���v�Z���A�ۑ�
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // �^�[�Q�b�g�̌��݈ʒu�ɁA�����I�t�Z�b�g�������ăJ�����̈ʒu���X�V
        transform.position = target.position + offset;
    }
}