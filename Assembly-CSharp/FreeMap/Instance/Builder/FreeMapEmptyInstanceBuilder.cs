// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapEmptyInstanceBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001922")]
  public class FreeMapEmptyInstanceBuilder : FreeMapInstanceBuilderBase<FreeMapIconInstance>
  {
    [Token(Token = "0x4006C67")]
    private const string InstanceNamePrefix = "IconInstance";

    [Token(Token = "0x170016DB")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008ED8"), Address(RVA = "0x4B04348", Offset = "0x4B04348", VA = "0x4B04348", Slot = "11")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016DC")]
    protected override string LayerName
    {
      [Token(Token = "0x6008ED9"), Address(RVA = "0x4B043F8", Offset = "0x4B043F8", VA = "0x4B043F8", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6008EDA")]
    [Address(RVA = "0x4B04438", Offset = "0x4B04438", VA = "0x4B04438")]
    public FreeMapEmptyInstanceBuilder(
      int objectID,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008EDB")]
    [Address(RVA = "0x4B044D8", Offset = "0x4B044D8", VA = "0x4B044D8")]
    public FreeMapEmptyInstanceBuilder(
      InstanceID instanceID,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008EDC")]
    [Address(RVA = "0x4B04578", Offset = "0x4B04578", VA = "0x4B04578")]
    public static FreeMapEmptyInstanceBuilder Create(IFreeActionLayoutData layoutData)
    {
      return (FreeMapEmptyInstanceBuilder) null;
    }

    [Token(Token = "0x6008EDD")]
    [Address(RVA = "0x4B04630", Offset = "0x4B04630", VA = "0x4B04630")]
    public static FreeMapEmptyInstanceBuilder Create(
      IFreeActionLayoutData layoutData,
      IFreeActionObjectData objectData)
    {
      return (FreeMapEmptyInstanceBuilder) null;
    }
  }
}
