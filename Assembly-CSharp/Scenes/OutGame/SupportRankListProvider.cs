// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SupportRankListProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003279")]
  public class SupportRankListProvider
  {
    [Token(Token = "0x400D822")]
    private const string ASSET_BUNDLE_NAME = "ui_page_outgame_supportlist_prefab";
    [Token(Token = "0x400D823")]
    private const string ASSET_NAME = "Container_Support_List";

    [Token(Token = "0x6013B18")]
    [Address(RVA = "0x18560A4", Offset = "0x18560A4", VA = "0x18560A4")]
    public static AssetSpawnOperation<GameObject> Request(
      AssetCachedSpawner spawner,
      int characterId,
      Action<SupportRankList> callback = null,
      Transform parent = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6013B19")]
    [Address(RVA = "0x18561C8", Offset = "0x18561C8", VA = "0x18561C8")]
    public static IEnumerator RequestAndWait(
      AssetCachedSpawner spawner,
      int characterId,
      Action<SupportRankList> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013B1A")]
    [Address(RVA = "0x185626C", Offset = "0x185626C", VA = "0x185626C")]
    public SupportRankListProvider()
    {
    }
  }
}
