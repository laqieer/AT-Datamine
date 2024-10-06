// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerInfoLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo
{
  [Token(Token = "0x2003489")]
  public class PlayerInfoLoader
  {
    [Token(Token = "0x400E499")]
    private const string PREFAB_ASSET_BUNDLE_LABEL = "2dassets_ui_playerstatus";
    [Token(Token = "0x400E49A")]
    private const string CHARA_IMAGE_LABEL = "units_{0}";
    [Token(Token = "0x400E49B")]
    private const string PREFAB_UI_COMMON_LABEL = "2dassets_ui_common";
    [Token(Token = "0x400E49C")]
    private const string PREFAB_ASSET_BUNDLE_INFO = "PlayerStatus";
    [Token(Token = "0x400E49D")]
    private const string CHARA_IMAGE_NAME = "{0}_UnitImage_Full";
    [Token(Token = "0x400E49E")]
    private const string PREFAB_CONFIRMSTION_POPUP_NAME = "Com_Popup_ComConfirmation";
    [Token(Token = "0x400E49F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, bool> isLoadedAssetBundleMap;

    [Token(Token = "0x60149C6")]
    [Address(RVA = "0x1AAF394", Offset = "0x1AAF394", VA = "0x1AAF394")]
    private bool CheckLoadedAssetBundle(string label) => new bool();

    [Token(Token = "0x60149C7")]
    [Address(RVA = "0x1AAF428", Offset = "0x1AAF428", VA = "0x1AAF428")]
    private void UnloadAssetBundle(string label, bool canUnloadAssetBundle)
    {
    }

    [Token(Token = "0x60149C8")]
    [Address(RVA = "0x1AAF510", Offset = "0x1AAF510", VA = "0x1AAF510")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149C9")]
    [Address(RVA = "0x1AAF5B4", Offset = "0x1AAF5B4", VA = "0x1AAF5B4")]
    public IEnumerator LoadPlayerStatusObj(
      RectTransform parent,
      Action<GameObject> playerStatusAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149CA")]
    [Address(RVA = "0x1AAF2C8", Offset = "0x1AAF2C8", VA = "0x1AAF2C8")]
    public IEnumerator LoadPlayer2DImage(int targetCharaId, Action<Sprite> player2DImageAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149CB")]
    [Address(RVA = "0x1AADC14", Offset = "0x1AADC14", VA = "0x1AADC14")]
    public IEnumerator LoadConfirmationPopup(Action<ConfirmationPopup> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149CC")]
    private IEnumerator LoadDLC<T>(
      string assetBundleLabel,
      string assetName,
      Action<T> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149CD")]
    [Address(RVA = "0x1AAE070", Offset = "0x1AAE070", VA = "0x1AAE070")]
    public IEnumerator LoadTextEditPopup(Action<TextEditPopup> loadedAction) => (IEnumerator) null;

    [Token(Token = "0x60149CE")]
    [Address(RVA = "0x1AAD920", Offset = "0x1AAD920", VA = "0x1AAD920")]
    public IEnumerator LoadCommentEditPopup(Action<TextEditPopup> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60149CF")]
    [Address(RVA = "0x1AAF6F8", Offset = "0x1AAF6F8", VA = "0x1AAF6F8")]
    public PlayerInfoLoader()
    {
    }
  }
}
