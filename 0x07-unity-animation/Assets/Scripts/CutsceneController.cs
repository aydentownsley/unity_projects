using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CutsceneController : MonoBehaviour
{
    public GameObject TimerCanvas;
    public GameObject CutSceneCamera;
    public GameObject Freelook;
    // Start is called before the first frame update
    void Start()
    {
        Freelook.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            TimerCanvas.SetActive(true);
            Freelook.SetActive(true);
            Freelook.GetComponent<CinemachineFreeLook>().m_YAxis.Value = 0.45f;
            Freelook.GetComponent<CinemachineFreeLook>().m_XAxis.Value = 0;
            CutSceneCamera.SetActive(false);
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = true;
        }
    }
}
