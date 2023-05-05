using UnityEngine;

public class InteractButton : MonoBehaviour
{
    
    // Update is called once per frame
    private void Update()
    {
        if (transform.parent.transform.localScale.x < 0)
        {
            
            transform.localScale = new Vector3(-1, 1, 1);
            return;
            
        }
        transform.localScale = new Vector3(1, 1, 1);
    }
}