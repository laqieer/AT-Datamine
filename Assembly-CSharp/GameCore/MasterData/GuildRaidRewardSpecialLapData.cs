// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSpecialLapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001001")]
  [Serializable]
  public sealed class GuildRaidRewardSpecialLapData : IMasterDataEntity
  {
    [Token(Token = "0x4004FCE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FCF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000DC0")]
    public int Key
    {
      [Token(Token = "0x6005D50"), Address(RVA = "0x2792994", Offset = "0x2792994", VA = "0x2792994", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D51")]
    [Address(RVA = "0x279299C", Offset = "0x279299C", VA = "0x279299C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D52")]
    [Address(RVA = "0x2792AA8", Offset = "0x2792AA8", VA = "0x2792AA8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D53")]
    [Address(RVA = "0x2792B30", Offset = "0x2792B30", VA = "0x2792B30")]
    public GuildRaidRewardSpecialLapData()
    {
    }
  }
}
