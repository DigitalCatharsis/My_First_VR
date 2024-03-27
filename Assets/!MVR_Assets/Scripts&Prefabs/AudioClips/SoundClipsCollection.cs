using AYellowpaper.SerializedCollections;
using System.Collections.Generic;
using UnityEngine;

namespace My_First_VR
{
    [CreateAssetMenu(fileName = "New state", menuName = "My_First_VR/Audio/SoundClipsCollection")]
    public class SoundClipsCollection : ScriptableObject
    {
        public SerializedDictionary<string, List<AudioClip>> soundClips;
    }
}