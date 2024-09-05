// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.KilledSpecifiedUnitScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200111E")]
  [Serializable]
  public sealed class KilledSpecifiedUnitScoreData : IMasterDataEntity
  {
    [Token(Token = "0x400534F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005350")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005351")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int npc_id;
    [Token(Token = "0x4005352")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int score;

    [Token(Token = "0x17000EB7")]
    public int Key
    {
      [Token(Token = "0x6006287"), Address(RVA = "0x4ADFB84", Offset = "0x4ADFB84", VA = "0x4ADFB84", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006288")]
    [Address(RVA = "0x4ADFB8C", Offset = "0x4ADFB8C", VA = "0x4ADFB8C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006289")]
    [Address(RVA = "0x4ADFD58", Offset = "0x4ADFD58", VA = "0x4ADFD58", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600628A")]
    [Address(RVA = "0x4ADFDFC", Offset = "0x4ADFDFC", VA = "0x4ADFDFC")]
    public KilledSpecifiedUnitScoreData()
    {
    }
  }
}
