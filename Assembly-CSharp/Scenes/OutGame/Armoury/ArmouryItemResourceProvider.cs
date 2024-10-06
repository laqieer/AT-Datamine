// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryItemResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury.ItemList;
using StaqData;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003814")]
  internal class ArmouryItemResourceProvider : IArmouryResourceProvider
  {
    [Token(Token = "0x400F4D2")]
    [FieldOffset(Offset = "0x10")]
    private readonly ItemListAssetLoader loader;
    [Token(Token = "0x400F4D3")]
    [FieldOffset(Offset = "0x18")]
    private readonly ItemUtility.Parameter itemParam;

    [Token(Token = "0x60160DB")]
    [Address(RVA = "0x20EECC8", Offset = "0x20EECC8", VA = "0x20EECC8")]
    public ArmouryItemResourceProvider(ItemListAssetLoader loader, ItemUtility.Parameter itemParam)
    {
    }

    [Token(Token = "0x60160DC")]
    [Address(RVA = "0x20EED04", Offset = "0x20EED04", VA = "0x20EED04", Slot = "4")]
    public AssetSpawnOperationBase LoadThumbnailSprite(Image thumbnailImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160DD")]
    [Address(RVA = "0x20EEE04", Offset = "0x20EEE04", VA = "0x20EEE04", Slot = "5")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(Image rarityBaseImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160DE")]
    [Address(RVA = "0x20EEF04", Offset = "0x20EEF04", VA = "0x20EEF04", Slot = "6")]
    public AssetSpawnOperationBase LoadRaritySprite(Image rarityImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160DF")]
    [Address(RVA = "0x20EF038", Offset = "0x20EF038", VA = "0x20EF038", Slot = "7")]
    public void DoCancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
