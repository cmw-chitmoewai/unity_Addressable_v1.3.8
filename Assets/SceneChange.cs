using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SceneChange : MonoBehaviour
{
	private List<IResourceLocation> loadscene;
	public AssetLabelReference sceneLabel;


	void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void NextScene()
	{
		//SceneManager.LoadScene(1);
		Addressables.LoadResourceLocationsAsync(sceneLabel.labelString).Completed += LoadSceneLocation;

	}

	public void LoadSceneLocation(AsyncOperationHandle<IList<IResourceLocation>> obj)
	{
		loadscene = new List<IResourceLocation>(obj.Result);

		Addressables.LoadSceneAsync(loadscene[0]);
	}

}
