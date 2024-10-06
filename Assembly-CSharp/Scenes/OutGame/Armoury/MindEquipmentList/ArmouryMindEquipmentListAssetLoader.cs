// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.ArmouryMindEquipmentListAssetLoader
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
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x200384D")]
  internal class ArmouryMindEquipmentListAssetLoader : IEquipmentListAssetLoader
  {
    [Token(Token = "0x400F5CA")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6016215")]
    [Address(RVA = "0x20F91AC", Offset = "0x20F91AC", VA = "0x20F91AC")]
    public ArmouryMindEquipmentListAssetLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016216")]
    public AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016217")]
    [Address(RVA = "0x20F91D4", Offset = "0x20F91D4", VA = "0x20F91D4", Slot = "5")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016218")]
    [Address(RVA = "0x20F9254", Offset = "0x20F9254", VA = "0x20F9254", Slot = "6")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016219")]
    [Address(RVA = "0x20F944C", Offset = "0x20F944C", VA = "0x20F944C", Slot = "7")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x601621A")]
    [Address(RVA = "0x20F9454", Offset = "0x20F9454", VA = "0x20F9454", Slot = "8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }

    [Token(Token = "0x601621B")]
    [Address(RVA = "0x20F92EC", Offset = "0x20F92EC", VA = "0x20F92EC")]
    private AssetSpawnOperationBase LoadSpriteFromSpriteAtlas(
      string assetName,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }
  }
}
