// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.ItemListAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x200386B")]
  internal class ItemListAssetLoader
  {
    [Token(Token = "0x400F65B")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60162D3")]
    [Address(RVA = "0x1DEF9B0", Offset = "0x1DEF9B0", VA = "0x1DEF9B0")]
    public ItemListAssetLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60162D4")]
    private AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60162D5")]
    [Address(RVA = "0x1DEF9D8", Offset = "0x1DEF9D8", VA = "0x1DEF9D8")]
    public AssetSpawnOperationBase LoadThumbnailSprite(
      ItemUtility.Parameter param,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60162D6")]
    [Address(RVA = "0x1DEFA38", Offset = "0x1DEFA38", VA = "0x1DEFA38")]
    public AssetSpawnOperationBase LoadRarityIconSprite(
      ItemUtility.Parameter param,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60162D7")]
    [Address(RVA = "0x1DEFB28", Offset = "0x1DEFB28", VA = "0x1DEFB28")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(
      ItemUtility.Parameter param,
      Action<Sprite> onComplete)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60162D8")]
    [Address(RVA = "0x1DEFBF8", Offset = "0x1DEFBF8", VA = "0x1DEFBF8")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
