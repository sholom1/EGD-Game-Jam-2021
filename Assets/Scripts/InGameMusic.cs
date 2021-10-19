using System.Collections;
using UnityEngine;

public class InGameMusic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] songs;

    private void Start()
    {
        StartCoroutine(CycleSongs());
    }
    public IEnumerator CycleSongs()
    {
        if (songs.Length > 0)
        {
            int index = 0;
            while (true)
            {
                index = index < songs.Length ? index + 1 : 0;
                AudioClip currentClip = songs[index];
                source.clip = currentClip;
                source.Play();
                yield return new WaitForSeconds(currentClip.length);
            }
        }
    }
}