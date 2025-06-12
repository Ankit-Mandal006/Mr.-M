using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionControl : MonoBehaviour
{
    [SerializeField] private Dropdown resolutionDropdown;
    //public Dropdown resolutionDropdown;
    private Resolution[] resolutions;
    private List<Resolution> filteredRedolutions;
    private float currentRefreshRate;
    private int currentResolutionIndex=0;
    // Start is called before the first frame update
    void Start()
    {
        resolutions=Screen.resolutions;
        filteredRedolutions=new List<Resolution>();
        resolutionDropdown.ClearOptions();
        currentRefreshRate=Screen.currentResolution.refreshRate;
        for(int i=0;i<resolutions.Length;i++)
        {
            if(resolutions[i].refreshRate==currentRefreshRate)
                filteredRedolutions.Add(resolutions[i]);
        }
        List<string> options=new List<string>();
        for(int i=0;i<filteredRedolutions.Count;i++)
        {
            string resolutionOption=filteredRedolutions[i].width+"x"+filteredRedolutions[i].height+" "+filteredRedolutions[i].refreshRate+" Hz";
            options.Add(resolutionOption);
            if(filteredRedolutions[i].width==Screen.width&&filteredRedolutions[i].height==Screen.height)
                currentResolutionIndex=i;
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value=currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution=filteredRedolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height,true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
