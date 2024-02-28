using UnityEngine;
using Akequ;

namespace HeiHua
{
    public class Music : MonoBehaviour
    {
        public GameObject MusicGameObject = new GameObject("MusicPlayer");
        public AudioClip clip;
        public new AudioSource audio;
        public void Play(bool isLoop)
        {
            audio = MusicGameObject.AddComponent<AudioSource>();
            audio.clip = clip;
            audio.loop = isLoop;
            audio.Play();
        }

        public void Stop()
        {
            audio.Stop();
        }
    }
}