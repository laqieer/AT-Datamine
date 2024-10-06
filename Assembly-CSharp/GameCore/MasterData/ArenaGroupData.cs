// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE5")]
  [Serializable]
  public sealed class ArenaGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004280")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004281")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4004282")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x4004283")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int hideUnitsRank;

    [Token(Token = "0x17000C32")]
    public int Key
    {
      [Token(Token = "0x60054DA"), Address(RVA = "0x3AA8EDC", Offset = "0x3AA8EDC", VA = "0x3AA8EDC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054DB")]
    [Address(RVA = "0x3AA8EE4", Offset = "0x3AA8EE4", VA = "0x3AA8EE4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054DC")]
    [Address(RVA = "0x3AA90B0", Offset = "0x3AA90B0", VA = "0x3AA90B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054DD")]
    [Address(RVA = "0x3AA91A8", Offset = "0x3AA91A8", VA = "0x3AA91A8")]
    public ArenaGroupData()
    {
    }
  }
}
