// Decompiled with JetBrains decompiler
// Type: Story.Facility.FacilityInfoLoader
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
namespace Story.Facility
{
  [Token(Token = "0x20006A3")]
  public class FacilityInfoLoader
  {
    [Token(Token = "0x4001FCD")]
    public const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x4001FCE")]
    public const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base_New";
    [Token(Token = "0x4001FCF")]
    public const string FACILITY_INFO_POPUP_LABEL_NAME = "ui_page_pocketbook_prefab";
    [Token(Token = "0x4001FD0")]
    public const string FACILITY_INFO_POPUP_NAME = "Com_Popup_Base_Institution";
    [Token(Token = "0x4001FD1")]
    public const string ITEM_ICON_LABEL_NAME = "ui_common_thumb";
    [Token(Token = "0x4001FD2")]
    public const string ITEM_ICON_NAME = "Com_ItemThumb";
    [Token(Token = "0x4001FD3")]
    [FieldOffset(Offset = "0x10")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x4001FD4")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, string> prefabMap;

    [Token(Token = "0x17000589")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x60025B3"), Address(RVA = "0x2F3CF68", Offset = "0x2F3CF68", VA = "0x2F3CF68")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60025B4"), Address(RVA = "0x2F3CFC0", Offset = "0x2F3CFC0", VA = "0x2F3CFC0")] private set
      {
      }
    }

    [Token(Token = "0x60025B5")]
    [Address(RVA = "0x2F3D01C", Offset = "0x2F3D01C", VA = "0x2F3D01C")]
    private string[] GetLoadAssetBundleList() => (string[]) null;

    [Token(Token = "0x60025B6")]
    [Address(RVA = "0x2F3D44C", Offset = "0x2F3D44C", VA = "0x2F3D44C")]
    private string[] SetItemLabel(int facilityId) => (string[]) null;

    [Token(Token = "0x60025B7")]
    [Address(RVA = "0x2F3DC50", Offset = "0x2F3DC50", VA = "0x2F3DC50")]
    public IEnumerator LoadAsync(int facilityId) => (IEnumerator) null;

    [Token(Token = "0x60025B8")]
    public T CreatePrefab<T>(FacilityInfoLoader.PrefabType prefabType, string label = "ui_page_pocketbook_prefab") where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x60025B9")]
    public IEnumerator LoadAsset<T>(string abname, string assetname, Action<T> onLoadedAction) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60025BA")]
    private T LoadedInstantiate<T>(string label, string assetName) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x60025BB")]
    [Address(RVA = "0x2F3DCF0", Offset = "0x2F3DCF0", VA = "0x2F3DCF0")]
    public UITimelineSettingAsset LoadCommonPopupTimeline() => (UITimelineSettingAsset) null;

    [Token(Token = "0x60025BC")]
    [Address(RVA = "0x2F3DD48", Offset = "0x2F3DD48", VA = "0x2F3DD48")]
    public UITimelineSettingAsset LoadUITimelineAsset(string label = "ui_common_timeline", string assetName = "Com_Popup_Base_New")
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x60025BD")]
    [Address(RVA = "0x2F3DE48", Offset = "0x2F3DE48", VA = "0x2F3DE48")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x60025BE")]
    [Address(RVA = "0x2F3E054", Offset = "0x2F3E054", VA = "0x2F3E054")]
    public FacilityInfoLoader()
    {
    }

    [Token(Token = "0x60025BF")]
    [Address(RVA = "0x2F3E188", Offset = "0x2F3E188", VA = "0x2F3E188")]
    static FacilityInfoLoader()
    {
    }

    [Token(Token = "0x20006A4")]
    public enum TimelineType
    {
      [Token(Token = "0x4001FD7")] COMMON_POPUP_IN,
      [Token(Token = "0x4001FD8")] COMMON_POPUP_OUT,
    }

    [Token(Token = "0x20006A5")]
    public enum TimelinePattern
    {
      [Token(Token = "0x4001FDA")] FACILITY_INFO_POPUP,
    }

    [Token(Token = "0x20006A6")]
    public enum PrefabType
    {
      [Token(Token = "0x4001FDC")] FACILITY_INFO_POPUP,
    }
  }
}
