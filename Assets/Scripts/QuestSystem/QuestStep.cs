using UnityEngine;

public abstract class QuestStep : MonoBehaviour
{
     private bool isFinished = false;

     protected void FinishQuestStep()
     {
         if (!isFinished)
         {
            isFinished = true;

            // TODO -Advance to the next step

            Destroy(this.gameObject);
         }
     }
}
