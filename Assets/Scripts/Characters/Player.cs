using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float JumpStrength;
    [SerializeField] private float speed;
    private Vector2 _moveDir;
    

    // Start is called before the first frame update
    void Start()
    {
        ImputManager.init(this);
        ImputManager.GameMode();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) (speed * Time.deltaTime * _moveDir);

        if (Input.GetKeyDown("space"))
        {
            rigidbody2D.AddForce(new Vector2(0, JumpStrength), ForceMode2D.Impulse);
        }
    }

    public void SetMovementDirection(Vector2 newDirection) 
    {
        _moveDir = newDirection;
    }

}
