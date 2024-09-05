// Decompiled with JetBrains decompiler
// Type: Gacha.RewardListItemStylePresenter
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
  [Token(Token = "0x2001566")]
  internal class RewardListItemStylePresenter : IRewardListItemPresenter
  {
    [Token(Token = "0x4006232")]
    [FieldOffset(Offset = "0x10")]
    private (string assetBundleName, string assetName) fullImageAssetInfo;
    [Token(Token = "0x4006233")]
    [FieldOffset(Offset = "0x20")]
    private Sprite fullImageSprite;
    [Token(Token = "0x4006234")]
    [FieldOffset(Offset = "0x28")]
    private GachaResultDetailInfo detailInfo;

    [Token(Token = "0x6007925")]
    [Address(RVA = "0x2293F78", Offset = "0x2293F78", VA = "0x2293F78")]
    public RewardListItemStylePresenter(GachaResultDetailInfo detailInfo)
    {
    }

    [Token(Token = "0x6007926")]
    [Address(RVA = "0x2294584", Offset = "0x2294584", VA = "0x2294584", Slot = "4")]
    public void AssignView(GachaResultRewardListItemView view)
    {
    }

    [Token(Token = "0x6007927")]
    [Address(RVA = "0x22945FC", Offset = "0x22945FC", VA = "0x22945FC", Slot = "5")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }
  }
}
