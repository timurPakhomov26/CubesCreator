
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{           
    private Transform _spawnPoint;
    

    private void Start(){
        
        _spawnPoint=FindObjectOfType<Spawn>().transform;  
                        
    }
    private void FixedUpdate()
     {  
       Move();   
      }
          
    
    private void Move()
    {
        int Speed,Distance;
       
        int.TryParse(FindObjectOfType<Spawn>().Speed.text, out Speed);                               
         int.TryParse(FindObjectOfType<Spawn>().Distance.text,out Distance);  
                   
       transform.Translate(Time.fixedDeltaTime* Speed *Vector3.forward);
          if(Vector3.Distance(transform.position,_spawnPoint.transform.position)> Distance )
          {
             Destroy(gameObject); 
          }                                               
   }
  

}