using UnityEngine;


public class SeceneLoder : MonoBehaviour
{
    void Awake()
    {
        float ratio = Mathf.Clamp((float)1024 / Screen.height, 0, 1);
        Screen.SetResolution((int)(Screen.width * ratio), (int)(Screen.height * ratio), true, 60);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Load(string name)
    {

    }
}
