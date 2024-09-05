// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.IArmouryResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x200380F")]
  internal interface IArmouryResourceProvider
  {
    [Token(Token = "0x60160CC")]
    AssetSpawnOperationBase LoadThumbnailSprite(Image thumbnailImage);

    [Token(Token = "0x60160CD")]
    AssetSpawnOperationBase LoadRarityBaseSprite(Image rarityBaseImage);

    [Token(Token = "0x60160CE")]
    AssetSpawnOperationBase LoadRaritySprite(Image rarityImage);

    [Token(Token = "0x60160CF")]
    void DoCancelRequest(AssetSpawnOperationBase op);
  }
}
