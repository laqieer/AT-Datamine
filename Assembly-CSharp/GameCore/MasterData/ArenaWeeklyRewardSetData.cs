// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF1")]
  [Serializable]
  public sealed class ArenaWeeklyRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x4004299")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400429A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400429B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int ArenaWeeklyRewardTerm;
    [Token(Token = "0x400429C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int fromRanking;
    [Token(Token = "0x400429D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int toRanking;

    [Token(Token = "0x17000C38")]
    public int Key
    {
      [Token(Token = "0x600550A"), Address(RVA = "0x3AAA538", Offset = "0x3AAA538", VA = "0x3AAA538", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600550B")]
    [Address(RVA = "0x3AAA540", Offset = "0x3AAA540", VA = "0x3AAA540", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600550C")]
    [Address(RVA = "0x3AAA76C", Offset = "0x3AAA76C", VA = "0x3AAA76C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600550D")]
    [Address(RVA = "0x3AAA824", Offset = "0x3AAA824", VA = "0x3AAA824")]
    public ArenaWeeklyRewardSetData()
    {
    }
  }
}
