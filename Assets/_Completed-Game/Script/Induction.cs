using UnityEngine;

public class Induction : MonoBehaviour
{
    //public Transform TargetTr;

    public float waitTime;
    float angle;
    Vector2 target, mouse;

    bool isStun = false;
    public float Speed;
    float dis;

    void Start()
    {
        target = transform.position;
    }

  

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        void Monster_Move()
        {
            dis = Vector2.Distance(transform.position, mouse);
            if (dis < 50)
            {
                transform.Translate((mousePos - transform.position) * Speed);
            }
        }

        if (!isStun)
        {
            Monster_Move();
        }

       

    }
}
