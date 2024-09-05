// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using FreeMap.Scriptable;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DAA")]
  public class PocketBookLoader
  {
    [Token(Token = "0x400C43E")]
    private const string PREFAB_ASSET_LABEL_NAME = "ui_page_pocketbook_prefab";
    [Token(Token = "0x400C43F")]
    public const string TIMELINE_ASSET_LABEL_NAME = "ui_page_pocketbook_timeline";
    [Token(Token = "0x400C440")]
    private const string SPRITE_ATLAS_ASSET_LABEL_NAME = "ui_page_pocketbook";
    [Token(Token = "0x400C441")]
    public const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x400C442")]
    public const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base_New";
    [Token(Token = "0x400C443")]
    public const string HEADER_TIMELINE_ASSET_NAME = "HeaderSetting";
    [Token(Token = "0x400C444")]
    private const string SPRITE_ATLAS_NAME = "pocketbook";
    [Token(Token = "0x400C445")]
    [FieldOffset(Offset = "0x10")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x400C446")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, string> prefabMap;
    [Token(Token = "0x400C449")]
    [FieldOffset(Offset = "0x28")]
    private string profileImageABName;
    [Token(Token = "0x400C44A")]
    [FieldOffset(Offset = "0x30")]
    private string profileImageAssetName;
    [Token(Token = "0x400C44B")]
    [FieldOffset(Offset = "0x38")]
    private PlacementObjectLoader placementLoader;

    [Token(Token = "0x17003D06")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x6011DC1"), Address(RVA = "0x3FA5BE8", Offset = "0x3FA5BE8", VA = "0x3FA5BE8")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6011DC2"), Address(RVA = "0x3FA5C40", Offset = "0x3FA5C40", VA = "0x3FA5C40")] private set
      {
      }
    }

    [Token(Token = "0x17003D07")]
    public MessageIDTable MessageIDTable
    {
      [Token(Token = "0x6011DC3"), Address(RVA = "0x3FA5C9C", Offset = "0x3FA5C9C", VA = "0x3FA5C9C")] get
      {
        return (MessageIDTable) null;
      }
    }

    [Token(Token = "0x6011DC4")]
    [Address(RVA = "0x3FA5CA4", Offset = "0x3FA5CA4", VA = "0x3FA5CA4")]
    private string[] GetLoadAssetBundleList() => (string[]) null;

    [Token(Token = "0x6011DC5")]
    [Address(RVA = "0x3FA6260", Offset = "0x3FA6260", VA = "0x3FA6260")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6011DC6")]
    public T CreatePrefab<T>(PocketBookSubScene.PrefabType prefabType, string label = "ui_page_pocketbook_prefab") where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x6011DC7")]
    private T LoadedInstantiate<T>(string label, string assetName) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x6011DC8")]
    [Address(RVA = "0x3FA2A2C", Offset = "0x3FA2A2C", VA = "0x3FA2A2C")]
    public SpriteAtlas LoadSpriteAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x6011DC9")]
    [Address(RVA = "0x3FA4D30", Offset = "0x3FA4D30", VA = "0x3FA4D30")]
    public UITimelineSettingAsset LoadUITimelineAsset(string label = "ui_page_pocketbook_timeline", string assetName = "HeaderSetting")
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x6011DCA")]
    [Address(RVA = "0x3FA62F0", Offset = "0x3FA62F0", VA = "0x3FA62F0")]
    public Sprite GetProfileImage() => (Sprite) null;

    [Token(Token = "0x6011DCB")]
    [Address(RVA = "0x3FA63EC", Offset = "0x3FA63EC", VA = "0x3FA63EC")]
    public IEnumerator LoadChoiceCharacterImage(
      string label,
      string assetName,
      Action<Sprite> onLoadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011DCC")]
    [Address(RVA = "0x3FA6490", Offset = "0x3FA6490", VA = "0x3FA6490")]
    public IEnumerator LoadMapImage(string abname, string assetName, Action<Sprite> onLoadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011DCD")]
    [Address(RVA = "0x3FA6534", Offset = "0x3FA6534", VA = "0x3FA6534")]
    public IEnumerator LoadCommuCharaImages(
      IEnumerable<FreeMapCommunicationEventUIParam> commus,
      Action<(int, Sprite)> onLoadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011DCE")]
    [Address(RVA = "0x3FA65D0", Offset = "0x3FA65D0", VA = "0x3FA65D0")]
    public IEnumerator LoadCharaThumbnail(
      int characterID,
      int styleID,
      Action<(int, Sprite)> onLoadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011DCF")]
    public IEnumerator LoadAsset<T>(string abname, string assetname, Action<T> onLoadedAction) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011DD0")]
    [Address(RVA = "0x3FA4EBC", Offset = "0x3FA4EBC", VA = "0x3FA4EBC")]
    public UITimelineSettingAsset LoadCommonPopupTimeline() => (UITimelineSettingAsset) null;

    [Token(Token = "0x6011DD1")]
    [Address(RVA = "0x3FA6678", Offset = "0x3FA6678", VA = "0x3FA6678")]
    public void RegisterPlacementCache(CurrentFreeActionParam freeaction)
    {
    }

    [Token(Token = "0x6011DD2")]
    [Address(RVA = "0x3FA6A48", Offset = "0x3FA6A48", VA = "0x3FA6A48")]
    public IEnumerator LoadPlacement(int areaSettingID) => (IEnumerator) null;

    [Token(Token = "0x6011DD3")]
    [Address(RVA = "0x3FA6AE8", Offset = "0x3FA6AE8", VA = "0x3FA6AE8")]
    public FreeMapPlacementObject GetPlacement(int areaID) => (FreeMapPlacementObject) null;

    [Token(Token = "0x6011DD4")]
    [Address(RVA = "0x3FA6B94", Offset = "0x3FA6B94", VA = "0x3FA6B94")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x6011DD5")]
    [Address(RVA = "0x3FA6DA0", Offset = "0x3FA6DA0", VA = "0x3FA6DA0")]
    public void Unload(string label)
    {
    }

    [Token(Token = "0x6011DD6")]
    [Address(RVA = "0x3FA6E24", Offset = "0x3FA6E24", VA = "0x3FA6E24")]
    public void Release()
    {
    }

    [Token(Token = "0x6011DD7")]
    [Address(RVA = "0x3FA6E94", Offset = "0x3FA6E94", VA = "0x3FA6E94")]
    public PocketBookLoader()
    {
    }

    [Token(Token = "0x6011DD8")]
    [Address(RVA = "0x3FA73A4", Offset = "0x3FA73A4", VA = "0x3FA73A4")]
    static PocketBookLoader()
    {
    }

    [Token(Token = "0x2002DAB")]
    public enum TimelineType
    {
      [Token(Token = "0x400C44D")] SKIP_LEFT_IN,
      [Token(Token = "0x400C44E")] SKIP_LEFT_OUT,
      [Token(Token = "0x400C44F")] SKIP_RIGHT_IN,
      [Token(Token = "0x400C450")] SKIP_RIGHT_OUT,
      [Token(Token = "0x400C451")] PROFILE_LEFT_IN,
      [Token(Token = "0x400C452")] PROFILE_LEFT_OUT,
      [Token(Token = "0x400C453")] PROFILE_RIGHT_IN,
      [Token(Token = "0x400C454")] PROFILE_RIGHT_OUT,
      [Token(Token = "0x400C455")] COMMON_POPUP_IN,
      [Token(Token = "0x400C456")] COMMON_POPUP_OUT,
      [Token(Token = "0x400C457")] STORYINDEX_IN,
      [Token(Token = "0x400C458")] STORYINDEX_OUT,
    }

    [Token(Token = "0x2002DAC")]
    public enum TimelinePattern
    {
      [Token(Token = "0x400C45A")] HEADER,
      [Token(Token = "0x400C45B")] COMMON_POPUP,
    }
  }
}
