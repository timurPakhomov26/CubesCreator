
using UnityEngine;
using TMPro;
using System.Linq;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private TMP_InputField _timer;
     [SerializeField] private TMP_InputField _speed;  
     [SerializeField] private TMP_InputField _distance;
    public TMP_InputField Speed=>_speed;  
    public TMP_InputField Distance=>_distance;
    private float _helpTime;
    private float _times;
    private List<TMP_InputField> inputFields;
  
           
         
   private void Start()
    {
        inputFields=FindObjectsOfType<TMP_InputField>().ToList();   
    }
    private void Update()
     {    
        float.TryParse(_timer.text,out _times);                                
       DataCorrect();              
     }
    private void CreateCubes( float Timing)
     {
     _helpTime+=Time.deltaTime;

     if(_helpTime - Timing>0)
          {
             Instantiate(_cube,transform.position,Quaternion.identity ) ;
            _helpTime=0f;
          }   
     }
   private   void DataCorrect()
     { 
           int sum=1;
           int[] inputCount=new int[inputFields.Count]; 
         for (int i=0;i<inputFields.Count ; i++)
         {                 
               int.TryParse(inputFields[i].text,out inputCount[i]) ;  

               sum= inputCount[i] < 1 ? 0: sum ;                
         }
            if(sum>0)           
             CreateCubes(_times);
                        
         }       
     }
 
   

   
   
   
    




