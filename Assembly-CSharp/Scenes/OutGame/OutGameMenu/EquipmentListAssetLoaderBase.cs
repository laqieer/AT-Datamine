// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.EquipmentListAssetLoaderBase
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
  [Token(Token = "0x2003988")]
  public abstract class EquipmentListAssetLoaderBase : IEquipmentListAssetLoader
  {
    [Token(Token = "0x400FB64")]
    [FieldOffset(Offset = "0x10")]
    protected AssetCachedSpawner assetLoader;

    [Token(Token = "0x60169C5")]
    [Address(RVA = "0x42F396C", Offset = "0x42F396C", VA = "0x42F396C")]
    public EquipmentListAssetLoaderBase(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x60169C6")]
    public AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60169C7")]
    [Address(RVA = "0x42F4990", Offset = "0x42F4990", VA = "0x42F4990", Slot = "5")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60169C8")]
    [Address(RVA = "0x42F4A20", Offset = "0x42F4A20", VA = "0x42F4A20", Slot = "6")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60169C9")]
    [Address(RVA = "0x42F4AF4", Offset = "0x42F4AF4", VA = "0x42F4AF4", Slot = "9")]
    public virtual AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60169CA")]
    [Address(RVA = "0x42F4BEC", Offset = "0x42F4BEC", VA = "0x42F4BEC", Slot = "8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }

    [Token(Token = "0x60169CB")]
    [Address(RVA = "0x42F4BF0", Offset = "0x42F4BF0", VA = "0x42F4BF0")]
    public void LoadSubMenuRarityIconSprite(Equipment equipment, Action<Sprite> onComplete)
    {
    }

    [Token(Token = "0x60169CC")]
    public abstract string ThumbnailAssetBundleName(Equipment equipment);

    [Token(Token = "0x60169CD")]
    public abstract string ThumbnailAssetName(Equipment equipment);
  }
}
