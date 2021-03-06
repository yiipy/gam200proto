using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float chaseSpeed = 3f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    bool damageplayer = false;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public int damage = 10;
    public GameObject Player;

    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    private float patrolSpeed = 2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //add in if inside collider
        target = GameObject.Find("Player").transform;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            damageplayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            damageplayer = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("InRange") == 0)
        {
            Transform wp = waypoints[currentWaypointIndex];
            if (Vector3.Distance(transform.position, wp.position) < 0.01f)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, wp.position, patrolSpeed * Time.deltaTime);
            }
        }

        else if (PlayerPrefs.GetInt("InRange") == 1)
        {
            if (target)
            {
                Vector3 direction = (target.position - transform.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                rb.rotation = angle;
                moveDirection = direction;

                if (damageplayer == true)
                {
                    if (Time.time > nextActionTime)
                    {
                        nextActionTime += period;
                        Player.GetComponent<Player>().TakeDamage(damage);
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("InRange") == 1)
        {
            chaseSpeed = 3f;
            if (target)
            {
                rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * chaseSpeed;
            }
        }
        else
        {
            chaseSpeed = 0f;
        }
    }
}