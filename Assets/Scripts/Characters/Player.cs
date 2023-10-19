using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [SerializeField] private Vector2 JumpStrength;
    [SerializeField] private float speed;
    private Vector2 _moveDir;
    private int points;


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

    }

    public void SetMovementDirection(Vector2 newDirection) 
    {
        _moveDir = newDirection;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Candy")
        {
            Destroy(coll.gameObject);

            points += 1;
        }
    }

}
