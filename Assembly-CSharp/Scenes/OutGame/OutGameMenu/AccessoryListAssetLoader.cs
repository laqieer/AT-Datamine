// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.AccessoryListAssetLoader
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
  [Token(Token = "0x2003982")]
  public class AccessoryListAssetLoader : EquipmentListAssetLoaderBase
  {
    [Token(Token = "0x60169AE")]
    [Address(RVA = "0x42F3944", Offset = "0x42F3944", VA = "0x42F3944")]
    public AccessoryListAssetLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x60169AF")]
    [Address(RVA = "0x42F3994", Offset = "0x42F3994", VA = "0x42F3994", Slot = "10")]
    public override string ThumbnailAssetBundleName(Equipment equipment) => (string) null;

    [Token(Token = "0x60169B0")]
    [Address(RVA = "0x42F39B4", Offset = "0x42F39B4", VA = "0x42F39B4", Slot = "11")]
    public override string ThumbnailAssetName(Equipment equipment) => (string) null;

    [Token(Token = "0x60169B1")]
    [Address(RVA = "0x42F39D4", Offset = "0x42F39D4", VA = "0x42F39D4")]
    private void LoadTypeIconAtlas(Action<SpriteAtlas> onComplete)
    {
    }

    [Token(Token = "0x60169B2")]
    [Address(RVA = "0x42F3A64", Offset = "0x42F3A64", VA = "0x42F3A64")]
    public void LoadSubMenuAccessoryIconSprite(Accessory accessory, Action<Sprite> onComplete)
    {
    }
  }
}
