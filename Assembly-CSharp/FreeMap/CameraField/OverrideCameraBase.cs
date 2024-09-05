// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.OverrideCameraBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField.CameraController;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField
{
  [Token(Token = "0x2001954")]
  public abstract class OverrideCameraBase : MonoBehaviour
  {
    [Token(Token = "0x4006CDE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected float changeDuration;
    [Token(Token = "0x4006CDF")]
    [FieldOffset(Offset = "0x1C")]
    protected float changeTime;
    [Token(Token = "0x4006CE0")]
    [FieldOffset(Offset = "0x20")]
    protected Coroutine changeCoroutine;

    [Token(Token = "0x17001736")]
    public bool IsChanging
    {
      [Token(Token = "0x6009065"), Address(RVA = "0x4B18E4C", Offset = "0x4B18E4C", VA = "0x4B18E4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009066")]
    public abstract void SetTargetTransform(Transform target);

    [Token(Token = "0x6009067")]
    public abstract void ChangeCamera(FreeMapCameraControllerBase target);

    [Token(Token = "0x6009068")]
    public abstract void RevertCamera(FreeMapCameraControllerBase target);

    [Token(Token = "0x6009069")]
    [Address(RVA = "0x4B18E5C", Offset = "0x4B18E5C", VA = "0x4B18E5C")]
    protected bool CheckChangeFinished() => new bool();

    [Token(Token = "0x600906A")]
    [Address(RVA = "0x4B18E6C", Offset = "0x4B18E6C", VA = "0x4B18E6C")]
    public OverrideCameraBase Duplicate() => (OverrideCameraBase) null;

    [Token(Token = "0x600906B")]
    [Address(RVA = "0x4B18FE8", Offset = "0x4B18FE8", VA = "0x4B18FE8")]
    public void SetChangeDurationTime(float time)
    {
    }

    [Token(Token = "0x600906C")]
    [Address(RVA = "0x4B18FF0", Offset = "0x4B18FF0", VA = "0x4B18FF0")]
    protected OverrideCameraBase()
    {
    }
  }
}
