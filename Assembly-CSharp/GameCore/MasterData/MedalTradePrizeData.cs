// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradePrizeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200117D")]
  [Serializable]
  public sealed class MedalTradePrizeData : IMasterDataEntity
  {
    [Token(Token = "0x4005493")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005494")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int shopID;
    [Token(Token = "0x4005495")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int medalID;
    [Token(Token = "0x4005496")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentAmount;
    [Token(Token = "0x4005497")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int tradeLimit;
    [Token(Token = "0x4005498")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int showPriority;
    [Token(Token = "0x4005499")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int setIconID;
    [Token(Token = "0x400549A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string setArticlesName;

    [Token(Token = "0x17000F38")]
    public int Key
    {
      [Token(Token = "0x600648C"), Address(RVA = "0x4AF05F4", Offset = "0x4AF05F4", VA = "0x4AF05F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600648D")]
    [Address(RVA = "0x4AF05FC", Offset = "0x4AF05FC", VA = "0x4AF05FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600648E")]
    [Address(RVA = "0x4AF0948", Offset = "0x4AF0948", VA = "0x4AF0948", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600648F")]
    [Address(RVA = "0x4AF0A30", Offset = "0x4AF0A30", VA = "0x4AF0A30")]
    public MedalTradePrizeData()
    {
    }
  }
}
