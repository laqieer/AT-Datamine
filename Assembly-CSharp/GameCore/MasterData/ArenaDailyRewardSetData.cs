// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE9")]
  [Serializable]
  public sealed class ArenaDailyRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x4004286")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004287")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004288")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int arenaDailyRewardTerm;
    [Token(Token = "0x4004289")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int fromRanking;
    [Token(Token = "0x400428A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int toRanking;

    [Token(Token = "0x17000C34")]
    public int Key
    {
      [Token(Token = "0x60054EA"), Address(RVA = "0x3AA9564", Offset = "0x3AA9564", VA = "0x3AA9564", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054EB")]
    [Address(RVA = "0x3AA956C", Offset = "0x3AA956C", VA = "0x3AA956C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054EC")]
    [Address(RVA = "0x3AA9798", Offset = "0x3AA9798", VA = "0x3AA9798", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054ED")]
    [Address(RVA = "0x3AA9850", Offset = "0x3AA9850", VA = "0x3AA9850")]
    public ArenaDailyRewardSetData()
    {
    }
  }
}
