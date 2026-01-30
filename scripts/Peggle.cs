using UnityEngine;

public class Peggle : MonoBehaviour
{
    public int hitsToDestroy = 3;     
     


  private void OnCollisionEnter2D(Collision2D collision)
   {
        

        
        hitsToDestroy--;

        
        if (hitsToDestroy <= 0)
        {
            Destroy(gameObject, 0.25f);
        } 
        
        
        
   }
}


