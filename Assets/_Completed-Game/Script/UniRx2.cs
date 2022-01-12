using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class UniRx2 : MonoBehaviour
{
    [SerializeField] [Range(0f, 100f)] private float speed = 1;
    [SerializeField] [Range(0f, 100f)] private float radias = 1;

    private float runTime = 0;
    private Vector2 newPos = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable().Subscribe(_ =>
        {
            runTime += Time.deltaTime * speed;
            float x = radias * Mathf.Cos(runTime);
            float y = radias * Mathf.Sin(runTime);
            newPos = new Vector2(x + Time.time, y);
            this.transform.position = newPos;
        });

    }


    // Update is called once per frame
    void Update()
    {

    }

}
