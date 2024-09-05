// Decompiled with JetBrains decompiler
// Type: EEClientLibraries.CameraControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace EEClientLibraries
{
  [Token(Token = "0x2000367")]
  public class CameraControl : MonoBehaviour
  {
    [Token(Token = "0x4001407")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float defaultCameraDistanceValue;
    [Token(Token = "0x4001408")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float defaultCameraMoveValue;
    [Token(Token = "0x4001409")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float defaultCameraRotateValue;
    [Token(Token = "0x400140A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private float minRotationX;
    [Token(Token = "0x400140B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float maxRotationX;
    [Token(Token = "0x400140C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float minDistance;
    [Token(Token = "0x400140D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float maxDistance;
    [Token(Token = "0x400140E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private float dumpingRatio;
    [Token(Token = "0x400140F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Vector3 rangeMove;
    [Token(Token = "0x4001410")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform cameraTargetTransform;
    [Token(Token = "0x4001411")]
    [FieldOffset(Offset = "0x50")]
    private CameraInputBase cameraInput;
    [Token(Token = "0x4001412")]
    [FieldOffset(Offset = "0x58")]
    private Camera targetCamera;
    [Token(Token = "0x4001413")]
    [FieldOffset(Offset = "0x60")]
    private float cameraDistanceRatio;
    [Token(Token = "0x4001414")]
    [FieldOffset(Offset = "0x64")]
    private float cameraRotateRatio;
    [Token(Token = "0x4001415")]
    [FieldOffset(Offset = "0x68")]
    private float cameraMoveRatio;
    [Token(Token = "0x4001416")]
    [FieldOffset(Offset = "0x6C")]
    private Vector3 currentTargetOffset;
    [Token(Token = "0x4001417")]
    [FieldOffset(Offset = "0x78")]
    private Vector3 currentTargetRotation;
    [Token(Token = "0x4001418")]
    [FieldOffset(Offset = "0x84")]
    private float currentTargetDistance;

    [Token(Token = "0x170001EA")]
    public Vector3 TargetOffset
    {
      [Token(Token = "0x600138A"), Address(RVA = "0x286BFD4", Offset = "0x286BFD4", VA = "0x286BFD4")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170001EB")]
    public Vector3 TargetRotation
    {
      [Token(Token = "0x600138B"), Address(RVA = "0x286BFE0", Offset = "0x286BFE0", VA = "0x286BFE0")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170001EC")]
    public float TargetDistance
    {
      [Token(Token = "0x600138C"), Address(RVA = "0x286BFEC", Offset = "0x286BFEC", VA = "0x286BFEC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600138D")]
    [Address(RVA = "0x286BFF4", Offset = "0x286BFF4", VA = "0x286BFF4")]
    public void Awake()
    {
    }

    [Token(Token = "0x600138E")]
    [Address(RVA = "0x286C134", Offset = "0x286C134", VA = "0x286C134")]
    public void Initialize(Transform target, CameraInputBase cameraInput, bool isReset = true)
    {
    }

    [Token(Token = "0x600138F")]
    [Address(RVA = "0x286C2EC", Offset = "0x286C2EC", VA = "0x286C2EC")]
    public void ForceUpdate()
    {
    }

    [Token(Token = "0x6001390")]
    [Address(RVA = "0x286C2D8", Offset = "0x286C2D8", VA = "0x286C2D8")]
    public void SetParameter(Vector3 defPosition, Vector3 defRotation, float defDistance)
    {
    }

    [Token(Token = "0x6001391")]
    [Address(RVA = "0x286C334", Offset = "0x286C334", VA = "0x286C334")]
    private void OnApplicationPause(bool isPause)
    {
    }

    [Token(Token = "0x6001392")]
    [Address(RVA = "0x286C3C4", Offset = "0x286C3C4", VA = "0x286C3C4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6001393")]
    [Address(RVA = "0x286C2F0", Offset = "0x286C2F0", VA = "0x286C2F0")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6001394")]
    [Address(RVA = "0x286C448", Offset = "0x286C448", VA = "0x286C448")]
    private void UpdateCameraTransform()
    {
    }

    [Token(Token = "0x6001395")]
    [Address(RVA = "0x286C628", Offset = "0x286C628", VA = "0x286C628")]
    private void UpdateCameraRotate()
    {
    }

    [Token(Token = "0x6001396")]
    [Address(RVA = "0x286C678", Offset = "0x286C678", VA = "0x286C678")]
    private void UpdateCameraTargetDistance()
    {
    }

    [Token(Token = "0x6001397")]
    [Address(RVA = "0x286C20C", Offset = "0x286C20C", VA = "0x286C20C")]
    public void AdjustInputValue(int width, int height)
    {
    }

    [Token(Token = "0x6001398")]
    [Address(RVA = "0x286C3E0", Offset = "0x286C3E0", VA = "0x286C3E0")]
    private bool IsTouchUI() => new bool();

    [Token(Token = "0x6001399")]
    [Address(RVA = "0x286C6CC", Offset = "0x286C6CC", VA = "0x286C6CC")]
    public CameraControl()
    {
    }
  }
}
