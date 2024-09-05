// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033D7")]
  public class QuestAssetLoader
  {
    [Token(Token = "0x400E133")]
    private const string PREFAB_ASSET_BUNDLE_LABEL_QUEST = "ui_page_quest_prefab";
    [Token(Token = "0x400E134")]
    private const string PREFAB_ASSET_BUNDLE_LABEL_MAP_OBJ = "2dassets_ui_story_map";
    [Token(Token = "0x400E135")]
    private const string PREFAB_ASSET_BUNDLE_LABEL_EVENT = "2dassets_ui_event";
    [Token(Token = "0x400E136")]
    private const string PREFAB_ASSET_BUNDLE_LABEL_OBLIVIAE = "2dassets_ui_story_obliviae";
    [Token(Token = "0x400E137")]
    private const string MAP_SPRITE_LABEL = "2dassets_ui_questprepare_map{0}";
    [Token(Token = "0x400E138")]
    private const string PREFAB_ASSET_BUNDLE_COMMUCONDITION = "2dassets_ui_story_pocketbook";
    [Token(Token = "0x400E139")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<QuestAssetLoader.LoadObjectType, string> loadMap;
    [Token(Token = "0x400E13A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, bool> isLoadedAssetBundleMap;

    [Token(Token = "0x60145F2")]
    [Address(RVA = "0x18873E8", Offset = "0x18873E8", VA = "0x18873E8")]
    public bool IsLoadedAssetBundle() => new bool();

    [Token(Token = "0x60145F3")]
    [Address(RVA = "0x1887548", Offset = "0x1887548", VA = "0x1887548")]
    public bool CheckLoadedAssetBundle(string label) => new bool();

    [Token(Token = "0x60145F4")]
    [Address(RVA = "0x18875DC", Offset = "0x18875DC", VA = "0x18875DC")]
    public IEnumerator LoadAssetLabelByQuest(Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145F5")]
    [Address(RVA = "0x1887678", Offset = "0x1887678", VA = "0x1887678")]
    public void UnLoadedAssetLabelByQuest()
    {
    }

    [Token(Token = "0x60145F6")]
    [Address(RVA = "0x18877C0", Offset = "0x18877C0", VA = "0x18877C0")]
    public IEnumerator LoadAssetLabelByMapObj(Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145F7")]
    [Address(RVA = "0x188785C", Offset = "0x188785C", VA = "0x188785C")]
    public IEnumerator LoadAssetLabelByEvent(Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145F8")]
    [Address(RVA = "0x18878F8", Offset = "0x18878F8", VA = "0x18878F8")]
    public IEnumerator LoadAssetLabelByMapSprite(
      string mapCategoryName,
      Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145F9")]
    [Address(RVA = "0x188799C", Offset = "0x188799C", VA = "0x188799C")]
    public IEnumerator LoadAssetLabelByDotUnit(
      int mapCharaStyleId,
      Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145FA")]
    [Address(RVA = "0x1887A40", Offset = "0x1887A40", VA = "0x1887A40")]
    public IEnumerator LoadAssetLabelByObliviae(Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145FB")]
    [Address(RVA = "0x1887ADC", Offset = "0x1887ADC", VA = "0x1887ADC")]
    public IEnumerator LoadAssetlabelByCommuConditionPopup(Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145FC")]
    [Address(RVA = "0x1887B78", Offset = "0x1887B78", VA = "0x1887B78")]
    public GameObject GetAsseByBackgroundObj() => (GameObject) null;

    [Token(Token = "0x60145FD")]
    [Address(RVA = "0x1887C54", Offset = "0x1887C54", VA = "0x1887C54")]
    public RenderTexture GetAssetByRenderTexture() => (RenderTexture) null;

    [Token(Token = "0x60145FE")]
    [Address(RVA = "0x1887D30", Offset = "0x1887D30", VA = "0x1887D30")]
    public GameObject GetAssetByQuestSelectObject() => (GameObject) null;

    [Token(Token = "0x60145FF")]
    [Address(RVA = "0x1887E0C", Offset = "0x1887E0C", VA = "0x1887E0C")]
    public GameObject GetAssetByListItem() => (GameObject) null;

    [Token(Token = "0x6014600")]
    [Address(RVA = "0x1887EE8", Offset = "0x1887EE8", VA = "0x1887EE8")]
    public GameObject GetAssetByMapIcon() => (GameObject) null;

    [Token(Token = "0x6014601")]
    [Address(RVA = "0x1887FC4", Offset = "0x1887FC4", VA = "0x1887FC4")]
    public Sprite GetAssetByMapSprite(string mapCategoryName) => (Sprite) null;

    [Token(Token = "0x6014602")]
    [Address(RVA = "0x18880D4", Offset = "0x18880D4", VA = "0x18880D4")]
    public IEnumerator LoadAssetLabelByQuestMap(int resourceId, Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014603")]
    [Address(RVA = "0x1888178", Offset = "0x1888178", VA = "0x1888178")]
    public Sprite GetAssetByQuestMapSprite(int resourceId) => (Sprite) null;

    [Token(Token = "0x6014604")]
    [Address(RVA = "0x1888238", Offset = "0x1888238", VA = "0x1888238")]
    public IEnumerator LoadAssetLabel(string assetLabel, Action<string, bool> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014605")]
    [Address(RVA = "0x18882DC", Offset = "0x18882DC", VA = "0x18882DC")]
    public GameObject GetAssetByDotUnit(int mapCharaStyleId) => (GameObject) null;

    [Token(Token = "0x6014606")]
    [Address(RVA = "0x18883E4", Offset = "0x18883E4", VA = "0x18883E4")]
    public GameObject GetAssetByEventQuest() => (GameObject) null;

    [Token(Token = "0x6014607")]
    [Address(RVA = "0x18884C0", Offset = "0x18884C0", VA = "0x18884C0")]
    public GameObject GetAssetByObliviae() => (GameObject) null;

    [Token(Token = "0x6014608")]
    [Address(RVA = "0x188859C", Offset = "0x188859C", VA = "0x188859C")]
    public GameObject GetAssetByObliviaePopup() => (GameObject) null;

    [Token(Token = "0x6014609")]
    [Address(RVA = "0x1888678", Offset = "0x1888678", VA = "0x1888678")]
    public GameObject GetAssetbyCommuConditionPopup() => (GameObject) null;

    [Token(Token = "0x601460A")]
    [Address(RVA = "0x1888754", Offset = "0x1888754", VA = "0x1888754")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601460B")]
    [Address(RVA = "0x18876D0", Offset = "0x18876D0", VA = "0x18876D0")]
    public void UnloadAssetBundle(string label, bool canUnloadedAssetBundle, bool isForce = false)
    {
    }

    [Token(Token = "0x601460C")]
    [Address(RVA = "0x18887F8", Offset = "0x18887F8", VA = "0x18887F8")]
    public void AllUnload()
    {
    }

    [Token(Token = "0x601460D")]
    [Address(RVA = "0x18888F8", Offset = "0x18888F8", VA = "0x18888F8")]
    public QuestAssetLoader()
    {
    }

    [Token(Token = "0x20033D8")]
    public enum LoadObjectType
    {
      [Token(Token = "0x400E13C")] Front,
      [Token(Token = "0x400E13D")] Background,
      [Token(Token = "0x400E13E")] MapObj,
      [Token(Token = "0x400E13F")] ListItem,
      [Token(Token = "0x400E140")] RenderTexture,
      [Token(Token = "0x400E141")] MapSprite,
      [Token(Token = "0x400E142")] EventQuestFront,
      [Token(Token = "0x400E143")] ObliviaeFront,
      [Token(Token = "0x400E144")] ObliviaePopup,
      [Token(Token = "0x400E145")] CommuConditionPopup,
    }
  }
}
