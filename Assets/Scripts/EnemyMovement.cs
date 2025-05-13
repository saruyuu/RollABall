using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    /// <summary>
    /// 追いかける目標のプレイヤーの位置情報
    /// </summary>
    public Transform player;
    /// <summary>
    /// 敵のNavMeshAgent
    /// </summary>
    private NavMeshAgent enemyNavMeshAgent;

    private void Start()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }



    // Update is called once per frame
    void Update()
    {
        //もし、playerがnullじゃなかったら
        if (player != null)
        {
            //navMeshAgentにPlayerの位置情報を目標に設定する
            enemyNavMeshAgent.SetDestination(player.position);
        }

    }
    
}
