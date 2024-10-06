// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbySeasonData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001089")]
  [Serializable]
  public sealed class LobbySeasonData : IMasterDataEntity
  {
    [Token(Token = "0x40051B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime beginDate;
    [Token(Token = "0x40051B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endDate;
    [Token(Token = "0x40051BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public bool isEveryYear;

    [Token(Token = "0x17000E4C")]
    public int Key
    {
      [Token(Token = "0x6005FE1"), Address(RVA = "0x28D29D4", Offset = "0x28D29D4", VA = "0x28D29D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FE2")]
    [Address(RVA = "0x28D29DC", Offset = "0x28D29DC", VA = "0x28D29DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FE3")]
    [Address(RVA = "0x28D2C0C", Offset = "0x28D2C0C", VA = "0x28D2C0C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FE4")]
    [Address(RVA = "0x28D2D18", Offset = "0x28D2D18", VA = "0x28D2D18")]
    public LobbySeasonData()
    {
    }
  }
}
