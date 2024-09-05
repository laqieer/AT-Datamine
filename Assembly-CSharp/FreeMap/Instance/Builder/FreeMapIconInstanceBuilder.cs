// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapIconInstanceBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001923")]
  [Obsolete("UIは配置オブジェクトインスタンスとして管理しないとのこと。詳細は@maruyamaまで")]
  public class FreeMapIconInstanceBuilder : FreeMapInstanceBuilderBase<FreeMapIconInstance>
  {
    [Token(Token = "0x4006C68")]
    private const string InstanceNamePrefix = "IconInstance";

    [Token(Token = "0x170016DD")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008EDE"), Address(RVA = "0x4B048E8", Offset = "0x4B048E8", VA = "0x4B048E8", Slot = "11")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016DE")]
    protected override string LayerName
    {
      [Token(Token = "0x6008EDF"), Address(RVA = "0x4B04998", Offset = "0x4B04998", VA = "0x4B04998", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6008EE0")]
    [Address(RVA = "0x4B049D8", Offset = "0x4B049D8", VA = "0x4B049D8")]
    public FreeMapIconInstanceBuilder(
      int objectID,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008EE1")]
    [Address(RVA = "0x4B04A78", Offset = "0x4B04A78", VA = "0x4B04A78")]
    public static FreeMapIconInstanceBuilder Create(StoryFreeActionLayoutData layoutData)
    {
      return (FreeMapIconInstanceBuilder) null;
    }

    [Token(Token = "0x6008EE2")]
    [Address(RVA = "0x4B04B34", Offset = "0x4B04B34", VA = "0x4B04B34")]
    public static FreeMapIconInstanceBuilder Create(
      StoryFreeActionLayoutData layoutData,
      StoryFreeActionObjectData objectData)
    {
      return (FreeMapIconInstanceBuilder) null;
    }
  }
}
