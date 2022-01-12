using UnityEngine;

public class vectori : MonoBehaviour
{
    // 2PI/t 주기= 증가이다
    //a진폭 = y값을 증가
    // Start is called before the first frame update

    public float phase;
    float phaseA;
    private float speed = 1.0f;
    private float runTime = 0;

    void Start()
    {
        phaseA = phase + 30f;
        //runTime += Time.deltaTime * speed;
    }

    void Update()
    {
        transform.localPosition = new Vector3(Time.time * speed, Mathf.Sin(Time.time + speed), 0); ;


    }



}
