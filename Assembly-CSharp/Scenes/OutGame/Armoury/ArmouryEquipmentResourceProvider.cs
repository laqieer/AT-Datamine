// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryEquipmentResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003810")]
  internal class ArmouryEquipmentResourceProvider : IArmouryResourceProvider
  {
    [Token(Token = "0x400F4CD")]
    [FieldOffset(Offset = "0x10")]
    private readonly IEquipmentListAssetLoader loader;
    [Token(Token = "0x400F4CE")]
    [FieldOffset(Offset = "0x18")]
    private readonly Equipment equipment;

    [Token(Token = "0x60160D0")]
    [Address(RVA = "0x20EE788", Offset = "0x20EE788", VA = "0x20EE788")]
    public ArmouryEquipmentResourceProvider(IEquipmentListAssetLoader loader, Equipment equipment)
    {
    }

    [Token(Token = "0x60160D1")]
    [Address(RVA = "0x20EE7B4", Offset = "0x20EE7B4", VA = "0x20EE7B4", Slot = "4")]
    public AssetSpawnOperationBase LoadThumbnailSprite(Image thumbnailImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160D2")]
    [Address(RVA = "0x20EE8EC", Offset = "0x20EE8EC", VA = "0x20EE8EC", Slot = "5")]
    public AssetSpawnOperationBase LoadRarityBaseSprite(Image rarityBaseImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160D3")]
    [Address(RVA = "0x20EEA24", Offset = "0x20EEA24", VA = "0x20EEA24", Slot = "6")]
    public AssetSpawnOperationBase LoadRaritySprite(Image rarityImage)
    {
      return (AssetSpawnOperationBase) null;
    }

    [Token(Token = "0x60160D4")]
    [Address(RVA = "0x20EEB5C", Offset = "0x20EEB5C", VA = "0x20EEB5C", Slot = "7")]
    public void DoCancelRequest(AssetSpawnOperationBase op)
    {
    }
  }
}
