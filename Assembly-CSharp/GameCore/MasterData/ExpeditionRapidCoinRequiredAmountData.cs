// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionRapidCoinRequiredAmountData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA6")]
  [Serializable]
  public sealed class ExpeditionRapidCoinRequiredAmountData : IMasterDataEntity
  {
    [Token(Token = "0x4004ED7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004ED8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int count;
    [Token(Token = "0x4004ED9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int coinRequiredAmount;

    [Token(Token = "0x17000D91")]
    public int Key
    {
      [Token(Token = "0x6005BE1"), Address(RVA = "0x2786F04", Offset = "0x2786F04", VA = "0x2786F04", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BE2")]
    [Address(RVA = "0x2786F0C", Offset = "0x2786F0C", VA = "0x2786F0C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BE3")]
    [Address(RVA = "0x2787078", Offset = "0x2787078", VA = "0x2787078", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BE4")]
    [Address(RVA = "0x278710C", Offset = "0x278710C", VA = "0x278710C")]
    public ExpeditionRapidCoinRequiredAmountData()
    {
    }
  }
}
