using UnityEngine;

public class InputController : MonoBehaviour
{
    private IInputHandler inputHandler;

    private void Start()
    {
#if UNITY_STANDALONE || UNITY_WEBGL
        inputHandler = new KeyboardMouseInputHandler();
#elif UNITY_IOS || UNITY_ANDROID
        inputHandler = new TouchInputHandler();
#endif
    }

    private void Update()
    {
        if (inputHandler.GetAction())
        {
            Debug.Log("Action performed");
        }

        Vector2 movement = inputHandler.GetMovement();
        if (movement != Vector2.zero)
        {
            Debug.Log($"Movement: {movement}; Dir: {inputHandler.GetDirection()}");
        }
    }
}
