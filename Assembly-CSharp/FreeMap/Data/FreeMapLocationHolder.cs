// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.FreeMapLocationHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter;
using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.AreaEvent;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x2001948")]
  public class FreeMapLocationHolder
  {
    [Token(Token = "0x4006CBD")]
    [FieldOffset(Offset = "0x10")]
    private List<LocationData> locationList;

    [Token(Token = "0x6008FE8")]
    [Address(RVA = "0x4B0F454", Offset = "0x4B0F454", VA = "0x4B0F454")]
    public IEnumerable<LocationData> GetLocations() => (IEnumerable<LocationData>) null;

    [Token(Token = "0x17001712")]
    public int LocationCount
    {
      [Token(Token = "0x6008FE9"), Address(RVA = "0x4B0F45C", Offset = "0x4B0F45C", VA = "0x4B0F45C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008FEA")]
    [Address(RVA = "0x4B0F4A4", Offset = "0x4B0F4A4", VA = "0x4B0F4A4")]
    public void SettingInstances(StoryFreeActionSettingData settingData, PlayingStoryInfo storyInfo)
    {
    }

    [Token(Token = "0x6008FEB")]
    [Address(RVA = "0x4B0F93C", Offset = "0x4B0F93C", VA = "0x4B0F93C")]
    public void SettingInstancesTutorialMode(StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6008FEC")]
    [Address(RVA = "0x4B0FDA4", Offset = "0x4B0FDA4", VA = "0x4B0FDA4")]
    public void SettingEvents(FreeMapParamList paramList)
    {
    }

    [Token(Token = "0x6008FED")]
    [Address(RVA = "0x4B1024C", Offset = "0x4B1024C", VA = "0x4B1024C")]
    public bool IsContainArea(int areaID) => new bool();

    [Token(Token = "0x6008FEE")]
    [Address(RVA = "0x4B0676C", Offset = "0x4B0676C", VA = "0x4B0676C")]
    public LocationData GetLocationData(int areaID) => (LocationData) null;

    [Token(Token = "0x6008FEF")]
    [Address(RVA = "0x4B10334", Offset = "0x4B10334", VA = "0x4B10334")]
    public LocationData GetLocationDataForInstanceID(InstanceID instanceID) => (LocationData) null;

    [Token(Token = "0x6008FF0")]
    [Address(RVA = "0x4B104A8", Offset = "0x4B104A8", VA = "0x4B104A8")]
    public LocationData GetLocationDataForObjectID(int objectID) => (LocationData) null;

    [Token(Token = "0x6008FF1")]
    [Address(RVA = "0x4B104B0", Offset = "0x4B104B0", VA = "0x4B104B0")]
    public FreeMapScenesParam GetCurrentScenesParameter(int areaID) => (FreeMapScenesParam) null;

    [Token(Token = "0x6008FF2")]
    [Address(RVA = "0x4B104C8", Offset = "0x4B104C8", VA = "0x4B104C8")]
    public FreeMapCommunicationEventUIParam FindCommunicationUIParam(int communicationID)
    {
      return (FreeMapCommunicationEventUIParam) null;
    }

    [Token(Token = "0x6008FF3")]
    [Address(RVA = "0x4B10644", Offset = "0x4B10644", VA = "0x4B10644")]
    public FreeMapFacilityEventUIParam FindFacilityUIParam(int attachID)
    {
      return (FreeMapFacilityEventUIParam) null;
    }

    [Token(Token = "0x6008FF4")]
    [Address(RVA = "0x4B107C0", Offset = "0x4B107C0", VA = "0x4B107C0")]
    private List<FreeMapAreaEventQuestTaskEventUIParam> GetAreaEventTaskAll()
    {
      return (List<FreeMapAreaEventQuestTaskEventUIParam>) null;
    }

    [Token(Token = "0x6008FF5")]
    [Address(RVA = "0x4B06B20", Offset = "0x4B06B20", VA = "0x4B06B20")]
    public List<FreeMapTransitionEventUIParam> GetPurposeMarkTransUIsInAreaEventTask(int startAreaID)
    {
      return (List<FreeMapTransitionEventUIParam>) null;
    }

    [Token(Token = "0x6008FF6")]
    [Address(RVA = "0x4B1099C", Offset = "0x4B1099C", VA = "0x4B1099C")]
    public List<FreeMapUIParamBase> GetRouteUIParamList(int fromID, int toID)
    {
      return (List<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FF7")]
    [Address(RVA = "0x4B10D28", Offset = "0x4B10D28", VA = "0x4B10D28")]
    public void Clear()
    {
    }

    [Token(Token = "0x6008FF8")]
    [Address(RVA = "0x4B10D98", Offset = "0x4B10D98", VA = "0x4B10D98")]
    public FreeMapLocationHolder()
    {
    }
  }
}
