 using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 6f;


    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * (speed * Time.deltaTime));
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (speed * Time.deltaTime));
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (speed * Time.deltaTime));
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * (speed * Time.deltaTime));
        }
    }
}
