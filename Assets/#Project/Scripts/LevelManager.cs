using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    private float gapRow = 1.5f;
    private float gapCol = 1.5f;

    private float timer;
    public int score = 0;
    public Text text; 

    public GameObject itemPrefab;
    private GameObject item;
    public Material[] materials;
    public Material defaultMaterial;
    public List<GameObject> items = new List<GameObject>();
    
    

    void Start()
    {

    }


    public void CubeApparition()
    {   
        int index = 0;
        //Attente de 5 secondes entre chaque apparition

        while(items.Count < 9)
        {

            int x = Random.Range(1,5);
            int y = Random.Range(1,5);
            int z = Random.Range(1,5);

            Vector3 position = new Vector3 (x * gapRow,y , z * gapCol);
            item = Instantiate(itemPrefab, position, Quaternion.identity); 
            item.GetComponent<Renderer>().material = materials[index]; 

            items.Add(item);
            index++;

        }

    }

    private IEnumerator CoolDown()
    {
        // Attendre de 5 secondes avant la prochaine apparition du cube
        yield return new WaitForSeconds(5);        
    }

    public void CubeDestroyer()
    {
        // Destroy(item);
        // items.Remove(item);
		Debug.Log("I was there");
    }


    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);

        string scoreDisplay = "Score: " + score.ToString() ;  
        text.text = scoreDisplay;
	
        if(timer < 1)
        {
            CubeApparition();
            CubeDestroyer();
            StartCoroutine(CoolDown());
            timer = 0;
        }
     

    }	
}
