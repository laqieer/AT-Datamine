// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2FollowUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DF6")]
  [ExecuteInEditMode]
  public class Adv2FollowUI : MonoBehaviour
  {
    [Token(Token = "0x4010F8B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Adv2Object followObject;
    [Token(Token = "0x4010F8C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected bool updateFollowPosition;

    [Token(Token = "0x1700510F")]
    public Canvas TargetCanvas
    {
      [Token(Token = "0x6018E98"), Address(RVA = "0x2CA9C98", Offset = "0x2CA9C98", VA = "0x2CA9C98")] private get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6018E99"), Address(RVA = "0x2CA9CA0", Offset = "0x2CA9CA0", VA = "0x2CA9CA0")] set
      {
      }
    }

    [Token(Token = "0x17005110")]
    public bool UpdateFollowPosition
    {
      [Token(Token = "0x6018E9A"), Address(RVA = "0x2CA9CA8", Offset = "0x2CA9CA8", VA = "0x2CA9CA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018E9B"), Address(RVA = "0x2CA9CB0", Offset = "0x2CA9CB0", VA = "0x2CA9CB0")] set
      {
      }
    }

    [Token(Token = "0x6018E9C")]
    [Address(RVA = "0x2CA9DC4", Offset = "0x2CA9DC4", VA = "0x2CA9DC4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6018E9D")]
    [Address(RVA = "0x2CA9E04", Offset = "0x2CA9E04", VA = "0x2CA9E04")]
    private void OnCameraUpdated(CinemachineBrain brain)
    {
    }

    [Token(Token = "0x6018E9E")]
    [Address(RVA = "0x2CAA084", Offset = "0x2CAA084", VA = "0x2CAA084")]
    public void SetFollowObject(Adv2Object followObject, bool updateFollowPosition)
    {
    }

    [Token(Token = "0x6018E9F")]
    [Address(RVA = "0x2CA9DE4", Offset = "0x2CA9DE4", VA = "0x2CA9DE4")]
    public void FollowPosition()
    {
    }

    [Token(Token = "0x6018EA0")]
    [Address(RVA = "0x2CA9E40", Offset = "0x2CA9E40", VA = "0x2CA9E40")]
    public void FollowPosition(Camera camera)
    {
    }

    [Token(Token = "0x6018EA1")]
    [Address(RVA = "0x2CAA094", Offset = "0x2CAA094", VA = "0x2CAA094")]
    public Adv2FollowUI()
    {
    }
  }
}
