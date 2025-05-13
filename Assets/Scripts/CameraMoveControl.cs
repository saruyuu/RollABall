using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{
    /// <summary>
    /// カメラの位置情報、回転値、の情報が格納されたTransform型の変数
    /// </summary>
    private Transform cameraTransform;
    
    //Start is called once before the first execution of Update after MoonoBehaviour is create
    void Start()
    {
       //宣言した変数にこのコンポーネントが追加されたGameObjectのTransformを代入する
       cameraTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの位置情報に、右方向のベクトルにフレームの時間をかけた値を加算し続ける
        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}
