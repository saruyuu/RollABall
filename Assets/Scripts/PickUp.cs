using UnityEngine;

public class PickUp : MonoBehaviour
{
    void Update()
    {
        // �I�u�W�F�N�g���p���I�ɉ�]������
        // X��around 15�x/�b�AY��around 30�x/�b�AZ��around 45�x/�b�̑��x�ŉ�]
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // �g���K�[�ɓ������I�u�W�F�N�g���v���C���[���ǂ������m�F
        if (other.gameObject.CompareTag("Player"))
        {
            // �v���C���[�������ꍇ�A����Pickup�I�u�W�F�N�g��j���i���W�j
            Destroy(gameObject);

            // �����ɁA�X�R�A���Z��T�E���h�Đ��Ȃǂ̒ǉ����������邱�Ƃ��ł��܂�
        }
    }
}