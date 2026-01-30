using UnityEngine;

public class random_item : MonoBehaviour
{

    [SerializeField] string[] randomitems = new string[9];
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.A))PrintAllItems();
    }

    private void PrintRandomItem(){
        int index = Random.Range(0, 10); 
        Debug.Log(randomitems[index]);

    }

    private void PrintAllItems(){
        for (int i = 0; i < randomitems.Length; i++)
            Debug.Log(randomitems[i]);
    }
}
