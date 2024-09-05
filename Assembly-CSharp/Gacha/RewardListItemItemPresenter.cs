// Decompiled with JetBrains decompiler
// Type: Gacha.RewardListItemItemPresenter
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
  [Token(Token = "0x2001563")]
  internal class RewardListItemItemPresenter : IRewardListItemPresenter
  {
    [Token(Token = "0x4006227")]
    [FieldOffset(Offset = "0x10")]
    private Sprite iconImageSprite;
    [Token(Token = "0x4006228")]
    [FieldOffset(Offset = "0x18")]
    private ItemUtility.Parameter parameter;
    [Token(Token = "0x4006229")]
    [FieldOffset(Offset = "0x78")]
    private GachaResultDetailInfo detailInfo;

    [Token(Token = "0x6007918")]
    [Address(RVA = "0x22940A4", Offset = "0x22940A4", VA = "0x22940A4")]
    public RewardListItemItemPresenter(GachaResultDetailInfo detailInfo)
    {
    }

    [Token(Token = "0x6007919")]
    [Address(RVA = "0x2294118", Offset = "0x2294118", VA = "0x2294118", Slot = "4")]
    public void AssignView(GachaResultRewardListItemView view)
    {
    }

    [Token(Token = "0x600791A")]
    [Address(RVA = "0x22941A4", Offset = "0x22941A4", VA = "0x22941A4", Slot = "5")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }
  }
}
