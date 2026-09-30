using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;
    public float speed = 5f;
    void Start()
    {



    }

    private void LateUpdate()
    {
        direction = goal.transform.position - this.transform.position;
        if (Vector3.Angle(direction, this.transform.forward) < 20) 
        { 
            this.transform.LookAt(goal.transform.position);

        if (direction.magnitude > 4)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
}