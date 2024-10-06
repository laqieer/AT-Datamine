// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopArticleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001192")]
  [Serializable]
  public sealed class StoryShopArticleData : IMasterDataEntity
  {
    [Token(Token = "0x40054C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054C9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ShopTypeEnum shopTypeID;
    [Token(Token = "0x40054CA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int shopLevel;
    [Token(Token = "0x40054CB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int showPriority;
    [Token(Token = "0x40054CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardTypeID;
    [Token(Token = "0x40054CD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40054CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x40054CF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paymentTypeID;
    [Token(Token = "0x40054D0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int paymentID;
    [Token(Token = "0x40054D1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int paymentAmount;
    [Token(Token = "0x40054D2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int storyRouteID;
    [Token(Token = "0x40054D3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int purchaseLimitByAccount;
    [Token(Token = "0x40054D4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int purchaseLimitTypeID;
    [Token(Token = "0x40054D5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int purchaseLimitCount;

    [Token(Token = "0x17000F41")]
    public int Key
    {
      [Token(Token = "0x60064E0"), Address(RVA = "0x4AF3710", Offset = "0x4AF3710", VA = "0x4AF3710", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064E1")]
    [Address(RVA = "0x4AF3718", Offset = "0x4AF3718", VA = "0x4AF3718", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064E2")]
    [Address(RVA = "0x4AF3CA4", Offset = "0x4AF3CA4", VA = "0x4AF3CA4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064E3")]
    [Address(RVA = "0x4AF3DE8", Offset = "0x4AF3DE8", VA = "0x4AF3DE8")]
    public StoryShopArticleData()
    {
    }
  }
}
