// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.WeaponListAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003998")]
  public class WeaponListAssetLoader : EquipmentListAssetLoaderBase
  {
    [Token(Token = "0x6016A10")]
    [Address(RVA = "0x3F5DF64", Offset = "0x3F5DF64", VA = "0x3F5DF64")]
    public WeaponListAssetLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x6016A11")]
    [Address(RVA = "0x3F5DF6C", Offset = "0x3F5DF6C", VA = "0x3F5DF6C", Slot = "10")]
    public override string ThumbnailAssetBundleName(Equipment equipment) => (string) null;

    [Token(Token = "0x6016A12")]
    [Address(RVA = "0x3F5DF8C", Offset = "0x3F5DF8C", VA = "0x3F5DF8C", Slot = "11")]
    public override string ThumbnailAssetName(Equipment equipment) => (string) null;

    [Token(Token = "0x6016A13")]
    [Address(RVA = "0x3F5DFAC", Offset = "0x3F5DFAC", VA = "0x3F5DFAC")]
    private void LoadTypeIconAtlas(
      string spriteAtlasAssetBundleName,
      string spriteAtlasAssetName,
      Action<SpriteAtlas> onComplete)
    {
    }

    [Token(Token = "0x6016A14")]
    [Address(RVA = "0x3F5E01C", Offset = "0x3F5E01C", VA = "0x3F5E01C")]
    public void LoadSubMenuWeaponIconSprite(Weapon weapon, Action<Sprite> onComplete)
    {
    }

    [Token(Token = "0x6016A15")]
    [Address(RVA = "0x3F5E164", Offset = "0x3F5E164", VA = "0x3F5E164")]
    public void LoadMenuWeaponIconSprite(Weapon weapon, Action<Sprite> onComplete)
    {
    }
  }
}
