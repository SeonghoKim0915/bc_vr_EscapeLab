using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;


    public class Teleport_Destination : MonoBehaviour
    {


    [SerializeField] private Material m_NormalMaterial;
    [SerializeField] private Material m_OverMaterial;
    [SerializeField] private Renderer m_Renderer;
    [SerializeField] private GameObject m_Player;
    [SerializeField] private Transform m_Destination;                     // The name of the scene to load 
    [SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete. 
    [SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.


    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.

    private void Awake()
    {
        m_Renderer.material = m_NormalMaterial;
    }

    private void OnEnable ()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
        }


        private void OnDisable ()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;
        }
        

        private void HandleOver()
        {
            // When the user looks at the rendering of the scene, show the radial.
            m_SelectionRadial.Show();
        m_Renderer.material = m_OverMaterial;

        m_GazeOver = true;
        }


        private void HandleOut()
        {
            // When the user looks away from the rendering of the scene, hide the radial.
            m_SelectionRadial.Hide();
        m_Renderer.material = m_NormalMaterial;
        m_GazeOver = false;
        }


        private void HandleSelectionComplete()
        {
            // If the user is looking at the rendering of the scene when the radial's selection finishes, activate the button.
            if(m_GazeOver)
             m_Player.transform.position = m_Destination.position;
    }


     
    }
