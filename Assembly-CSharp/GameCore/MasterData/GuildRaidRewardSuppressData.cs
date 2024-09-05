// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSuppressData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001009")]
  [Serializable]
  public sealed class GuildRaidRewardSuppressData : IMasterDataEntity
  {
    [Token(Token = "0x4004FE0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FE1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000DC3")]
    public int Key
    {
      [Token(Token = "0x6005D72"), Address(RVA = "0x2793A2C", Offset = "0x2793A2C", VA = "0x2793A2C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D73")]
    [Address(RVA = "0x2793A34", Offset = "0x2793A34", VA = "0x2793A34", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D74")]
    [Address(RVA = "0x2793B40", Offset = "0x2793B40", VA = "0x2793B40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D75")]
    [Address(RVA = "0x2793BC8", Offset = "0x2793BC8", VA = "0x2793BC8")]
    public GuildRaidRewardSuppressData()
    {
    }
  }
}
