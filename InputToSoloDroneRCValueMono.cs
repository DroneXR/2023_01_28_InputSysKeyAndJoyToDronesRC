using Eloi;
using LocalDroneInputSpace;
using SoloDroneInputSpace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputToSoloDroneRCValueMono : MonoBehaviour
{

    public SoloDroneInputUtility m_SoloDroneInput;
    public float m_leftRight;
    public float m_backFront;
    public float m_downUp;
    public float m_leftRightRotation;

    public PrimitiveUnityEvent_Float m_leftRightEvent;
    public PrimitiveUnityEvent_Float m_backFrontEvent;
    public PrimitiveUnityEvent_Float m_downUpEvent;
    public PrimitiveUnityEvent_Float m_leftRightRotationEvent;

    public void Start()
    {
        m_SoloDroneInput = new SoloDroneInputUtility();
        m_SoloDroneInput.Enable();
        m_SoloDroneInput.SoloDroneInput.Enable();

        m_SoloDroneInput.SoloDroneInput.LeftRight.performed += (a) => { m_leftRight = a.ReadValue<float>(); m_leftRightEvent.Invoke(m_leftRight); };
        m_SoloDroneInput.SoloDroneInput.LeftRight.canceled += (a) => { m_leftRight = 0; m_leftRightEvent.Invoke(0); };

        m_SoloDroneInput.SoloDroneInput.BackForward.performed += (a) => { m_backFront = a.ReadValue<float>(); m_backFrontEvent.Invoke(m_backFront); };
        m_SoloDroneInput.SoloDroneInput.BackForward.canceled += (a) => { m_backFront = 0; m_backFrontEvent.Invoke(0); };

        m_SoloDroneInput.SoloDroneInput.DownUp.performed += (a) => { m_downUp = a.ReadValue<float>(); m_downUpEvent.Invoke(m_downUp); };
        m_SoloDroneInput.SoloDroneInput.DownUp.canceled += (a) => { m_downUp = 0; m_downUpEvent.Invoke(0); };

        m_SoloDroneInput.SoloDroneInput.RotateLeftRight.performed += (a) => { m_leftRightRotation = a.ReadValue<float>(); m_leftRightRotationEvent.Invoke(m_leftRightRotation); };
        m_SoloDroneInput.SoloDroneInput.RotateLeftRight.canceled += (a) => { m_leftRightRotation = 0; m_leftRightRotationEvent.Invoke(0); };


        //udp
    }

}
