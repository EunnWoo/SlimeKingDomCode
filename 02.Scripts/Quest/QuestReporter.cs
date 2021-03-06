using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuestReporter : MonoBehaviour
{
    [SerializeField]
    private Category category;
    [SerializeField]
    private TaskTarget target;
    [SerializeField]
    private int successCount;
    [SerializeField]
    private string[] colliderTags;

    private void OnTriggerEnter(Collider other){
        ReportIfPassCondition(other);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        ReportIfPassCondition(other);
    }

    public void Report(){
        Managers.Quest.ReceiveReport(category,target,successCount);
    }

    private void ReportIfPassCondition(Component other){
        if(colliderTags.Any(x => other.CompareTag(x))){
            Report();
        }
    }
}