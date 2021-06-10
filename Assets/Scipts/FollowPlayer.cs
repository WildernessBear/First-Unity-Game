using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Transform links to the player w/ info
    // about position, rotation, and scale
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
