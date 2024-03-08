
using UnityEngine;

public class Mover : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Vector3 direction = new Vector3(0f, 0f, Input.GetAxis(Vertical));
        transform.Rotate(_rotationSpeed * Time.deltaTime * Input.GetAxis(Horizontal) * Vector3.up);
        transform.Translate(_speed * direction*Time.deltaTime);
    }
}
