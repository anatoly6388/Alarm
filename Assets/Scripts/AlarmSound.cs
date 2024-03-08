using System.Collections;
using UnityEngine;

public class AlarmSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private float _delayVolume = 1f;
    private float _currentVolume = 0f;
    private float _volumeRate = 0.2f;
    
    public void OnAlarm()
    {
        float targetVolume = 1f;
        StopAllCoroutines();
        var wait = new WaitForSeconds(_delayVolume);
        StartCoroutine (Alarm(wait, targetVolume));
    }

    public void OffAlarm()
    {
        float targetVolume = 0f;
        StopAllCoroutines();
        var wait = new WaitForSeconds(_delayVolume);
        StartCoroutine(Alarm(wait, targetVolume));
    }

    private IEnumerator Alarm(WaitForSeconds wait,  float targetVolume)
    {
        while (true)
        {          
            _currentVolume = Mathf.MoveTowards(_currentVolume, targetVolume, _volumeRate);
            _audioSourse.volume = _currentVolume;
            _audioSourse.Play();
            yield return wait;
        }
    }
}
