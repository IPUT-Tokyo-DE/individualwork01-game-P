using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;     // 追従するプレイヤー
    public Vector3 offset;       // プレイヤーからのオフセット（位置のズレ）
    public float smoothSpeed = 0.125f;  // カメラの動きのスムーズさ

    void LateUpdate()
    {
        if (player == null)
        {
            GameObject playerObj = GameObject.Find("Player");
            if (playerObj != null)
                player = playerObj.transform;
            else
                return;
        }

        // プレイヤーの位置にオフセットを加えた位置に移動
        Vector3 desiredPosition = player.position + offset;
        desiredPosition.z = -10;

        // スムーズにカメラが追従する
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
