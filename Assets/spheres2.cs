using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spheres2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        a = 5f;
        b = 1f;
 

        x = 0.05f;
        y = 0.1f;
        r = 0;
    }
float a,b,x,y,x0,y0;
    int r,r1;
    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(x) >=5.0)
            if (r == 1)
            {
                r = 0;
              
            }
            else
                r = 1;
        if (r == 0)
        {
            x += 0.05f;
            y = Mathf.Sqrt(Mathf.Abs((1.0f - (x  ) * (x ) / (a * a))) * b * b);
            transform.localPosition = new Vector3(x, y, 0.08f);
        }

        else
        {
            x -= 0.05f;
            y = Mathf.Sqrt(Mathf.Abs((1.0f - (x) * (x) / (a * a))) * b * b);
            transform.localPosition = new Vector3(x, -y, -0.08f);
        
       }
  
    }
}
