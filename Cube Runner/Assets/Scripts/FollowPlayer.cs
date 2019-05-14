using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
    public float SmoothSpeed = 0.125f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 DesiredPostion = player.transform.position + offset;
        Vector3 SmoothenedPostion = Vector3.Lerp(this.transform.position, DesiredPostion, SmoothSpeed);

        this.transform.position = SmoothenedPostion;

        this.transform.LookAt(player);
    }
}
