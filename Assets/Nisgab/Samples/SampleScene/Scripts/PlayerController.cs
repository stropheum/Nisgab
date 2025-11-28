using NisGab;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Nisgab.Samples.SampleScene
{
    public class PlayerController : MonoBehaviour
    {
        private void Awake()
        {
            InputEventBus.Player.Interact += PlayerOnInteract;
        }

        private void OnDestroy()
        {
            InputEventBus.Player.Interact -= PlayerOnInteract;
        }

        private void PlayerOnInteract(InputAction.CallbackContext context)
        {
            Debug.Log("PlayerOnInteract");
        }
        
        private void UIOnClick(InputAction.CallbackContext context)
        {
            Debug.Log("UIOnClick");
        }
    }
}
