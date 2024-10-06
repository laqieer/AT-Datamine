// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.FreeMapParamList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.State.ModeState;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using StaqData.Story;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x200194B")]
  public class FreeMapParamList
  {
    [Token(Token = "0x4006CC0")]
    [FieldOffset(Offset = "0x10")]
    private List<FreeMapUIParamBase> uiParams;
    [Token(Token = "0x4006CC1")]
    [FieldOffset(Offset = "0x18")]
    private List<FreeMapTransitionEventUIParam> transitionParams;

    [Token(Token = "0x17001713")]
    public IEnumerable<FreeMapUIParamBase> UIParams
    {
      [Token(Token = "0x6008FFD"), Address(RVA = "0x4B10E6C", Offset = "0x4B10E6C", VA = "0x4B10E6C")] get
      {
        return (IEnumerable<FreeMapUIParamBase>) null;
      }
    }

    [Token(Token = "0x6008FFE")]
    [Address(RVA = "0x4B101F4", Offset = "0x4B101F4", VA = "0x4B101F4")]
    public IEnumerable<FreeMapUIParamBase> UIParamsInArea(int areaID)
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x17001714")]
    public IEnumerable<FreeMapTransitionEventUIParam> TransitionParams
    {
      [Token(Token = "0x6008FFF"), Address(RVA = "0x4B10E74", Offset = "0x4B10E74", VA = "0x4B10E74")] get
      {
        return (IEnumerable<FreeMapTransitionEventUIParam>) null;
      }
    }

    [Token(Token = "0x17001715")]
    public IEnumerable<FreeMapSubQuestEventUIParam> SubquestParams
    {
      [Token(Token = "0x6009000"), Address(RVA = "0x4B10E7C", Offset = "0x4B10E7C", VA = "0x4B10E7C")] get
      {
        return (IEnumerable<FreeMapSubQuestEventUIParam>) null;
      }
    }

    [Token(Token = "0x17001716")]
    public IEnumerable<FreeMapADVEventUIParam> TalkAdv
    {
      [Token(Token = "0x6009001"), Address(RVA = "0x4B10EC4", Offset = "0x4B10EC4", VA = "0x4B10EC4")] get
      {
        return (IEnumerable<FreeMapADVEventUIParam>) null;
      }
    }

    [Token(Token = "0x17001717")]
    public IEnumerable<FreeMapCommunicationEventUIParam> CommunicationParams
    {
      [Token(Token = "0x6009002"), Address(RVA = "0x4B10F0C", Offset = "0x4B10F0C", VA = "0x4B10F0C")] get
      {
        return (IEnumerable<FreeMapCommunicationEventUIParam>) null;
      }
    }

    [Token(Token = "0x17001718")]
    public IEnumerable<FreeMapFacilityEventUIParam> FacilityParams
    {
      [Token(Token = "0x6009003"), Address(RVA = "0x4B10F54", Offset = "0x4B10F54", VA = "0x4B10F54")] get
      {
        return (IEnumerable<FreeMapFacilityEventUIParam>) null;
      }
    }

    [Token(Token = "0x17001719")]
    public IEnumerable<FreeMapObliviaeEnterUIParam> ObliviaeEnter
    {
      [Token(Token = "0x6009004"), Address(RVA = "0x4B10F9C", Offset = "0x4B10F9C", VA = "0x4B10F9C")] get
      {
        return (IEnumerable<FreeMapObliviaeEnterUIParam>) null;
      }
    }

    [Token(Token = "0x1700171A")]
    public IEnumerable<FreeMapBattleEnterUIParam> BattleEnter
    {
      [Token(Token = "0x6009005"), Address(RVA = "0x4B10FE4", Offset = "0x4B10FE4", VA = "0x4B10FE4")] get
      {
        return (IEnumerable<FreeMapBattleEnterUIParam>) null;
      }
    }

    [Token(Token = "0x1700171B")]
    public IEnumerable<FreeMapFastTravelPointUIParam> FastTravelPoints
    {
      [Token(Token = "0x6009006"), Address(RVA = "0x4B1102C", Offset = "0x4B1102C", VA = "0x4B1102C")] get
      {
        return (IEnumerable<FreeMapFastTravelPointUIParam>) null;
      }
    }

    [Token(Token = "0x1700171C")]
    public IEnumerable<FreeMapChestUIParam> Chests
    {
      [Token(Token = "0x6009007"), Address(RVA = "0x4B11074", Offset = "0x4B11074", VA = "0x4B11074")] get
      {
        return (IEnumerable<FreeMapChestUIParam>) null;
      }
    }

    [Token(Token = "0x1700171D")]
    public IEnumerable<FreeMapTimeElapseUIParam> TimeElapse
    {
      [Token(Token = "0x6009008"), Address(RVA = "0x4B110BC", Offset = "0x4B110BC", VA = "0x4B110BC")] get
      {
        return (IEnumerable<FreeMapTimeElapseUIParam>) null;
      }
    }

    [Token(Token = "0x6009009")]
    [Address(RVA = "0x4B11104", Offset = "0x4B11104", VA = "0x4B11104")]
    private FreeMapParamList()
    {
    }

    [Token(Token = "0x600900A")]
    [Address(RVA = "0x4B111C4", Offset = "0x4B111C4", VA = "0x4B111C4")]
    public static FreeMapParamList FreeMapTutorial(
      StoryFreeActionSettingData settingData,
      TutorialModaState state)
    {
      return (FreeMapParamList) null;
    }

    [Token(Token = "0x600900B")]
    [Address(RVA = "0x4B08198", Offset = "0x4B08198", VA = "0x4B08198")]
    public static FreeMapParamList FreeMap(
      int sequenceID,
      StoryFreeActionSettingData settingData,
      PlayingStoryInfo storyInfo = null)
    {
      return (FreeMapParamList) null;
    }

    [Token(Token = "0x600900C")]
    [Address(RVA = "0x4B140DC", Offset = "0x4B140DC", VA = "0x4B140DC")]
    public static FreeMapParamList AreaEventMap(
      int sequenceID,
      StoryFreeActionSettingData settingData,
      PlayingStoryInfo storyInfo = null)
    {
      return (FreeMapParamList) null;
    }

    [Token(Token = "0x600900D")]
    [Address(RVA = "0x4B1494C", Offset = "0x4B1494C", VA = "0x4B1494C")]
    public static FreeMapParamList AnyTypeMap(
      int sequenceID,
      StoryFreeActionSettingData settingData,
      PlayingStoryInfo storyInfo = null)
    {
      return (FreeMapParamList) null;
    }

    [Token(Token = "0x600900E")]
    [Address(RVA = "0x4B14054", Offset = "0x4B14054", VA = "0x4B14054")]
    private static void SetCommon(
      StoryFreeActionSettingData settingData,
      FreeMapParamList paramList,
      int sequenceID)
    {
    }

    [Token(Token = "0x600900F")]
    [Address(RVA = "0x4B16280", Offset = "0x4B16280", VA = "0x4B16280")]
    private void SetTransitions(int areaGroupLabel, int areasettingLabel)
    {
    }

    [Token(Token = "0x6009010")]
    [Address(RVA = "0x4B132B4", Offset = "0x4B132B4", VA = "0x4B132B4")]
    private void SetSubQuestEvent(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x6009011")]
    [Address(RVA = "0x4B14190", Offset = "0x4B14190", VA = "0x4B14190")]
    private void SetAreaEventQuest(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x6009012")]
    [Address(RVA = "0x4B15B68", Offset = "0x4B15B68", VA = "0x4B15B68")]
    private void SetRewardObjectEvent(StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6009013")]
    [Address(RVA = "0x4B11A7C", Offset = "0x4B11A7C", VA = "0x4B11A7C")]
    private void SetBattleEnter(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x6009014")]
    [Address(RVA = "0x4B11F10", Offset = "0x4B11F10", VA = "0x4B11F10")]
    private void SetObliviae(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x6009015")]
    [Address(RVA = "0x4B12B88", Offset = "0x4B12B88", VA = "0x4B12B88")]
    private void SetStoryShop(
      StoryFreeActionSettingData settingData,
      StoryShopList shopList,
      int sequenceID)
    {
    }

    [Token(Token = "0x6009016")]
    [Address(RVA = "0x4B11248", Offset = "0x4B11248", VA = "0x4B11248")]
    private void SetPassiveMessage(StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6009017")]
    [Address(RVA = "0x4B14E6C", Offset = "0x4B14E6C", VA = "0x4B14E6C")]
    private void SetPassiveMessage(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x6009018")]
    [Address(RVA = "0x4B1165C", Offset = "0x4B1165C", VA = "0x4B1165C")]
    private void SetTalkAdvTutorial(StoryFreeActionSettingData settingData, TutorialModaState state)
    {
    }

    [Token(Token = "0x6009019")]
    [Address(RVA = "0x4B14A50", Offset = "0x4B14A50", VA = "0x4B14A50")]
    private void SetTalkAdv(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x600901A")]
    [Address(RVA = "0x4B156F8", Offset = "0x4B156F8", VA = "0x4B156F8")]
    private void SetSystemMenu(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x600901B")]
    [Address(RVA = "0x4B15288", Offset = "0x4B15288", VA = "0x4B15288")]
    private void SetFlavor(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }

    [Token(Token = "0x600901C")]
    [Address(RVA = "0x4B123B8", Offset = "0x4B123B8", VA = "0x4B123B8")]
    private void SetCommunication(
      StoryFreeActionSettingData settingData,
      CommunicationInfo communicationInfo,
      int sequenceID)
    {
    }

    [Token(Token = "0x600901D")]
    [Address(RVA = "0x4B12E44", Offset = "0x4B12E44", VA = "0x4B12E44")]
    private void SetFacility(
      StoryFreeActionSettingData settingData,
      FacilityInfo facilityInfo,
      int sequenceID)
    {
    }

    [Token(Token = "0x600901E")]
    [Address(RVA = "0x4B168EC", Offset = "0x4B168EC", VA = "0x4B168EC")]
    private void SetAreaFastTravel(StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x600901F")]
    [Address(RVA = "0x4B13AE8", Offset = "0x4B13AE8", VA = "0x4B13AE8")]
    private void SetTimeElapse(StoryFreeActionSettingData settingData, int sequenceID)
    {
    }
  }
}
