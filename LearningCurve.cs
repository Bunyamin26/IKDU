using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        FindPartyMember("Bunyamin Ensar Erman", 1);
    }


    public void FindPartyMember(string MyName, int IndexList)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        QuestPartyMembers.Insert(IndexList, MyName);

        int listLength = QuestPartyMembers.Count;

        //QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

}