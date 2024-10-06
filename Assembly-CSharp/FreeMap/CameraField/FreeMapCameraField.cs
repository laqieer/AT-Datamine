// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.FreeMapCameraField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.CameraController;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField
{
  [Token(Token = "0x2001951")]
  public class FreeMapCameraField : MonoBehaviour
  {
    [Token(Token = "0x4006CC7")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapCameraFieldManager owner;
    [Token(Token = "0x4006CCA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private FreeMapCameraControllerBase cameraController;
    [Token(Token = "0x4006CCC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected int fieldPriority;
    [Token(Token = "0x4006CCD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BoxCollider cameraMoveCollider;
    [Token(Token = "0x4006CCE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BoxCollider playerMoveCollider;
    [Token(Token = "0x4006CCF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float audioListenerInterpolationRate;
    [Token(Token = "0x4006CD0")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Vector3 audioListenerPointOffset;

    [Token(Token = "0x1700172A")]
    public Camera LinkCamera
    {
      [Token(Token = "0x600903A"), Address(RVA = "0x4B17830", Offset = "0x4B17830", VA = "0x4B17830")] get
      {
        return (Camera) null;
      }
      [Token(Token = "0x600903B"), Address(RVA = "0x4B17838", Offset = "0x4B17838", VA = "0x4B17838")] private set
      {
      }
    }

    [Token(Token = "0x1700172B")]
    public FreeMapCameraControllerBase.RaycastHitHandler RaycastHitHandler
    {
      [Token(Token = "0x600903C"), Address(RVA = "0x4B17840", Offset = "0x4B17840", VA = "0x4B17840")] get
      {
        return (FreeMapCameraControllerBase.RaycastHitHandler) null;
      }
      [Token(Token = "0x600903D"), Address(RVA = "0x4B17848", Offset = "0x4B17848", VA = "0x4B17848")] private set
      {
      }
    }

    [Token(Token = "0x1700172C")]
    public FreeMapCameraControllerBase CameraController
    {
      [Token(Token = "0x600903E"), Address(RVA = "0x4B17850", Offset = "0x4B17850", VA = "0x4B17850")] get
      {
        return (FreeMapCameraControllerBase) null;
      }
    }

    [Token(Token = "0x1700172D")]
    public Transform TrackingTarget
    {
      [Token(Token = "0x600903F"), Address(RVA = "0x4B17858", Offset = "0x4B17858", VA = "0x4B17858")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6009040"), Address(RVA = "0x4B17860", Offset = "0x4B17860", VA = "0x4B17860")] private set
      {
      }
    }

    [Token(Token = "0x1700172E")]
    public int FieldPriority
    {
      [Token(Token = "0x6009041"), Address(RVA = "0x4B17868", Offset = "0x4B17868", VA = "0x4B17868")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700172F")]
    public BoxCollider CameraMoveCollider
    {
      [Token(Token = "0x6009042"), Address(RVA = "0x4B17870", Offset = "0x4B17870", VA = "0x4B17870")] get
      {
        return (BoxCollider) null;
      }
    }

    [Token(Token = "0x17001730")]
    public BoxCollider PlayerMoveCollider
    {
      [Token(Token = "0x6009043"), Address(RVA = "0x4B17878", Offset = "0x4B17878", VA = "0x4B17878")] get
      {
        return (BoxCollider) null;
      }
    }

    [Token(Token = "0x17001731")]
    public float AudioListenerInterpolationRate
    {
      [Token(Token = "0x6009044"), Address(RVA = "0x4B17880", Offset = "0x4B17880", VA = "0x4B17880")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001732")]
    public Vector3 AudioListenerPointOffset
    {
      [Token(Token = "0x6009045"), Address(RVA = "0x4B17888", Offset = "0x4B17888", VA = "0x4B17888")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17001733")]
    public Vector3 PlayerMoveFieldPosition
    {
      [Token(Token = "0x6009046"), Address(RVA = "0x4B17894", Offset = "0x4B17894", VA = "0x4B17894")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17001734")]
    public bool InThisField
    {
      [Token(Token = "0x6009047"), Address(RVA = "0x4B178FC", Offset = "0x4B178FC", VA = "0x4B178FC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009048"), Address(RVA = "0x4B17904", Offset = "0x4B17904", VA = "0x4B17904")] private set
      {
      }
    }

    [Token(Token = "0x6009049")]
    [Address(RVA = "0x4B17910", Offset = "0x4B17910", VA = "0x4B17910")]
    public void Initialize(
      FreeMapCameraFieldManager manager,
      Camera useCamera,
      Transform target,
      FreeMapCameraControllerBase.RaycastHitHandler handler)
    {
    }

    [Token(Token = "0x600904A")]
    [Address(RVA = "0x4B17A38", Offset = "0x4B17A38", VA = "0x4B17A38")]
    public void Initialize(FreeMapCameraField origin)
    {
    }

    [Token(Token = "0x600904B")]
    [Address(RVA = "0x4B17A5C", Offset = "0x4B17A5C", VA = "0x4B17A5C")]
    public void RegistCamera(Camera useCamera)
    {
    }

    [Token(Token = "0x600904C")]
    [Address(RVA = "0x4B17A78", Offset = "0x4B17A78", VA = "0x4B17A78")]
    public void UnRegisterCamera()
    {
    }

    [Token(Token = "0x600904D")]
    [Address(RVA = "0x4B17A94", Offset = "0x4B17A94", VA = "0x4B17A94")]
    public void CameraFieldBegin()
    {
    }

    [Token(Token = "0x600904E")]
    [Address(RVA = "0x4B17ADC", Offset = "0x4B17ADC", VA = "0x4B17ADC")]
    public void CameraFieldUpdate()
    {
    }

    [Token(Token = "0x600904F")]
    [Address(RVA = "0x4B17C48", Offset = "0x4B17C48", VA = "0x4B17C48")]
    public void CameraFieldEnd()
    {
    }

    [Token(Token = "0x6009050")]
    [Address(RVA = "0x4B17C64", Offset = "0x4B17C64", VA = "0x4B17C64")]
    public void CameraControllerUpdate(bool isClip = true)
    {
    }

    [Token(Token = "0x6009051")]
    [Address(RVA = "0x4B17CFC", Offset = "0x4B17CFC", VA = "0x4B17CFC")]
    public bool GetCameraNewPosition(
      Vector3 oldPosition,
      Vector3 newPosition,
      out Vector3 correctedPosition)
    {
      return new bool();
    }

    [Token(Token = "0x6009052")]
    [Address(RVA = "0x4B17AFC", Offset = "0x4B17AFC", VA = "0x4B17AFC")]
    public void ActiveField(bool enable)
    {
    }

    [Token(Token = "0x6009053")]
    [Address(RVA = "0x4B17B08", Offset = "0x4B17B08", VA = "0x4B17B08")]
    public bool FieldContains(Transform target) => new bool();

    [Token(Token = "0x6009054")]
    public void SetCameraController<T>(T cameraController) where T : FreeMapCameraControllerBase
    {
    }

    [Token(Token = "0x6009055")]
    [Address(RVA = "0x4B17D00", Offset = "0x4B17D00", VA = "0x4B17D00")]
    protected bool GetCameraNewPositionInternal(
      Vector3 oldPosition,
      Vector3 newPosition,
      out Vector3 corrected)
    {
      return new bool();
    }

    [Token(Token = "0x6009056")]
    [Address(RVA = "0x4B17E60", Offset = "0x4B17E60", VA = "0x4B17E60")]
    public FreeMapCameraField()
    {
    }
  }
}
