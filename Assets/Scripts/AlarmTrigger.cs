
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    [SerializeField] private AlarmSound _alarm;
    private void OnTriggerEnter(Collider other)
    {
        _alarm.OnAlarm();
    }

    private void OnTriggerExit(Collider other)
    {
        _alarm.OffAlarm();
    }

    
}
