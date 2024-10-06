// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.GuildLoader
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
namespace Scenes.Guild
{
  [Token(Token = "0x2002B77")]
  public class GuildLoader
  {
    [Token(Token = "0x400B90E")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner assetLoader;

    [Token(Token = "0x17003AA6")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x6010FD2"), Address(RVA = "0x1C73694", Offset = "0x1C73694", VA = "0x1C73694")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6010FD3")]
    [Address(RVA = "0x1C7369C", Offset = "0x1C7369C", VA = "0x1C7369C")]
    public GuildLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x6010FD4")]
    [Address(RVA = "0x1C736C4", Offset = "0x1C736C4", VA = "0x1C736C4")]
    public IEnumerator LoadRequest(
      GuildAssetBundleParam.GuildScreenType type,
      Action<GameObject> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010FD5")]
    [Address(RVA = "0x1C73768", Offset = "0x1C73768", VA = "0x1C73768")]
    public IEnumerator LoadRequest(
      GuildAssetBundleParam.TimelineSettingType type,
      Action<UITimelineSettingAsset> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010FD6")]
    [Address(RVA = "0x1C7380C", Offset = "0x1C7380C", VA = "0x1C7380C")]
    public IEnumerator LoadRequest(
      GuildAssetBundleParam.GuildPopupType type,
      Action<GameObject> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010FD7")]
    public IEnumerator LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }
  }
}
