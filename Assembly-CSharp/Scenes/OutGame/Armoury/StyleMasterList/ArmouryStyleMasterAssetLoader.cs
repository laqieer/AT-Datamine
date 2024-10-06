// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.StyleMasterList.ArmouryStyleMasterAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.StyleMasterList
{
  [Token(Token = "0x200383B")]
  internal class ArmouryStyleMasterAssetLoader : IEquipmentListAssetLoader
  {
    [Token(Token = "0x400F573")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner spawner;

    [Token(Token = "0x60161A8")]
    [Address(RVA = "0x20F53B8", Offset = "0x20F53B8", VA = "0x20F53B8")]
    public ArmouryStyleMasterAssetLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60161A9")]
    public AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60161AA")]
    [Address(RVA = "0x20F53E0", Offset = "0x20F53E0", VA = "0x20F53E0", Slot = "5")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60161AB")]
    [Address(RVA = "0x20F546C", Offset = "0x20F546C", VA = "0x20F546C", Slot = "6")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60161AC")]
    [Address(RVA = "0x20F556C", Offset = "0x20F556C", VA = "0x20F556C", Slot = "7")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60161AD")]
    [Address(RVA = "0x20F5654", Offset = "0x20F5654", VA = "0x20F5654", Slot = "8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
