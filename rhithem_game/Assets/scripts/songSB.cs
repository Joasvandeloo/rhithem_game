using UnityEngine;

[CreateAssetMenu(fileName = "songSB", menuName = "custom rythem master/songSB")]
public class songSB : ScriptableObject
{
    //functional info
    public string songName;
    public AudioClip sound;
    public int songID;
    public Sprite background;
    public int bpm;
    
    //cover info
    public Sprite coverIMG;
    public string discription;
    public string genre;
    public string difficulty;
    public string artist;
}
