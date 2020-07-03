using UnityEngine;
using VRStandardAssets.Utils;


    public class Gaze_active_objects : MonoBehaviour
    {
        [SerializeField] private Material m_NormalMaterial;                
        [SerializeField] private Material m_OverMaterial;
    [SerializeField] private GameObject[] m_ActivateObjects;
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private Renderer m_Renderer;


        private void Awake ()
        {
            m_Renderer.material = m_NormalMaterial;
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_InteractiveItem.OnClick += HandleClick;
            m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_InteractiveItem.OnClick -= HandleClick;
            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
        }


       
        private void HandleOver()
        {
           m_Renderer.material = m_OverMaterial;
        }


        
        private void HandleOut()
        {
            m_Renderer.material = m_NormalMaterial;
        }


       
        private void HandleClick()
        {
        foreach (GameObject obj in m_ActivateObjects)
        {
            obj.SetActive(true);
        }

    }


        
        private void HandleDoubleClick()
        {
            Debug.Log("Show double click");
            
        }
    }

