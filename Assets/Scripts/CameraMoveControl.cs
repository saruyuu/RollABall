using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    /// <summary>
    /// �J�����̈ʒu���A��]�l�A�̏�񂪊i�[���ꂽTransform�^�̕ϐ�
    /// </summary>
    private Transform cameraTransform;
    
    //Start is called once before the first execution of Update after MoonoBehaviour is create
    void Start()
    {
       //�錾�����ϐ��ɂ��̃R���|�[�l���g���ǉ����ꂽGameObject��Transform��������
       cameraTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����̈ʒu���ɁA�E�����̃x�N�g���Ƀt���[���̎��Ԃ��������l�����Z��������
        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}
