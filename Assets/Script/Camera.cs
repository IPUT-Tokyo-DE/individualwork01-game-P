using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;     // �Ǐ]����v���C���[
    public Vector3 offset;       // �v���C���[����̃I�t�Z�b�g�i�ʒu�̃Y���j
    public float smoothSpeed = 0.125f;  // �J�����̓����̃X���[�Y��

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

        // �v���C���[�̈ʒu�ɃI�t�Z�b�g���������ʒu�Ɉړ�
        Vector3 desiredPosition = player.position + offset;
        desiredPosition.z = -10;

        // �X���[�Y�ɃJ�������Ǐ]����
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
