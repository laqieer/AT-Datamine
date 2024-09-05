// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200100C")]
  [Serializable]
  public sealed class GuildRaidData : IMasterDataEntity
  {
    [Token(Token = "0x4004FE3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FE4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004FE5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4004FE6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x4004FE7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime openAt;
    [Token(Token = "0x4004FE8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime closeAt;
    [Token(Token = "0x4004FE9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int lapRewardID;
    [Token(Token = "0x4004FEA")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int specialLapRewardID;
    [Token(Token = "0x4004FEB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int epItemID;
    [Token(Token = "0x4004FEC")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int epMaxCount;
    [Token(Token = "0x4004FED")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string bgmPackName;
    [Token(Token = "0x4004FEE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string bgmEventName;

    [Token(Token = "0x17000DC4")]
    public int Key
    {
      [Token(Token = "0x6005D7F"), Address(RVA = "0x2794214", Offset = "0x2794214", VA = "0x2794214", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D80")]
    [Address(RVA = "0x279421C", Offset = "0x279421C", VA = "0x279421C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D81")]
    [Address(RVA = "0x27946E8", Offset = "0x27946E8", VA = "0x27946E8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D82")]
    [Address(RVA = "0x27948A8", Offset = "0x27948A8", VA = "0x27948A8")]
    public GuildRaidData()
    {
    }
  }
}
