// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.FreeMapDataTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x2001935")]
  public static class FreeMapDataTable
  {
    [Token(Token = "0x6008F67")]
    [Address(RVA = "0x4B08DFC", Offset = "0x4B08DFC", VA = "0x4B08DFC")]
    public static StoryFreeActionSettingData SettingData(int settingID)
    {
      return (StoryFreeActionSettingData) null;
    }

    [Token(Token = "0x6008F68")]
    [Address(RVA = "0x4B08E98", Offset = "0x4B08E98", VA = "0x4B08E98")]
    public static StoryFreeActionPlayerData PlayerData(int playerID)
    {
      return (StoryFreeActionPlayerData) null;
    }

    [Token(Token = "0x6008F69")]
    [Address(RVA = "0x4B08F34", Offset = "0x4B08F34", VA = "0x4B08F34")]
    public static StoryFreeActionLayoutData LayoutData(int layoutID)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x6008F6A")]
    [Address(RVA = "0x4B08FD0", Offset = "0x4B08FD0", VA = "0x4B08FD0")]
    public static bool TryGetSubquestLayoutID(
      int objectID,
      int sequenceID,
      int subquestID,
      out int layoutID)
    {
      return new bool();
    }

    [Token(Token = "0x6008F6B")]
    [Address(RVA = "0x4B094E4", Offset = "0x4B094E4", VA = "0x4B094E4")]
    public static bool TryGetEventQuestLayoutID(
      int objectID,
      int sequenceID,
      int eventQuestID,
      out int layoutID)
    {
      return new bool();
    }

    [Token(Token = "0x6008F6C")]
    [Address(RVA = "0x4B099F8", Offset = "0x4B099F8", VA = "0x4B099F8")]
    public static StoryFreeActionObjectData ObjectData(int objectID)
    {
      return (StoryFreeActionObjectData) null;
    }

    [Token(Token = "0x6008F6D")]
    [Address(RVA = "0x4AFF85C", Offset = "0x4AFF85C", VA = "0x4AFF85C")]
    public static StoryFreeActionPlayerMovePositionData PlayerMovePositionData(int positionID)
    {
      return (StoryFreeActionPlayerMovePositionData) null;
    }

    [Token(Token = "0x6008F6E")]
    [Address(RVA = "0x4AFF964", Offset = "0x4AFF964", VA = "0x4AFF964")]
    public static StoryFreeActionCameraViewPositionData CameraViewPositionData(int positionID)
    {
      return (StoryFreeActionCameraViewPositionData) null;
    }

    [Token(Token = "0x6008F6F")]
    [Address(RVA = "0x4B09A94", Offset = "0x4B09A94", VA = "0x4B09A94")]
    public static StoryFreeActionAreaData AreaData(int areaID) => (StoryFreeActionAreaData) null;

    [Token(Token = "0x6008F70")]
    [Address(RVA = "0x4B09B30", Offset = "0x4B09B30", VA = "0x4B09B30")]
    public static IReadOnlyList<StoryFreeActionAreaSettingData> AreaSettingDataList(
      int areaSettingLabel)
    {
      return (IReadOnlyList<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6008F71")]
    [Address(RVA = "0x4B09BB8", Offset = "0x4B09BB8", VA = "0x4B09BB8")]
    public static IReadOnlyList<StoryFreeActionAreaGroupData> AreaGroupDataList(int areaGroupLabel)
    {
      return (IReadOnlyList<StoryFreeActionAreaGroupData>) null;
    }

    [Token(Token = "0x6008F72")]
    [Address(RVA = "0x4B09C40", Offset = "0x4B09C40", VA = "0x4B09C40")]
    public static IReadOnlyList<AreaConnectParam> CreateConnectionParams(
      int areaId,
      IReadOnlyList<StoryFreeActionAreaGroupData> groupDataList,
      IReadOnlyList<StoryFreeActionAreaSettingData> areaSettingDataList)
    {
      return (IReadOnlyList<AreaConnectParam>) null;
    }

    [Token(Token = "0x6008F73")]
    [Address(RVA = "0x4B0853C", Offset = "0x4B0853C", VA = "0x4B0853C")]
    public static IReadOnlyList<StoryFreeActionAreaSettingData> GetEnableAreaSettingParams(
      int startAreaId,
      IReadOnlyList<StoryFreeActionAreaGroupData> areaGroupDataList,
      IReadOnlyList<StoryFreeActionAreaSettingData> areaSettingDataList)
    {
      return (IReadOnlyList<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6008F74")]
    [Address(RVA = "0x4B0A448", Offset = "0x4B0A448", VA = "0x4B0A448")]
    public static IEnumerable<StoryFreeActionLayoutData> LayoutDataList(
      int layoutGroupLabel,
      int sequenceId)
    {
      return (IEnumerable<StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6008F75")]
    [Address(RVA = "0x4B0A4E0", Offset = "0x4B0A4E0", VA = "0x4B0A4E0")]
    public static IReadOnlyList<StoryFreeActionTalkBalloonEventData> TalkBalloonDataList(
      int talkBalloonLabel)
    {
      return (IReadOnlyList<StoryFreeActionTalkBalloonEventData>) null;
    }

    [Token(Token = "0x6008F76")]
    [Address(RVA = "0x4B0A568", Offset = "0x4B0A568", VA = "0x4B0A568")]
    public static IReadOnlyList<StoryFreeActionTalkADVEventData> TalkADVDataList(int talkADVLabel)
    {
      return (IReadOnlyList<StoryFreeActionTalkADVEventData>) null;
    }

    [Token(Token = "0x6008F77")]
    [Address(RVA = "0x4B0A5F0", Offset = "0x4B0A5F0", VA = "0x4B0A5F0")]
    public static StoryFreeActionPassiveTalkMessageData PassiveTalkMessage(int label)
    {
      return (StoryFreeActionPassiveTalkMessageData) null;
    }

    [Token(Token = "0x6008F78")]
    [Address(RVA = "0x4B0A68C", Offset = "0x4B0A68C", VA = "0x4B0A68C")]
    public static IReadOnlyCollection<StoryCommunicationAttachData> CommunicationEventSettingList(
      int groupLabel)
    {
      return (IReadOnlyCollection<StoryCommunicationAttachData>) null;
    }

    [Token(Token = "0x6008F79")]
    [Address(RVA = "0x4B0A714", Offset = "0x4B0A714", VA = "0x4B0A714")]
    public static IReadOnlyList<StoryFacilityAttachData> FacilityEventSettingList(int groupLabel)
    {
      return (IReadOnlyList<StoryFacilityAttachData>) null;
    }

    [Token(Token = "0x6008F7A")]
    [Address(RVA = "0x4B0A79C", Offset = "0x4B0A79C", VA = "0x4B0A79C")]
    public static StorySubquestTaskData SubQuestTaskData(int keyID) => (StorySubquestTaskData) null;

    [Token(Token = "0x6008F7B")]
    [Address(RVA = "0x4B0A838", Offset = "0x4B0A838", VA = "0x4B0A838")]
    public static int GetAreaIDInObjectIdAndSequenceID(int objectID, int sequenceID) => new int();

    [Token(Token = "0x6008F7C")]
    [Address(RVA = "0x4B0A854", Offset = "0x4B0A854", VA = "0x4B0A854")]
    public static StoryFreeActionLayoutData GetLayoutByObjectIDAndSequenceID(
      int objectID,
      int sequenceID,
      bool isBuildCondition = true)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x6008F7D")]
    [Address(RVA = "0x4B0AD20", Offset = "0x4B0AD20", VA = "0x4B0AD20")]
    private static bool ExistArea(
      IEnumerable<StoryFreeActionAreaSettingData> areasettings,
      int areaID)
    {
      return new bool();
    }

    [Token(Token = "0x6008F7E")]
    [Address(RVA = "0x4AFA8F4", Offset = "0x4AFA8F4", VA = "0x4AFA8F4")]
    public static StoryFreeActionLayoutData GetLayoutByObjectIDAndLayoutLabel(
      int objectID,
      int layoutLabel)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x6008F7F")]
    [Address(RVA = "0x4B0AB64", Offset = "0x4B0AB64", VA = "0x4B0AB64")]
    private static StoryFreeActionLayoutData[] GetLayouts(
      int objectID,
      int layoutLabel,
      Func<StoryFreeActionLayoutData, bool> predicate)
    {
      return (StoryFreeActionLayoutData[]) null;
    }

    [Token(Token = "0x6008F80")]
    [Address(RVA = "0x4B0B02C", Offset = "0x4B0B02C", VA = "0x4B0B02C")]
    private static StoryFreeActionLayoutData GetLayout(
      int objectID,
      int layoutLabel,
      Func<StoryFreeActionLayoutData, bool> predicate)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x6008F81")]
    [Address(RVA = "0x4B0B0CC", Offset = "0x4B0B0CC", VA = "0x4B0B0CC")]
    public static StoryFreeActionLayoutData GetBattleEnterLayout(
      StoryFreeActionSettingData freeactionSetting = null)
    {
      return (StoryFreeActionLayoutData) null;
    }
  }
}
