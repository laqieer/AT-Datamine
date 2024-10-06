// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.IEquipmentListAssetLoader
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
  [Token(Token = "0x200398A")]
  public interface IEquipmentListAssetLoader
  {
    [Token(Token = "0x60169D0")]
    AssetSpawnOperationBase LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object;

    [Token(Token = "0x60169D1")]
    AssetSpawnOperationBase LoadThumbnailSprite(Equipment equipment, Action<Sprite> onComplete);

    [Token(Token = "0x60169D2")]
    AssetSpawnOperationBase LoadRarityIconSprite(Equipment equipment, Action<Sprite> onComplete);

    [Token(Token = "0x60169D3")]
    AssetSpawnOperationBase LoadRarityBaseSprite(Equipment equipment, Action<Sprite> onComplete);

    [Token(Token = "0x60169D4")]
    void CancelRequest(AssetSpawnOperationBase op);
  }
}
