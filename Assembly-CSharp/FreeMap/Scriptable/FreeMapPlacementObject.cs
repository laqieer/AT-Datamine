// Decompiled with JetBrains decompiler
// Type: FreeMap.Scriptable.FreeMapPlacementObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Common.Attribute;
using FreeMap.Placement;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

#nullable disable
namespace FreeMap.Scriptable
{
  [Token(Token = "0x2001849")]
  public class FreeMapPlacementObject : ScriptableObject
  {
    [Token(Token = "0x40069E9")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, FreeMapPlacementObject.AnchorData> anchorMap;
    [Token(Token = "0x40069EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FreeMapPlacementObject.AnchorData[] checkAnchorDatas;
    [Token(Token = "0x40069EB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RangeClipScriptableData[] checkRangeClipDataList;
    [Token(Token = "0x40069EC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<FreeMapPlacementObject.AffiliationClipRangeData> affiliationDataList;

    [Token(Token = "0x600895D")]
    [Address(RVA = "0x43E4200", Offset = "0x43E4200", VA = "0x43E4200")]
    [Conditional("UNITY_EDITOR")]
    public void SetAnchors(FreeMapPlacementAnchor[] placementAnchors, BoxCollider[] boxColliders)
    {
    }

    [Token(Token = "0x600895E")]
    [Address(RVA = "0x43D0A78", Offset = "0x43D0A78", VA = "0x43D0A78")]
    public FreeMapPlacementObject.AnchorData GetAnchorData(string targetName)
    {
      return (FreeMapPlacementObject.AnchorData) null;
    }

    [Token(Token = "0x600895F")]
    [Address(RVA = "0x43E4844", Offset = "0x43E4844", VA = "0x43E4844")]
    public FreeMapPlacementObject.AnchorData[] GetAllAnchorData()
    {
      return (FreeMapPlacementObject.AnchorData[]) null;
    }

    [Token(Token = "0x6008960")]
    [Address(RVA = "0x43E484C", Offset = "0x43E484C", VA = "0x43E484C")]
    public int GetAffiliationClipRangeIndex(string anchorName) => new int();

    [Token(Token = "0x6008961")]
    [Address(RVA = "0x43E49A8", Offset = "0x43E49A8", VA = "0x43E49A8")]
    public bool TryGetAllRangeClipData(out RangeClipScriptableData[] result) => new bool();

    [Token(Token = "0x6008962")]
    [Address(RVA = "0x43E4A20", Offset = "0x43E4A20", VA = "0x43E4A20")]
    public FreeMapPlacementObject()
    {
    }

    [Token(Token = "0x200184A")]
    [Serializable]
    public class AnchorData
    {
      [Token(Token = "0x40069ED")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      [Disable]
      private string targetName;
      [Token(Token = "0x40069EE")]
      [FieldOffset(Offset = "0x18")]
      [Disable]
      [SerializeField]
      private Vector3 position;
      [Token(Token = "0x40069EF")]
      [FieldOffset(Offset = "0x24")]
      [SerializeField]
      [Disable]
      private Vector3 eulerAngles;

      [Token(Token = "0x170015A9")]
      public string TargetName
      {
        [Token(Token = "0x6008963"), Address(RVA = "0x43E4A9C", Offset = "0x43E4A9C", VA = "0x43E4A9C")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170015AA")]
      public Vector3 Position
      {
        [Token(Token = "0x6008964"), Address(RVA = "0x43E4AA4", Offset = "0x43E4AA4", VA = "0x43E4AA4")] get
        {
          return new Vector3();
        }
      }

      [Token(Token = "0x170015AB")]
      public Vector3 EulerAngles
      {
        [Token(Token = "0x6008965"), Address(RVA = "0x43E4AB0", Offset = "0x43E4AB0", VA = "0x43E4AB0")] get
        {
          return new Vector3();
        }
      }

      [Token(Token = "0x6008966")]
      [Address(RVA = "0x43E4ABC", Offset = "0x43E4ABC", VA = "0x43E4ABC")]
      public AnchorData(string targetName)
      {
      }

      [Token(Token = "0x6008967")]
      [Address(RVA = "0x43E4590", Offset = "0x43E4590", VA = "0x43E4590")]
      public AnchorData(string targetName, FreeMapPlacementAnchor placementAnchor)
      {
      }

      [Token(Token = "0x6008968")]
      [Address(RVA = "0x43E4B7C", Offset = "0x43E4B7C", VA = "0x43E4B7C")]
      public AnchorData(string targetName, Vector3 position, Vector3 eulerAngle)
      {
      }
    }

    [Token(Token = "0x200184B")]
    [Serializable]
    public class AffiliationClipRangeData
    {
      [Token(Token = "0x40069F0")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      [Disable]
      private int anchorDataIndex;
      [Token(Token = "0x40069F1")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      [Disable]
      private int clipRangeDataIndex;

      [Token(Token = "0x170015AC")]
      public int AnchorDataIndex
      {
        [Token(Token = "0x6008969"), Address(RVA = "0x43E4C78", Offset = "0x43E4C78", VA = "0x43E4C78")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170015AD")]
      public int ClipRangeDataIndex
      {
        [Token(Token = "0x600896A"), Address(RVA = "0x43E4C80", Offset = "0x43E4C80", VA = "0x43E4C80")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600896B")]
      [Address(RVA = "0x43E46C0", Offset = "0x43E46C0", VA = "0x43E46C0")]
      public AffiliationClipRangeData(int anchorIndex, int rangeIndex)
      {
      }
    }
  }
}
