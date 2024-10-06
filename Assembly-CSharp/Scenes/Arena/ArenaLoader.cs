// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x20030FD")]
  public class ArenaLoader
  {
    [Token(Token = "0x400D090")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner assetLoader;

    [Token(Token = "0x6013245")]
    [Address(RVA = "0x45DEB38", Offset = "0x45DEB38", VA = "0x45DEB38")]
    public ArenaLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x6013246")]
    [Address(RVA = "0x45DEB60", Offset = "0x45DEB60", VA = "0x45DEB60")]
    public IEnumerator Request(
      ArenaAssetBundleParam.ArenaScreenType type,
      Action<GameObject> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013247")]
    [Address(RVA = "0x45DEC04", Offset = "0x45DEC04", VA = "0x45DEC04")]
    public IEnumerator Request(
      ArenaAssetBundleParam.TimelineSettingType type,
      Action<UITimelineSettingAsset> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013248")]
    [Address(RVA = "0x45DECA8", Offset = "0x45DECA8", VA = "0x45DECA8")]
    public IEnumerator Request(
      ArenaAssetBundleParam.ArenaPopupType type,
      Action<GameObject> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013249")]
    public IEnumerator Request<T>(string assetBundleName, string assetName, Action<T> onComplete) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601324A")]
    public IEnumerator Request<T>(
      (string assetBundleName, string assetName)[] requests,
      Action<T[]> onComplete)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }
  }
}
