using UnityEngine;
using UnityEngine.Networking;
namespace Mirror.Examples.Benchmark
{
    public class PlayerMovement : NetworkBehaviour
    {
        public float speed = 5;

        void Update()
        {
           

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, 0, v);
            transform.position += dir.normalized * (Time.deltaTime * speed);
            Debug.Log(dir);
        }
    }
}
