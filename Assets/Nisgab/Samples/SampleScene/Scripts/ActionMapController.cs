using NisGab;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Nisgab.Samples.SampleScene
{
    public class ActionMapController : MonoBehaviour
    {
        [SerializeField] private Color _activeColor = Color.green;
        [SerializeField] private Color _inactiveColor = Color.red;
        [SerializeField] private Toggle _togglePlayerInputButton;

        private void Awake()
        {
            Debug.Assert(_togglePlayerInputButton != null, "_togglePlayerInputButton != null");
        }

        private void Start()
        {
            _togglePlayerInputButton.onValueChanged.AddListener(OnTogglePlayerInput);
            OnTogglePlayerInput(_togglePlayerInputButton.isOn);
        }

        private void OnEnable()
        {
            InputEventBus.EnablePlayerInput();
            InputEventBus.Player.Interact += PlayerOnInteract;
        }

        private void OnTogglePlayerInput(bool isActive)
        {
            _togglePlayerInputButton.targetGraphic.color = isActive ? _activeColor : _inactiveColor;
            if (isActive)
            {
                InputEventBus.EnablePlayerInput();
            }
            else
            {
                InputEventBus.DisablePlayerInput();
            }
        }

        private void PlayerOnInteract(InputAction.CallbackContext context)
        {
            Debug.Log("PlayerOnInteract");
        }
    }
}
