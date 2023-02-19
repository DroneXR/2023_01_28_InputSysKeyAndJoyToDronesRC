using Eloi;
using SoloDroneInputSpace;
using System.Collections;
using System.Collections.Generic;
using ThreeDroneOnComputerSpace;
using UnityEngine;

public class InputToMultiDroneRCValueMono : MonoBehaviour
{

    public ThreeDroneOnComputer m_multiDroneInput;

    public DroneRC m_xboxDrone;
    public DroneRC m_numpadDrone;
    public DroneRC m_keyboardDrone;


    public enum KeyboardType { Qwerty, Azerty}
    public KeyboardType m_keyboardType;


    [System.Serializable]
    public class DroneRC { 
        public float m_leftRight;
        public float m_backFront;
        public float m_downUp;
        public float m_leftRightRotation;

        public PrimitiveUnityEvent_Float m_leftRightEvent;
        public PrimitiveUnityEvent_Float m_backFrontEvent;
        public PrimitiveUnityEvent_Float m_downUpEvent;
        public PrimitiveUnityEvent_Float m_leftRightRotationEvent;
    }






    public void Start()
    {
        m_multiDroneInput = new ThreeDroneOnComputer();
        m_multiDroneInput.Enable();

        m_multiDroneInput.DroneMainXboxController.Enable();
        m_multiDroneInput.DroneMainXboxController.LeftRight.performed += (a) => { m_xboxDrone.m_leftRight = a.ReadValue<float>(); m_xboxDrone.m_leftRightEvent.Invoke(m_xboxDrone.m_leftRight); };
        m_multiDroneInput.DroneMainXboxController.LeftRight.canceled += (a) => { m_xboxDrone.m_leftRight = 0; m_xboxDrone.m_leftRightEvent.Invoke(0); };

        m_multiDroneInput.DroneMainXboxController.BackForward.performed += (a) => { m_xboxDrone.m_backFront = a.ReadValue<float>(); m_xboxDrone.m_backFrontEvent.Invoke(m_xboxDrone.m_backFront); };
        m_multiDroneInput.DroneMainXboxController.BackForward.canceled += (a) => { m_xboxDrone.m_backFront = 0; m_xboxDrone.m_backFrontEvent.Invoke(0); };

        m_multiDroneInput.DroneMainXboxController.DownUp.performed += (a) => { m_xboxDrone.m_downUp = a.ReadValue<float>(); m_xboxDrone.m_downUpEvent.Invoke(m_xboxDrone.m_downUp); };
        m_multiDroneInput.DroneMainXboxController.DownUp.canceled += (a) => { m_xboxDrone.m_downUp = 0; m_xboxDrone.m_downUpEvent.Invoke(0); };

        m_multiDroneInput.DroneMainXboxController.RotateLeftRight.performed += (a) => { m_xboxDrone.m_leftRightRotation = a.ReadValue<float>(); m_xboxDrone.m_leftRightRotationEvent.Invoke(m_xboxDrone.m_leftRightRotation); };
        m_multiDroneInput.DroneMainXboxController.RotateLeftRight.canceled += (a) => { m_xboxDrone.m_leftRightRotation = 0; m_xboxDrone.m_leftRightRotationEvent.Invoke(0); };

        m_multiDroneInput.DroneNumPad.Enable();
        m_multiDroneInput.DroneNumPad.LeftRight.performed += (a) => { m_numpadDrone.m_leftRight = a.ReadValue<float>(); m_numpadDrone.m_leftRightEvent.Invoke(m_numpadDrone.m_leftRight); };
        m_multiDroneInput.DroneNumPad.LeftRight.canceled += (a) => { m_numpadDrone.m_leftRight = 0; m_numpadDrone.m_leftRightEvent.Invoke(0); };
        m_multiDroneInput.DroneNumPad.BackForward.performed += (a) => { m_numpadDrone.m_backFront = a.ReadValue<float>(); m_numpadDrone.m_backFrontEvent.Invoke(m_numpadDrone.m_backFront); };
        m_multiDroneInput.DroneNumPad.BackForward.canceled += (a) => { m_numpadDrone.m_backFront = 0; m_numpadDrone.m_backFrontEvent.Invoke(0); };
        m_multiDroneInput.DroneNumPad.DownUp.performed += (a) => { m_numpadDrone.m_downUp = a.ReadValue<float>(); m_numpadDrone.m_downUpEvent.Invoke(m_numpadDrone.m_downUp); };
        m_multiDroneInput.DroneNumPad.DownUp.canceled += (a) => { m_numpadDrone.m_downUp = 0; m_numpadDrone.m_downUpEvent.Invoke(0); };
        m_multiDroneInput.DroneNumPad.RotateLeftRight.performed += (a) => { m_numpadDrone.m_leftRightRotation = a.ReadValue<float>(); m_numpadDrone.m_leftRightRotationEvent.Invoke(m_numpadDrone.m_leftRightRotation); };
        m_multiDroneInput.DroneNumPad.RotateLeftRight.canceled += (a) => { m_numpadDrone.m_leftRightRotation = 0; m_numpadDrone.m_leftRightRotationEvent.Invoke(0); };

        m_multiDroneInput.DroneQuerty.Enable();
        m_multiDroneInput.DroneQuerty.LeftRight.performed += (a) => { m_keyboardDrone.m_leftRight = a.ReadValue<float>(); m_keyboardDrone.m_leftRightEvent.Invoke(m_keyboardDrone.m_leftRight); };
        m_multiDroneInput.DroneQuerty.LeftRight.canceled += (a) => { m_keyboardDrone.m_leftRight = 0; m_keyboardDrone.m_leftRightEvent.Invoke(0); };
        m_multiDroneInput.DroneQuerty.BackForward.performed += (a) => { m_keyboardDrone.m_backFront = a.ReadValue<float>(); m_keyboardDrone.m_backFrontEvent.Invoke(m_keyboardDrone.m_backFront); };
        m_multiDroneInput.DroneQuerty.BackForward.canceled += (a) => { m_keyboardDrone.m_backFront = 0; m_keyboardDrone.m_backFrontEvent.Invoke(0); };
        m_multiDroneInput.DroneQuerty.DownUp.performed += (a) => { m_keyboardDrone.m_downUp = a.ReadValue<float>(); m_keyboardDrone.m_downUpEvent.Invoke(m_keyboardDrone.m_downUp); };
        m_multiDroneInput.DroneQuerty.DownUp.canceled += (a) => { m_keyboardDrone.m_downUp = 0; m_keyboardDrone.m_downUpEvent.Invoke(0); };
        m_multiDroneInput.DroneQuerty.RotateLeftRight.performed += (a) => { m_keyboardDrone.m_leftRightRotation = a.ReadValue<float>(); m_keyboardDrone.m_leftRightRotationEvent.Invoke(m_keyboardDrone.m_leftRightRotation); };
        m_multiDroneInput.DroneQuerty.RotateLeftRight.canceled += (a) => { m_keyboardDrone.m_leftRightRotation = 0; m_keyboardDrone.m_leftRightRotationEvent.Invoke(0); };

        
        //udp
    }

}
