

using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private void LateUpdate()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 target = player.transform.position + new Vector3(0, 2, -7);
        transform.position = target;

    }
}
