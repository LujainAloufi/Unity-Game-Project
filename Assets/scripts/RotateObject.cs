using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 5f; // سرعة الدوران

    // يتم استدعاء التحديث في كل إطار
    void Update()
    {
        // تدوير الكائن حول محوره z
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0,Space.Self);
    }
}