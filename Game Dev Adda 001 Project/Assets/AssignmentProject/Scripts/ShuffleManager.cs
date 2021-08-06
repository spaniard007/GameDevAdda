using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuffleManager : MonoBehaviour
{
    public List<Image> personList= new List<Image>();
    public List<Image> topicList= new List<Image>();

    public Transform topicParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShuffleTopic(){

        for (int i = 0; i < topicList.Count; i++) {
         Image temp = topicList[i];
         int randomIndex = Random.Range(i, topicList.Count);
         topicList[i] = topicList[randomIndex];
         topicList[randomIndex] = temp;
         UpdateTopicUI(i,randomIndex);
         
     }
    }
    public void ShufflePerson(){

        for (int i = 0; i < personList.Count; i++) {
         Image temp = personList[i];
         int randomIndex = Random.Range(i, personList.Count);
         personList[i] = personList[randomIndex];
         personList[randomIndex] = temp;
         UpdatePersonUI(i,randomIndex);
         
     }
    }



    public void UpdateTopicUI(int index,int rand)
    {
        topicList[index].GetComponent<Transform>().SetSiblingIndex(rand);
    }

     public void UpdatePersonUI(int index,int rand)
    {
        personList[index].GetComponent<Transform>().SetSiblingIndex(rand);
    }
}
