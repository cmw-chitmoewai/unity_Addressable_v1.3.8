using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.AsyncOperations;


public class AddressScript : MonoBehaviour
{
	
	public AssetReference localNo;

	public AssetLabelReference music;

	private AudioSource audioSoure;
	public void Start()
	{

		//DisplayMusic();

		Addressables.LoadAssetAsync<GameObject>("music").Completed += OnLoadDone;

	}
	public void DisplayMusic()
	{
		localNo.InstantiateAsync(Vector3.zero, Quaternion.identity);

		Debug.Log("loadSuccess");
	}

	private void OnLoadDone(AsyncOperationHandle<GameObject> obj)
	{
		
	}
}
