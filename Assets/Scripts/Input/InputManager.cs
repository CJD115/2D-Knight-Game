using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
    public void SubmitPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Submit key pressed");

            GameEventsManager.instance.inputEvents.SubmitPressed();
        }
    }

    public void QuestLogTogglePressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            GameEventsManager.instance.inputEvents.QuestLogTogglePressed();
        }
    }
}
