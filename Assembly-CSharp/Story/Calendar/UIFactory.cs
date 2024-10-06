// Decompiled with JetBrains decompiler
// Type: Story.Calendar.UIFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.U2D;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x2000728")]
  public static class UIFactory
  {
    [Token(Token = "0x170005F8")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x6002851"), Address(RVA = "0x36753E0", Offset = "0x36753E0", VA = "0x36753E0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6002852"), Address(RVA = "0x3675438", Offset = "0x3675438", VA = "0x3675438")] private set
      {
      }
    }

    [Token(Token = "0x6002853")]
    [Address(RVA = "0x3675494", Offset = "0x3675494", VA = "0x3675494")]
    public static IEnumerator LoadAsync(string[] unloededList) => (IEnumerator) null;

    [Token(Token = "0x6002854")]
    [Address(RVA = "0x3674350", Offset = "0x3674350", VA = "0x3674350")]
    public static IEnumerator AddLoadAsync(string[] assetBundles) => (IEnumerator) null;

    [Token(Token = "0x6002855")]
    [Address(RVA = "0x367554C", Offset = "0x367554C", VA = "0x367554C")]
    public static string[] GetUnloadedAssetBundle() => (string[]) null;

    [Token(Token = "0x6002856")]
    [Address(RVA = "0x3672F20", Offset = "0x3672F20", VA = "0x3672F20")]
    public static void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x6002857")]
    public static T LoadedInstantiate<T>(string label, string assetName) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x6002858")]
    [Address(RVA = "0x36743B8", Offset = "0x36743B8", VA = "0x36743B8")]
    public static GameObject LoadedInstance(string assetBundle, string assetName)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6002859")]
    [Address(RVA = "0x3673B18", Offset = "0x3673B18", VA = "0x3673B18")]
    public static SpriteAtlas LoadSpriteAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x600285A")]
    [Address(RVA = "0x3673CA0", Offset = "0x3673CA0", VA = "0x3673CA0")]
    public static UITimelineSettingAsset LoadUITimelineAsset() => (UITimelineSettingAsset) null;

    [Token(Token = "0x600285B")]
    [Address(RVA = "0x3675A04", Offset = "0x3675A04", VA = "0x3675A04")]
    public static PlayableAsset LoadUIPlayableAsset(string label, string assetName)
    {
      return (PlayableAsset) null;
    }

    [Token(Token = "0x600285C")]
    [Address(RVA = "0x3674610", Offset = "0x3674610", VA = "0x3674610")]
    public static PlayableAsset LoadUIPlayableAsset(UIFactory.TimeLinePattern ptn)
    {
      return (PlayableAsset) null;
    }

    [Token(Token = "0x600285D")]
    [Address(RVA = "0x36744C0", Offset = "0x36744C0", VA = "0x36744C0")]
    public static PlayableAsset LoadChangeCharaPlayableAsset(
      UIFactory.TimeLinePattern ptn,
      int charaId)
    {
      return (PlayableAsset) null;
    }

    [Token(Token = "0x600285E")]
    [Address(RVA = "0x3673A08", Offset = "0x3673A08", VA = "0x3673A08")]
    public static Material LoadMaterial(string assetName) => (Material) null;

    [Token(Token = "0x600285F")]
    [Address(RVA = "0x3675B04", Offset = "0x3675B04", VA = "0x3675B04")]
    static UIFactory()
    {
    }

    [Token(Token = "0x2000729")]
    public enum TimeLinePattern
    {
      [Token(Token = "0x4002143")] TodayIn,
      [Token(Token = "0x4002144")] In,
      [Token(Token = "0x4002145")] TodayOut,
      [Token(Token = "0x4002146")] Out,
      [Token(Token = "0x4002147")] DayDisScroll,
      [Token(Token = "0x4002148")] DayScroll,
      [Token(Token = "0x4002149")] MonthDisScroll,
      [Token(Token = "0x400214A")] MonthScroll,
      [Token(Token = "0x400214B")] DayChangeCharaIn,
      [Token(Token = "0x400214C")] DayChangeCharaOut,
      [Token(Token = "0x400214D")] DayChangeEffIn,
      [Token(Token = "0x400214E")] DayChangeEffOut,
    }

    [Token(Token = "0x200072A")]
    public static class AssetBundles
    {
      [Token(Token = "0x400214F")]
      public const string AssetCalendarLabel = "ui_page_adv_calendareffect";
      [Token(Token = "0x4002150")]
      public const string AssetPrefabLabel = "ui_page_adv_calendareffect_prefab";
      [Token(Token = "0x4002151")]
      public const string AssetTimelineLabel = "ui_page_adv_calendareffect_timeline";
      [Token(Token = "0x4002152")]
      public const string AssetMaterialLabel = "ui_page_adv_calendareffect_material";
      [Token(Token = "0x4002153")]
      public const string AssetCalendarTextureLabel = "ui_page_adv_calendareffect_texture_calendar";
      [Token(Token = "0x4002154")]
      public const string AssetCalendar = "Control_Container_Calendar";
      [Token(Token = "0x4002155")]
      public const string SpriteAssetName = "calendar";
      [Token(Token = "0x4002156")]
      public const string DisolveMatName = "Eff_Disolve";
      [Token(Token = "0x4002157")]
      public const string CalendarFrameMatName = "Calendar_Frame";
      [Token(Token = "0x4002158")]
      public const string CalendarTimelineSettingName = "CalendarEffect";
      [Token(Token = "0x4002159")]
      public const string AssetLabelCharaPrefab = "content_scenechangeday_{0}_prefab";
      [Token(Token = "0x400215A")]
      public const string AssetNameCharaPrefab = "{0}_ChangeDay";
      [Token(Token = "0x400215B")]
      public const string AssetLabelCharaTimeline = "content_scenechangeday_{0}_timeline";
      [Token(Token = "0x400215C")]
      public const string AssetLabelEffChangeDayTimelinet = "content_scenechangeday_common_timeline";
      [Token(Token = "0x400215D")]
      [FieldOffset(Offset = "0x0")]
      public static readonly Dictionary<UIFactory.TimeLinePattern, string> TimelineNameMap;
      [Token(Token = "0x400215E")]
      [FieldOffset(Offset = "0x8")]
      public static readonly Dictionary<UIFactory.TimeLinePattern, string> TimelineLabelMap;

      [Token(Token = "0x6002860")]
      [Address(RVA = "0x3675B90", Offset = "0x3675B90", VA = "0x3675B90")]
      static AssetBundles()
      {
      }
    }
  }
}
