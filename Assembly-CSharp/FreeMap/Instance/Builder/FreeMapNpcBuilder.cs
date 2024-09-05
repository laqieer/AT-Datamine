// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapNpcBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001926")]
  public class FreeMapNpcBuilder : FreeMapCharacterBuilder<FreeMapCharacter>
  {
    [Token(Token = "0x170016E9")]
    private Vector3 IconBasePosition
    {
      [Token(Token = "0x6008EFD"), Address(RVA = "0x4B04F10", Offset = "0x4B04F10", VA = "0x4B04F10")] set
      {
      }
      [Token(Token = "0x6008EFE"), Address(RVA = "0x4B04F1C", Offset = "0x4B04F1C", VA = "0x4B04F1C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6008EFF")]
    [Address(RVA = "0x4B04F28", Offset = "0x4B04F28", VA = "0x4B04F28")]
    public FreeMapNpcBuilder(
      int objectID,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      string startAnimationName,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData,
      PropSettingData[] propData,
      Vector3 iconBasePosition,
      InstanceType instanceType)
    {
    }

    [Token(Token = "0x6008F00")]
    [Address(RVA = "0x4B0504C", Offset = "0x4B0504C", VA = "0x4B0504C", Slot = "15")]
    protected override void BuildInternal(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008F01")]
    [Address(RVA = "0x4B050F8", Offset = "0x4B050F8", VA = "0x4B050F8")]
    public static FreeMapNpcBuilder Create(
      FreeMapAreaSituationData? areaParam,
      IFreeActionLayoutData layoutData,
      IFreeActionObjectData objectData,
      InstanceType instanceType,
      StoryCharacterLookWeatherTypeEnum lookWeatherType)
    {
      return (FreeMapNpcBuilder) null;
    }
  }
}
