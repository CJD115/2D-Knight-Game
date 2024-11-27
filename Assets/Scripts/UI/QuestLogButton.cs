using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;

public class QuestLogButton : MonoBehaviour, ISelectHandler
{
    private TextMeshProUGUI buttonText;

    private UnityAction onSelectAction;

    public void Initialize(string displayName, UnityAction selectAction)
    {
        this.buttonText = this.GetComponentInChildren<TextMeshProUGUI>();
        this.buttonText.text = displayName;
        this.onSelectAction = selectAction;
    }

    public void OnSelect(BaseEventData eventData)
    {
        onSelectAction();
    }
}
