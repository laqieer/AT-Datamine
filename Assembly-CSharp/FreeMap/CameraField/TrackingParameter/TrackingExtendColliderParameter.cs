// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.TrackingParameter.TrackingExtendColliderParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.TrackingParameter
{
  [Token(Token = "0x200195A")]
  [Serializable]
  public class TrackingExtendColliderParameter
  {
    [Token(Token = "0x4006CFD")]
    public const string DefaultColliderName = "TrackingExtendCollider";
    [Token(Token = "0x4006CFE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<BoxCollider> cameraMoveColliderList;
    [Token(Token = "0x4006CFF")]
    [FieldOffset(Offset = "0x18")]
    private BoxCollider defaultBoxCollider;
    [Token(Token = "0x4006D00")]
    [FieldOffset(Offset = "0x20")]
    private BoxCollider currentBoxCollider;
    [Token(Token = "0x4006D01")]
    [FieldOffset(Offset = "0x28")]
    private BoxCollider previousBoxCollider;
    [Token(Token = "0x4006D02")]
    [FieldOffset(Offset = "0x30")]
    private float time;
    [Token(Token = "0x4006D03")]
    private const float maxTime = 0.1f;

    [Token(Token = "0x17001743")]
    public IReadOnlyList<BoxCollider> ColliderList
    {
      [Token(Token = "0x6009092"), Address(RVA = "0x4D042F0", Offset = "0x4D042F0", VA = "0x4D042F0")] get
      {
        return (IReadOnlyList<BoxCollider>) null;
      }
    }

    [Token(Token = "0x17001744")]
    public bool IsExtendActive
    {
      [Token(Token = "0x6009093"), Address(RVA = "0x4D042F8", Offset = "0x4D042F8", VA = "0x4D042F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009094")]
    [Address(RVA = "0x4D04348", Offset = "0x4D04348", VA = "0x4D04348")]
    public void AddBoxCollider(BoxCollider collider)
    {
    }

    [Token(Token = "0x6009095")]
    [Address(RVA = "0x4D043F0", Offset = "0x4D043F0", VA = "0x4D043F0")]
    public void AddDefaultBoxCollider(BoxCollider collider)
    {
    }

    [Token(Token = "0x6009096")]
    [Address(RVA = "0x4D043F8", Offset = "0x4D043F8", VA = "0x4D043F8")]
    public bool Ajustment(Vector3 targetPos, out Vector3 resultPos) => new bool();

    [Token(Token = "0x6009097")]
    [Address(RVA = "0x4D04900", Offset = "0x4D04900", VA = "0x4D04900")]
    protected void CalcClosestDistance(
      BoxCollider collider,
      Vector3 targetPos,
      ref BoxCollider near,
      ref float distance,
      ref Vector3 nearClosest)
    {
    }

    [Token(Token = "0x6009098")]
    [Address(RVA = "0x4D047B0", Offset = "0x4D047B0", VA = "0x4D047B0")]
    protected Vector3 LerpMove(Vector3 pos) => new Vector3();

    [Token(Token = "0x6009099")]
    [Address(RVA = "0x4D04894", Offset = "0x4D04894", VA = "0x4D04894")]
    protected bool Contains(BoxCollider collider, Vector3 pos) => new bool();

    [Token(Token = "0x600909A")]
    [Address(RVA = "0x4D04A44", Offset = "0x4D04A44", VA = "0x4D04A44")]
    public TrackingExtendColliderParameter()
    {
    }
  }
}
