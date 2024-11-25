using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class VisitPillarsQuestStep : QuestStep
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FinishQuestStep();
        }
    }
    
    protected override void SetQuestStepState(string state)
    {
        // No state to set
    }
}
