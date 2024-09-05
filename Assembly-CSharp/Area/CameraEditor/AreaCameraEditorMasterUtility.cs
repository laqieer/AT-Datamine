// Decompiled with JetBrains decompiler
// Type: Area.CameraEditor.AreaCameraEditorMasterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Area.CameraEditor
{
  [Token(Token = "0x2002857")]
  public static class AreaCameraEditorMasterUtility
  {
    [Token(Token = "0x600FE14")]
    [Address(RVA = "0x4433E84", Offset = "0x4433E84", VA = "0x4433E84")]
    public static IEnumerable<StoryFreeActionSettingData> GetSettingList()
    {
      return (IEnumerable<StoryFreeActionSettingData>) null;
    }

    [Token(Token = "0x600FE15")]
    [Address(RVA = "0x4433F04", Offset = "0x4433F04", VA = "0x4433F04")]
    public static IEnumerable<StoryFreeActionAreaSettingData> GetAreaSettingList(int settingID)
    {
      return (IEnumerable<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x600FE16")]
    [Address(RVA = "0x4434018", Offset = "0x4434018", VA = "0x4434018")]
    public static string GetAreaName(StoryFreeActionAreaSettingData data) => (string) null;

    [Token(Token = "0x600FE17")]
    [Address(RVA = "0x44340D0", Offset = "0x44340D0", VA = "0x44340D0")]
    public static IEnumerable<StoryFreeActionCameraViewPositionData> GetCameraViewList()
    {
      return (IEnumerable<StoryFreeActionCameraViewPositionData>) null;
    }

    [Token(Token = "0x600FE18")]
    [Address(RVA = "0x4434150", Offset = "0x4434150", VA = "0x4434150")]
    public static IEnumerable<StoryFreeActionPlayerMovePositionData> GetPlayerMovePositionList()
    {
      return (IEnumerable<StoryFreeActionPlayerMovePositionData>) null;
    }

    [Token(Token = "0x600FE19")]
    [Address(RVA = "0x44341D0", Offset = "0x44341D0", VA = "0x44341D0")]
    public static string CameraPosRefToString(CameraViewPositionReferenceEnum name)
    {
      return (string) null;
    }

    [Token(Token = "0x600FE1A")]
    [Address(RVA = "0x4434258", Offset = "0x4434258", VA = "0x4434258")]
    public static string GetInstanceName(FreeMapInstance instance) => (string) null;

    [Token(Token = "0x600FE1B")]
    [Address(RVA = "0x4434364", Offset = "0x4434364", VA = "0x4434364")]
    public static bool TryGetEventSetting(
      FreeMapInstance instance,
      out List<string> settings,
      out int cameraPositionID,
      out int movePositionID)
    {
      return new bool();
    }

    [Token(Token = "0x600FE1C")]
    [Address(RVA = "0x4434474", Offset = "0x4434474", VA = "0x4434474")]
    private static void GetObjectInstanceEventSetting(
      int objectID,
      ref List<string> settings,
      ref int cameraPositionID,
      ref int movePositionID)
    {
    }

    [Token(Token = "0x600FE1D")]
    [Address(RVA = "0x4434E18", Offset = "0x4434E18", VA = "0x4434E18")]
    private static void GetRewardInstanceEventList(
      int layoutID,
      ref List<string> settings,
      ref int movePositionID)
    {
    }
  }
}
