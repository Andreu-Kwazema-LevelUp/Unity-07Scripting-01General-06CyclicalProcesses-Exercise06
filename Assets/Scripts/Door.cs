using UnityEngine;

public class Door : MonoBehaviour
{

    private Switcher _switcher;

    private void Awake()
    {
        _switcher = FindObjectOfType<Switcher>();
    }

    private void OnEnable()
    {
        _switcher.SwitchChangeEvent.AddListener(OpenDoor);
    }

    private void OnDisable()
    {
        _switcher.SwitchChangeEvent.RemoveListener(OpenDoor);
    }

    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
    }

}
