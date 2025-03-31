using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        //Time.deltaTime will insure smoothness. Its difference in seconds since the last frame update occured.
        transform.Rotate(new Vector3(15, 30,45) * Time.deltaTime);
    }
}
