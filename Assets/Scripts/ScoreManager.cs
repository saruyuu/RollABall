using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // �X�R�A��\������TextMeshPro
    private TextMeshProUGUI scoreText;

    // �Q�[���N���A��\������TextMeshPro
    public TextMeshProUGUI gameClearText;

    // �����̃A�C�e����
    private int initialItemCount;

    // ���݂̃A�C�e����
    private int currentItemCount;

    // �X�R�A
    private int score = 0;

    // �o�ߎ���
    private float elapsedTime = 0f;

    // �Q�[�����I���������ǂ���
    public bool isGameFinished = false;

    void Start()
    {
        // �X�R�A��\������TextMeshPro�R���|�[�l���g���擾
        scoreText = GetComponent<TextMeshProUGUI>();

        // 'Item'�^�O�̕t�����I�u�W�F�N�g�̏������𐔂���
        initialItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        currentItemCount = initialItemCount;

        // �Q�[���N���A�e�L�X�g���\���ɂ���
        gameClearText.gameObject.SetActive(false);

        // �����X�R�A��\��
        UpdateScoreDisplay();
    }

    void Update()
    {
        if (!isGameFinished)
        {
            // �o�ߎ��Ԃ��X�V
            elapsedTime += Time.deltaTime;

            // ���݂̃A�C�e�����𐔂���
            int newItemCount = GameObject.FindGameObjectsWithTag("Item").Length;

            // �A�C�e���������Ă�����X�R�A�𑝂₷
            if (newItemCount < currentItemCount)
            {
                score += currentItemCount - newItemCount;
                currentItemCount = newItemCount;
            }

            // �X�R�A�\�����X�V
            UpdateScoreDisplay();

            // ���ׂẴA�C�e����������ꂽ��Q�[���I��
            if (currentItemCount == 0)
            {
                isGameFinished = true;
                gameClearText.gameObject.SetActive(true);
            }
        }
    }

    void UpdateScoreDisplay()
    {
        // �X�R�A�Ǝ��Ԃ�ʁX�̍s�ɕ\��
        scoreText.text = $"Score: {score}\nTime: {elapsedTime:000.00}";
    }
}
