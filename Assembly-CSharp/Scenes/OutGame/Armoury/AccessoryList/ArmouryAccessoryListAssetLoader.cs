// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.ArmouryAccessoryListAssetLoader
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
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x20038A4")]
  internal class ArmouryAccessoryListAssetLoader : IEquipmentListAssetLoader
  {
    [Token(Token = "0x400F7C8")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner spawner;

    [Token(Token = "0x6016448")]
    [Address(RVA = "0x1DFC9C4", Offset = "0x1DFC9C4", VA = "0x1DFC9C4")]
    public ArmouryAccessoryListAssetLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016449")]
    public AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x601644A")]
    [Address(RVA = "0x1E00978", Offset = "0x1E00978", VA = "0x1E00978", Slot = "5")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x601644B")]
    [Address(RVA = "0x1E00A0C", Offset = "0x1E00A0C", VA = "0x1E00A0C", Slot = "6")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x601644C")]
    [Address(RVA = "0x1E00B0C", Offset = "0x1E00B0C", VA = "0x1E00B0C", Slot = "7")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x601644D")]
    [Address(RVA = "0x1E00BF4", Offset = "0x1E00BF4", VA = "0x1E00BF4", Slot = "8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
