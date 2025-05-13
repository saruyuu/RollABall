using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    /// <summary>
    /// �ǂ�������ڕW�̃v���C���[�̈ʒu���
    /// </summary>
    public Transform player;
    /// <summary>
    /// �G��NavMeshAgent
    /// </summary>
    private NavMeshAgent enemyNavMeshAgent;

    private void Start()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }



    // Update is called once per frame
    void Update()
    {
        //�����Aplayer��null����Ȃ�������
        if (player != null)
        {
            //navMeshAgent��Player�̈ʒu����ڕW�ɐݒ肷��
            enemyNavMeshAgent.SetDestination(player.position);
        }

    }
    
}
