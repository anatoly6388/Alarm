
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    [SerializeField] private AlarmSound _alarm;

    private float _targetVolume;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rogue rogue))
            _targetVolume= 1;
            _alarm.OnAlarm(_targetVolume);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Rogue _))
            _targetVolume = 0;
            _alarm.OnAlarm(_targetVolume);
    }

    
}
