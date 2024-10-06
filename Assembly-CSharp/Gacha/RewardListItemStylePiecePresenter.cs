// Decompiled with JetBrains decompiler
// Type: Gacha.RewardListItemStylePiecePresenter
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
  [Token(Token = "0x2001565")]
  internal class RewardListItemStylePiecePresenter : IRewardListItemPresenter
  {
    [Token(Token = "0x400622D")]
    [FieldOffset(Offset = "0x10")]
    private (string assetBundleName, string assetName) fullImageAssetInfo;
    [Token(Token = "0x400622E")]
    [FieldOffset(Offset = "0x20")]
    private Sprite fullImageSprite;
    [Token(Token = "0x400622F")]
    [FieldOffset(Offset = "0x28")]
    private Sprite iconImageSprite;
    [Token(Token = "0x4006230")]
    [FieldOffset(Offset = "0x30")]
    private ItemUtility.Parameter parameter;
    [Token(Token = "0x4006231")]
    [FieldOffset(Offset = "0x90")]
    private GachaResultDetailInfo detailInfo;

    [Token(Token = "0x6007920")]
    [Address(RVA = "0x2293FC8", Offset = "0x2293FC8", VA = "0x2293FC8")]
    public RewardListItemStylePiecePresenter(GachaResultDetailInfo detailInfo)
    {
    }

    [Token(Token = "0x6007921")]
    [Address(RVA = "0x2294394", Offset = "0x2294394", VA = "0x2294394", Slot = "4")]
    public void AssignView(GachaResultRewardListItemView view)
    {
    }

    [Token(Token = "0x6007922")]
    [Address(RVA = "0x2294468", Offset = "0x2294468", VA = "0x2294468", Slot = "5")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }
  }
}
