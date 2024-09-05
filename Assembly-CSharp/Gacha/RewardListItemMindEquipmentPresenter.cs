// Decompiled with JetBrains decompiler
// Type: Gacha.RewardListItemMindEquipmentPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001564")]
  internal class RewardListItemMindEquipmentPresenter : IRewardListItemPresenter
  {
    [Token(Token = "0x400622A")]
    [FieldOffset(Offset = "0x10")]
    private (string assetBundleName, string assetName) imageAssetInfo;
    [Token(Token = "0x400622B")]
    [FieldOffset(Offset = "0x20")]
    private Sprite imageSprite;
    [Token(Token = "0x400622C")]
    [FieldOffset(Offset = "0x28")]
    private GachaResultDetailInfo detailInfo;

    [Token(Token = "0x600791C")]
    [Address(RVA = "0x2294054", Offset = "0x2294054", VA = "0x2294054")]
    public RewardListItemMindEquipmentPresenter(GachaResultDetailInfo detailInfo)
    {
    }

    [Token(Token = "0x600791D")]
    [Address(RVA = "0x2294260", Offset = "0x2294260", VA = "0x2294260", Slot = "4")]
    public void AssignView(GachaResultRewardListItemView view)
    {
    }

    [Token(Token = "0x600791E")]
    [Address(RVA = "0x22942D8", Offset = "0x22942D8", VA = "0x22942D8", Slot = "5")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }
  }
}
