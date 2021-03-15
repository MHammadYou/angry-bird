using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float releaseTime;
    
    
    private bool _isPressed;
    void Update()
    {
        if (_isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseDown()
    {
        _isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        _isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
    }
    
}
