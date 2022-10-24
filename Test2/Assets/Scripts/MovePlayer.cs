using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private float HorSpeed;
        
    private void FixedUpdate()
    {
        transform.Translate(HorSpeed, 0, 0);
    }

    public void OnRight()
    {
        HorSpeed = speed;
    }

    public void OnLeft() 
    {
        HorSpeed = -speed;
    }

    public void Stop()
    {
        HorSpeed = 0; 
    }
}
