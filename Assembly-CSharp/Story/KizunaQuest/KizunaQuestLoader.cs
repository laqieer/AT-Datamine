// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000682")]
  public class KizunaQuestLoader
  {
    [Token(Token = "0x4001F43")]
    private const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x4001F44")]
    private const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base_New";
    [Token(Token = "0x4001F45")]
    public const string KIZUNA_QUEST_POPUP_LABEL_NAME = "ui_page_kizunaquest_prefab";
    [Token(Token = "0x4001F46")]
    private const string KIZUNA_QUEST_POPUP_NAME = "Com_Popup_Base_KizunaQuest";
    [Token(Token = "0x4001F47")]
    public const string KIZUNA_QUEST_RANKUP_LIST_ITEM = "Contents_RewardList_Parts";
    [Token(Token = "0x4001F48")]
    public const string ITEM_ICON_LABEL_NAME = "ui_common_thumb";
    [Token(Token = "0x4001F49")]
    public const string ITEM_ICON_NAME = "Com_ItemThumb";
    [Token(Token = "0x4001F4A")]
    [FieldOffset(Offset = "0x10")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x4001F4B")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, string> prefabMap;

    [Token(Token = "0x17000574")]
    private List<string> LoadedList
    {
      [Token(Token = "0x6002534"), Address(RVA = "0x2F37290", Offset = "0x2F37290", VA = "0x2F37290")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6002535"), Address(RVA = "0x2F37298", Offset = "0x2F37298", VA = "0x2F37298")] set
      {
      }
    }

    [Token(Token = "0x6002536")]
    [Address(RVA = "0x2F372A0", Offset = "0x2F372A0", VA = "0x2F372A0")]
    private string[] GetLoadAssetBundleList() => (string[]) null;

    [Token(Token = "0x6002537")]
    [Address(RVA = "0x2F376D0", Offset = "0x2F376D0", VA = "0x2F376D0")]
    public IEnumerator LoadAsync(int communicatioId) => (IEnumerator) null;

    [Token(Token = "0x6002538")]
    public T CreatePrefab<T>(KizunaQuestLoader.PrefabType prefabType, string label) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x6002539")]
    public IEnumerator LoadAsset<T>(string abname, string assetname, Action<T> onLoadedAction) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600253A")]
    private T LoadedInstantiate<T>(string label, string assetName) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x600253B")]
    [Address(RVA = "0x2F37760", Offset = "0x2F37760", VA = "0x2F37760")]
    public UITimelineSettingAsset LoadCommonPopupTimeline() => (UITimelineSettingAsset) null;

    [Token(Token = "0x600253C")]
    [Address(RVA = "0x2F377B8", Offset = "0x2F377B8", VA = "0x2F377B8")]
    private UITimelineSettingAsset LoadUITimelineAsset(string label, string assetName)
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x600253D")]
    [Address(RVA = "0x2F378B8", Offset = "0x2F378B8", VA = "0x2F378B8")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x600253E")]
    [Address(RVA = "0x2F379E4", Offset = "0x2F379E4", VA = "0x2F379E4")]
    public KizunaQuestLoader()
    {
    }

    [Token(Token = "0x2000683")]
    public enum TimelineType
    {
      [Token(Token = "0x4001F4E")] COMMON_POPUP_IN,
      [Token(Token = "0x4001F4F")] COMMON_POPUP_OUT,
    }

    [Token(Token = "0x2000684")]
    public enum TimelinePattern
    {
      [Token(Token = "0x4001F51")] KIZUNA_QUEST_POPUP,
    }

    [Token(Token = "0x2000685")]
    public enum PrefabType
    {
      [Token(Token = "0x4001F53")] KizunaQuest_Popup,
      [Token(Token = "0x4001F54")] KizunaQuset_RankupReward_ListItem,
    }
  }
}
