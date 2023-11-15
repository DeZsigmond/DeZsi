
using UnityEngine;

 class MultiplicatuoonTable : MonoBehaviour
{
    


    void Start()
   
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int jk = 1; jk <=10;  jk++)
            {
                Debug.Log($"{i}*{jk}={i * jk}");
            }
        }
    }

    
}
