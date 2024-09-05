// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.FreeMapPlacement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Placement
{
  [Token(Token = "0x2001856")]
  public class FreeMapPlacement : MonoBehaviour
  {
    [Token(Token = "0x4006A13")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform anchorParent;
    [Token(Token = "0x4006A14")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform clipRangeParent;
    [Token(Token = "0x4006A15")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<FreeMapPlacementAnchor> listPlacementAnchors;
    [Token(Token = "0x4006A16")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<BoxCollider> clipRangeList;

    [Token(Token = "0x170015B4")]
    public Transform AnchorParent
    {
      [Token(Token = "0x6008991"), Address(RVA = "0x43E5F14", Offset = "0x43E5F14", VA = "0x43E5F14")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170015B5")]
    public Transform ClipRangeParent
    {
      [Token(Token = "0x6008992"), Address(RVA = "0x43E5F94", Offset = "0x43E5F94", VA = "0x43E5F94")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170015B6")]
    public List<FreeMapPlacementAnchor> ListPlacementAnchors
    {
      [Token(Token = "0x6008993"), Address(RVA = "0x43E6014", Offset = "0x43E6014", VA = "0x43E6014")] get
      {
        return (List<FreeMapPlacementAnchor>) null;
      }
    }

    [Token(Token = "0x170015B7")]
    public List<BoxCollider> ClipRangeList
    {
      [Token(Token = "0x6008994"), Address(RVA = "0x43E601C", Offset = "0x43E601C", VA = "0x43E601C")] get
      {
        return (List<BoxCollider>) null;
      }
    }

    [Token(Token = "0x6008995")]
    [Address(RVA = "0x43E6024", Offset = "0x43E6024", VA = "0x43E6024")]
    public FreeMapPlacementAnchor GetPlacementAnchor(string locationName)
    {
      return (FreeMapPlacementAnchor) null;
    }

    [Token(Token = "0x6008996")]
    [Address(RVA = "0x43E6108", Offset = "0x43E6108", VA = "0x43E6108")]
    public void OverwritePlacementAnchorList(FreeMapPlacementAnchor[] array)
    {
    }

    [Token(Token = "0x6008997")]
    [Address(RVA = "0x43E618C", Offset = "0x43E618C", VA = "0x43E618C")]
    public void AddPlacementAnchor(FreeMapPlacementAnchor anchor)
    {
    }

    [Token(Token = "0x6008998")]
    [Address(RVA = "0x43E627C", Offset = "0x43E627C", VA = "0x43E627C")]
    public void AddRangeCollider(BoxCollider collider)
    {
    }

    [Token(Token = "0x6008999")]
    [Address(RVA = "0x43E636C", Offset = "0x43E636C", VA = "0x43E636C")]
    public FreeMapPlacement()
    {
    }
  }
}
