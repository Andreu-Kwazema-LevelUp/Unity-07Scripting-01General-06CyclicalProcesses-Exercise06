using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour
{
    public bool IsSwitched { get; private set; }

    #region Events

    public UnityEvent SwitchChangeEvent;

    #endregion


    #region Unity Methods

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnDisable()
    {
        SwitchChangeEvent.RemoveAllListeners(); //Es correcto?
    }

    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;

            OnSwitchChange();
        }
    }

    #endregion


    private void OnSwitchChange()
    {
        SwitchChangeEvent?.Invoke();
    }
}
