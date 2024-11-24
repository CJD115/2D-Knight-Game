using UnityEngine;

public class QuestIcon : MonoBehaviour
{
    [Header("Icons")]
    [SerializeField] private GameObject requirementsNotMetStartIcon;
    [SerializeField] private GameObject canStartIcon;
    [SerializeField] private GameObject requirementsNotMetIcon;
    [SerializeField] private GameObject canFinishIcon;

    public void SetState(QuestState newState, bool startPoint, bool finishPoint)
    {
        requirementsNotMetStartIcon.SetActive(false);
        canStartIcon.SetActive(false);
        requirementsNotMetIcon.SetActive(false);
        canFinishIcon.SetActive(false);

        switch (newState)
        {
            case QuestState.REQUIREMENTS_NOT_MET:
                if (startPoint)
                {
                    requirementsNotMetStartIcon.SetActive(true);
                }
            break;
            case QuestState.CAN_START:
                if (startPoint)
                {
                    canStartIcon.SetActive(true);
                }
            break;
            case QuestState.IN_PROGRESS:
                if (finishPoint)
                {
                    requirementsNotMetIcon.SetActive(true);
                }
            break;
            case QuestState.CAN_FINISH:
                if (finishPoint)
                {
                    canFinishIcon.SetActive(true);
                }
                break;
            case QuestState.FINISHED:
                // Do nothing
            break;
            default:
                Debug.LogWarning("Quest State not recognized by switch: " + newState);
            break;
        }
    }
}
