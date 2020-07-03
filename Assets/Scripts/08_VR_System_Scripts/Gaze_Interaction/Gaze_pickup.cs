using UnityEngine;
using VRStandardAssets.Utils;

   
    public class Gaze_pickup : MonoBehaviour
    {
       
        [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private SelectionRadial m_SelectionRadial;
        [SerializeField] private Material m_Normal;
        [SerializeField] private Material m_Gaze;
        [SerializeField] private Renderer obj_Render;
        
		public float picking_distance;
        private Rigidbody rb;
        private bool m_GazeOver;

        private void Awake ()
        {
            rb = GetComponent <Rigidbody>();
            rb.useGravity = false;
            obj_Render.material = m_Normal;
                       
        }
       private void FixedUpdate()
        {
            if (Input.GetButton("Fire1") && m_GazeOver)
            {
                rb.useGravity = false;
                this.transform.position = Vector3.Lerp(this.transform.position,
                Camera.main.transform.position + Camera.main.transform.TransformDirection(Vector3.forward) * picking_distance,
                Time.deltaTime * 4);
                Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward) * picking_distance;
            }

            

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
            Debug.Log("Show over state");
            m_GazeOver = true;
            obj_Render.material = m_Gaze;
            rb.useGravity = false;

        }


        
        private void HandleOut()
        {
            Debug.Log("Show out state");
            m_GazeOver = false;
            obj_Render.material = m_Normal;
            rb.useGravity = true;




        }


        //Handle the Click event
        private void HandleClick()
        {
            Debug.Log("Show click state");
            

        }


        //Handle the DoubleClick event
        private void HandleDoubleClick()
        {
            Debug.Log("Show double click");
           
        }
    }

