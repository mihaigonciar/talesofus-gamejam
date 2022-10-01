using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform Target;
    private Vector3 _playerPosition;

    public float Offset = 0f;
    [Range(0f, 1f)]
    public float SmoothingPercent = 1f;

    private void Update()
    {
        if (Target != null)
        {
            if (Target.localScale.x > 0f)
            {
                _playerPosition = new Vector3(Target.position.x + Offset, this.transform.position.y, this.transform.position.z);
            }
            else
            {
                _playerPosition = new Vector3(Target.position.x - Offset, this.transform.position.y, this.transform.position.z);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Target != null)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, _playerPosition, SmoothingPercent);
        }
    }
}
