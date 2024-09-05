// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.ArmouryWeaponListAssetLoader
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
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x2003826")]
  internal class ArmouryWeaponListAssetLoader : IEquipmentListAssetLoader
  {
    [Token(Token = "0x400F505")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner spawner;

    [Token(Token = "0x6016121")]
    [Address(RVA = "0x20F03D8", Offset = "0x20F03D8", VA = "0x20F03D8")]
    public ArmouryWeaponListAssetLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016122")]
    public AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016123")]
    [Address(RVA = "0x20F0400", Offset = "0x20F0400", VA = "0x20F0400", Slot = "5")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016124")]
    [Address(RVA = "0x20F0494", Offset = "0x20F0494", VA = "0x20F0494", Slot = "6")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016125")]
    [Address(RVA = "0x20F0594", Offset = "0x20F0594", VA = "0x20F0594", Slot = "7")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(
      Equipment equipment,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x6016126")]
    [Address(RVA = "0x20F067C", Offset = "0x20F067C", VA = "0x20F067C", Slot = "8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
