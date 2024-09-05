// Decompiled with JetBrains decompiler
// Type: StoryCharacterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20002B9")]
public static class StoryCharacterUtility
{
  [Token(Token = "0x60010FB")]
  [Address(RVA = "0x1BEBE08", Offset = "0x1BEBE08", VA = "0x1BEBE08")]
  public static StoryCharacterUtility.LoadResouceData CreateLoadReouceData(
    FreeMapAreaSituationData? areaParam,
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum lookAssignType,
    StoryCharacterLookWeatherTypeEnum lookWeatherType)
  {
    return new StoryCharacterUtility.LoadResouceData();
  }

  [Token(Token = "0x60010FC")]
  [Address(RVA = "0x1BEC61C", Offset = "0x1BEC61C", VA = "0x1BEC61C")]
  public static StoryCharacterUtility.LoadResouceData CreateLoadResourceDataByStyleID(int styleID)
  {
    return new StoryCharacterUtility.LoadResouceData();
  }

  [Token(Token = "0x60010FD")]
  [Address(RVA = "0x1BEC6AC", Offset = "0x1BEC6AC", VA = "0x1BEC6AC")]
  public static PropSettingData[] GetCharacterProps(
    FreeMapAreaSituationData? areaParam,
    int characterSwitchPatternID,
    StoryCharacterLookAssignTypeEnum lookAssignType,
    StoryCharacterLookWeatherTypeEnum lookWeatherType)
  {
    return (PropSettingData[]) null;
  }

  [Token(Token = "0x60010FE")]
  [Address(RVA = "0x1BEC7E0", Offset = "0x1BEC7E0", VA = "0x1BEC7E0")]
  public static StoryCharacterSwitchingPatternData GetPatternData(int characterSwitchPatternId)
  {
    return (StoryCharacterSwitchingPatternData) null;
  }

  [Token(Token = "0x60010FF")]
  [Address(RVA = "0x1BEC8B0", Offset = "0x1BEC8B0", VA = "0x1BEC8B0")]
  public static StoryCharacterLookWeatherTypeEnum GetWeatherType()
  {
    return new StoryCharacterLookWeatherTypeEnum();
  }

  [Token(Token = "0x6001100")]
  [Address(RVA = "0x1BEC868", Offset = "0x1BEC868", VA = "0x1BEC868")]
  private static int GetCahracterBuildId(
    StoryCharacterSwitchingPatternData patternData,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return new int();
  }

  [Token(Token = "0x6001101")]
  [Address(RVA = "0x1BECA6C", Offset = "0x1BECA6C", VA = "0x1BECA6C")]
  public static string GetName(int characterSwitchPatternId) => (string) null;

  [Token(Token = "0x6001102")]
  [Address(RVA = "0x1BECB6C", Offset = "0x1BECB6C", VA = "0x1BECB6C")]
  public static string GetNameByCharacterID(int characterId) => (string) null;

  [Token(Token = "0x6001103")]
  [Address(RVA = "0x1BECC14", Offset = "0x1BECC14", VA = "0x1BECC14")]
  public static string GetThumnailAssetbundleName(int characterSwitchPatternId) => (string) null;

  [Token(Token = "0x6001104")]
  [Address(RVA = "0x1BECCAC", Offset = "0x1BECCAC", VA = "0x1BECCAC")]
  public static string GetThumAssetName(int characterSwitchPatternId) => (string) null;

  [Token(Token = "0x6001105")]
  [Address(RVA = "0x1BEC168", Offset = "0x1BEC168", VA = "0x1BEC168")]
  public static string Get3DModelAssetName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x6001106")]
  [Address(RVA = "0x1BEC07C", Offset = "0x1BEC07C", VA = "0x1BEC07C")]
  public static string Get3DModelAssetBundleName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x6001107")]
  [Address(RVA = "0x1BEC254", Offset = "0x1BEC254", VA = "0x1BEC254")]
  public static string GetFreeMapControllerAssetBundleName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x6001108")]
  [Address(RVA = "0x1BEC344", Offset = "0x1BEC344", VA = "0x1BEC344")]
  public static string GetFreeMapControllerAssetName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x6001109")]
  [Address(RVA = "0x1BEC434", Offset = "0x1BEC434", VA = "0x1BEC434")]
  public static string GetFreeMapAnimClipPackAssetBundleName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x600110A")]
  [Address(RVA = "0x1BEC528", Offset = "0x1BEC528", VA = "0x1BEC528")]
  public static string GetFreeMapAnimClipPackAssetName(
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum assignType,
    StoryCharacterLookWeatherTypeEnum weatherType,
    bool IsInDoor)
  {
    return (string) null;
  }

  [Token(Token = "0x600110B")]
  [Address(RVA = "0x1BEBF48", Offset = "0x1BEBF48", VA = "0x1BEBF48")]
  public static List<int> CreateStorySequenceList() => (List<int>) null;

  [Token(Token = "0x600110C")]
  [Address(RVA = "0x1BECCCC", Offset = "0x1BECCCC", VA = "0x1BECCCC")]
  public static float GetCharacterHeight(
    FreeMapAreaSituationData? areaParam,
    int characterSwitchPatternId,
    StoryCharacterLookAssignTypeEnum lookAssignTyper,
    StoryCharacterLookWeatherTypeEnum lookweatherType)
  {
    return new float();
  }

  [Token(Token = "0x20002BA")]
  public struct LoadResouceData
  {
    [Token(Token = "0x4000FFB")]
    [FieldOffset(Offset = "0x0")]
    public string ModelAssetBundleName;
    [Token(Token = "0x4000FFC")]
    [FieldOffset(Offset = "0x8")]
    public string ModelAssetName;
    [Token(Token = "0x4000FFD")]
    [FieldOffset(Offset = "0x10")]
    public string AnimconAssetBundleName;
    [Token(Token = "0x4000FFE")]
    [FieldOffset(Offset = "0x18")]
    public string AnimconAssetName;
    [Token(Token = "0x4000FFF")]
    [FieldOffset(Offset = "0x20")]
    public string AnimClipPackAssetBundleName;
    [Token(Token = "0x4001000")]
    [FieldOffset(Offset = "0x28")]
    public string AnimClipPackAssetName;
  }
}
