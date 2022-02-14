using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const int SPEED_UNIT = 100;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        transform.position = new Vector2(
            transform.position.x + speed * direction.x / SPEED_UNIT,
            transform.position.y + speed * direction.y / SPEED_UNIT
        );
    }
}
