// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE1")]
  [Serializable]
  public sealed class ArenaNpcData : IMasterDataEntity
  {
    [Token(Token = "0x400426A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400426B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rankingFloor;
    [Token(Token = "0x400426C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int nameGroup;
    [Token(Token = "0x400426D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int deckGroup;
    [Token(Token = "0x400426E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int unitCount;
    [Token(Token = "0x400426F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int statusRate;
    [Token(Token = "0x4004270")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int statusFixed;
    [Token(Token = "0x4004271")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int hpRate;
    [Token(Token = "0x4004272")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int hpFixed;
    [Token(Token = "0x4004273")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int skillLevelFixed;
    [Token(Token = "0x4004274")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int supportRank;
    [Token(Token = "0x4004275")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int playerRank;
    [Token(Token = "0x4004276")]
    [FieldOffset(Offset = "0x40")]
    public int ranking;

    [Token(Token = "0x17000C30")]
    public int Key
    {
      [Token(Token = "0x60054C7"), Address(RVA = "0x3AA7F24", Offset = "0x3AA7F24", VA = "0x3AA7F24", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054C8")]
    [Address(RVA = "0x3AA7F2C", Offset = "0x3AA7F2C", VA = "0x3AA7F2C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054C9")]
    [Address(RVA = "0x3AA83F8", Offset = "0x3AA83F8", VA = "0x3AA83F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054CA")]
    [Address(RVA = "0x3AA851C", Offset = "0x3AA851C", VA = "0x3AA851C")]
    public string GenerateName() => (string) null;

    [Token(Token = "0x60054CB")]
    [Address(RVA = "0x3AA8634", Offset = "0x3AA8634", VA = "0x3AA8634")]
    public List<int> GenerateUnitParty() => (List<int>) null;

    [Token(Token = "0x60054CC")]
    [Address(RVA = "0x3AA8838", Offset = "0x3AA8838", VA = "0x3AA8838")]
    public ArenaNpcData()
    {
    }
  }
}
