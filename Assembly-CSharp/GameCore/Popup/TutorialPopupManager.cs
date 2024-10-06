// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.TutorialPopupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using ADV2.LuaScript;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D1F")]
  public class TutorialPopupManager : SingletonMonoBehaviour<TutorialPopupManager>
  {
    [Token(Token = "0x4003AD0")]
    [FieldOffset(Offset = "0x20")]
    private GameObject tutorialPopupPrefab;
    [Token(Token = "0x4003AD1")]
    [FieldOffset(Offset = "0x28")]
    private TutorialPopup tutorialPopup;
    [Token(Token = "0x4003AD2")]
    [FieldOffset(Offset = "0x30")]
    private AssetCachedSpawner assetSpawner;
    [Token(Token = "0x4003AD3")]
    [FieldOffset(Offset = "0x38")]
    private string assetBundleName;
    [Token(Token = "0x4003AD4")]
    [FieldOffset(Offset = "0x40")]
    private string assetName;
    [Token(Token = "0x4003AD5")]
    [FieldOffset(Offset = "0x48")]
    private bool notOpen;
    [Token(Token = "0x4003AD6")]
    [FieldOffset(Offset = "0x49")]
    public bool IsProcessing;
    [Token(Token = "0x4003AD7")]
    [FieldOffset(Offset = "0x50")]
    private List<int> idList;

    [Token(Token = "0x17000B0D")]
    private List<int> IdList
    {
      [Token(Token = "0x6004B82"), Address(RVA = "0x32E6430", Offset = "0x32E6430", VA = "0x32E6430")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6004B83")]
    [Address(RVA = "0x32E6694", Offset = "0x32E6694", VA = "0x32E6694")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6004B84")]
    [Address(RVA = "0x32E6704", Offset = "0x32E6704", VA = "0x32E6704")]
    private void DeleteFile()
    {
    }

    [Token(Token = "0x6004B85")]
    [Address(RVA = "0x32E6734", Offset = "0x32E6734", VA = "0x32E6734")]
    public void Delete()
    {
    }

    [Token(Token = "0x6004B86")]
    [Address(RVA = "0x32E6754", Offset = "0x32E6754", VA = "0x32E6754")]
    public Adv2Manager.OnProccessSignal LuaLoadPopup(Adv2Loader loader)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6004B87")]
    [Address(RVA = "0x32E677C", Offset = "0x32E677C", VA = "0x32E677C")]
    public void SetTutorialPopupPrefab(GameObject prefab)
    {
    }

    [Token(Token = "0x6004B88")]
    [Address(RVA = "0x32E6784", Offset = "0x32E6784", VA = "0x32E6784")]
    private void InitAssetCachedSpawner()
    {
    }

    [Token(Token = "0x6004B89")]
    [Address(RVA = "0x32E6878", Offset = "0x32E6878", VA = "0x32E6878")]
    public LuaSignalMini LuaCreatePopup(Transform parent, int tutorialId) => (LuaSignalMini) null;

    [Token(Token = "0x6004B8A")]
    [Address(RVA = "0x32E6B80", Offset = "0x32E6B80", VA = "0x32E6B80")]
    private IEnumerator InitTutorialPopup(
      AssetCachedSpawner spawner,
      int tutorialId,
      Action callBack)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B8B")]
    [Address(RVA = "0x32E6C34", Offset = "0x32E6C34", VA = "0x32E6C34")]
    public void CreatePopup(Transform parent, int tutorialId, Action callBack = null)
    {
    }

    [Token(Token = "0x6004B8C")]
    [Address(RVA = "0x32E6D60", Offset = "0x32E6D60", VA = "0x32E6D60")]
    private void ClearAssetCachedSpawner()
    {
    }

    [Token(Token = "0x6004B8D")]
    [Address(RVA = "0x32E6D7C", Offset = "0x32E6D7C", VA = "0x32E6D7C")]
    public void OpenPopup(Action closeCallback = null)
    {
    }

    [Token(Token = "0x6004B8E")]
    [Address(RVA = "0x32E6F20", Offset = "0x32E6F20", VA = "0x32E6F20")]
    public bool TryCreateAndOpenPopup(int tutorialId, Action closeCallback = null, Transform parent = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004B8F")]
    [Address(RVA = "0x32E70E0", Offset = "0x32E70E0", VA = "0x32E70E0")]
    public void CreateAndOpenPopup(int tutorialId, Action closeCallback = null, Transform parent = null)
    {
    }

    [Token(Token = "0x6004B90")]
    [Address(RVA = "0x32E725C", Offset = "0x32E725C", VA = "0x32E725C")]
    public void ClosePopup()
    {
    }

    [Token(Token = "0x6004B91")]
    [Address(RVA = "0x32E6B18", Offset = "0x32E6B18", VA = "0x32E6B18")]
    public bool IsRead(int id) => new bool();

    [Token(Token = "0x6004B92")]
    [Address(RVA = "0x32E6454", Offset = "0x32E6454", VA = "0x32E6454")]
    public List<int> Load() => (List<int>) null;

    [Token(Token = "0x6004B93")]
    [Address(RVA = "0x32E4E64", Offset = "0x32E4E64", VA = "0x32E4E64")]
    public void Save(int id)
    {
    }

    [Token(Token = "0x6004B94")]
    [Address(RVA = "0x32E727C", Offset = "0x32E727C", VA = "0x32E727C")]
    public TutorialPopupManager()
    {
    }
  }
}
