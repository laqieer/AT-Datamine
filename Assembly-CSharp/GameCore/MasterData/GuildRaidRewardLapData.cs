// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardLapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FFA")]
  [Serializable]
  public sealed class GuildRaidRewardLapData : IMasterDataEntity
  {
    [Token(Token = "0x4004FC2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FC3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000DBE")]
    public int Key
    {
      [Token(Token = "0x6005D37"), Address(RVA = "0x2791BB4", Offset = "0x2791BB4", VA = "0x2791BB4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D38")]
    [Address(RVA = "0x2791BBC", Offset = "0x2791BBC", VA = "0x2791BBC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D39")]
    [Address(RVA = "0x2791CC8", Offset = "0x2791CC8", VA = "0x2791CC8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D3A")]
    [Address(RVA = "0x2791D50", Offset = "0x2791D50", VA = "0x2791D50")]
    public GuildRaidRewardLapData()
    {
    }
  }
}
