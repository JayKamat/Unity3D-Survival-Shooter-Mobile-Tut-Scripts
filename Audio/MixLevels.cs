using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

	public AudioMixer masterMixer;

	float value;

	void Start()
	{
		value = -10;
	}

	public void SetSfxLvl(float sfxLvl)
	{
		masterMixer.SetFloat("sfxVol", sfxLvl);
	}

	public void SetMusicLvl (float musicLvl)
	{
		masterMixer.SetFloat ("musicVol", musicLvl);
	}

	public void soundtoggle()
	{
		if (value == -10) {
			value = -80;
		} 
		else 
		{
			value = -10;
		}
		masterMixer.SetFloat("sfxVol", value);
		masterMixer.SetFloat ("musicVol", value);
	}
}
