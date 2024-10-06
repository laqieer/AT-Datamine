// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MindequipmentListAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x200398B")]
  public class MindequipmentListAssetLoader : EquipmentListAssetLoaderBase
  {
    [Token(Token = "0x60169D5")]
    [Address(RVA = "0x42F4DF8", Offset = "0x42F4DF8", VA = "0x42F4DF8")]
    public MindequipmentListAssetLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x60169D6")]
    [Address(RVA = "0x42F4E20", Offset = "0x42F4E20", VA = "0x42F4E20", Slot = "10")]
    public override string ThumbnailAssetBundleName(Equipment equipment) => (string) null;

    [Token(Token = "0x60169D7")]
    [Address(RVA = "0x42F4E3C", Offset = "0x42F4E3C", VA = "0x42F4E3C", Slot = "11")]
    public override string ThumbnailAssetName(Equipment equipment) => (string) null;

    [Token(Token = "0x60169D8")]
    [Address(RVA = "0x42F4E58", Offset = "0x42F4E58", VA = "0x42F4E58", Slot = "9")]
    public override AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }
  }
}
