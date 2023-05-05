using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitateEffect : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector3 _startPosition;
    private Vector3 _maxTopPosition;
    private Vector3 _maxBottomPosition;
    
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;
        _maxTopPosition = _startPosition + new Vector3(0,0.03f,0);
        _maxBottomPosition = _startPosition - new Vector3(0, 0.03f, 0);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(transform.position.y > _maxTopPosition.y)
        {
            _rigidbody.AddForce(new Vector2(0, -1 ) * 0.1f);
        } else if (transform.position.y < _maxBottomPosition.y)
        {
            _rigidbody.AddForce(new Vector2(0, 1 ) * 0.1f);
        }
        else
        {
            _rigidbody.AddForce(new Vector2(0, 1 ) * 0.1f);
        }
    }
}
