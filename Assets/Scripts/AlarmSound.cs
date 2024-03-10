using System.Collections;
using UnityEngine;

public class AlarmSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private float _delayVolume = 1f;
    private float _currentVolume = 0f;
    private float _volumeRate = 0.2f;
    
    public void OnAlarm(float targetVolume)
    {
        StopAllCoroutines();
        StartCoroutine (Alarm(targetVolume));
    }

    private IEnumerator Alarm(float targetVolume)
    {
        var wait = new WaitForSeconds(_delayVolume);

        while (true)
        {          
            _currentVolume = Mathf.MoveTowards(_currentVolume, targetVolume, _volumeRate);
            _audioSourse.volume = _currentVolume;
            _audioSourse.Play();
            yield return wait;
        }
    }
}
