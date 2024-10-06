// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.LostReviveProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200372D")]
  public class LostReviveProvider
  {
    [Token(Token = "0x400F0F0")]
    private const string ASSET_BUNDLE_LOSTREVIVE = "ui_page_characterlist";
    [Token(Token = "0x400F0F1")]
    private const string ASSET_LOSTREVIVE = "Container_Character_LostRevive";

    [Token(Token = "0x6015BCB")]
    [Address(RVA = "0x1B2288C", Offset = "0x1B2288C", VA = "0x1B2288C")]
    private static AssetSpawnOperation<GameObject> Request(
      AssetCachedSpawner spawner,
      CharacterLostRevive.eLostReviveMode mode,
      List<Character> chrDataList,
      int num,
      Action<CharacterLostRevive.eLostReviveState> finish,
      Action<CharacterLostRevive> callback = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6015BCC")]
    [Address(RVA = "0x1B229CC", Offset = "0x1B229CC", VA = "0x1B229CC")]
    public static AssetSpawnOperation<GameObject> RequestRevive(
      AssetCachedSpawner spawner,
      List<Character> characters,
      Action<CharacterLostRevive.eLostReviveState> finish,
      Action<CharacterLostRevive> callback = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6015BCD")]
    [Address(RVA = "0x1B229E4", Offset = "0x1B229E4", VA = "0x1B229E4")]
    public static IEnumerator RequestReviveAndWait(
      AssetCachedSpawner spawner,
      List<Character> characters,
      Action<CharacterLostRevive.eLostReviveState> finish,
      Action<CharacterLostRevive> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015BCE")]
    [Address(RVA = "0x1B22A94", Offset = "0x1B22A94", VA = "0x1B22A94")]
    public static AssetSpawnOperation<GameObject> RequestLostRevive(
      AssetCachedSpawner spawner,
      Character character,
      int num,
      Action<CharacterLostRevive.eLostReviveState> finish,
      Action<CharacterLostRevive> callback = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6015BCF")]
    [Address(RVA = "0x1B22BA8", Offset = "0x1B22BA8", VA = "0x1B22BA8")]
    public static IEnumerator RequestLostReviveAndWait(
      AssetCachedSpawner spawner,
      Character character,
      int num,
      Action<CharacterLostRevive.eLostReviveState> finish,
      Action<CharacterLostRevive> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015BD0")]
    [Address(RVA = "0x1B22C60", Offset = "0x1B22C60", VA = "0x1B22C60")]
    public LostReviveProvider()
    {
    }
  }
}
