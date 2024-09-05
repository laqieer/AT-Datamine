// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ClearTurnScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200110C")]
  [Serializable]
  public sealed class ClearTurnScoreData : IMasterDataEntity
  {
    [Token(Token = "0x4005328")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005329")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x400532A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int turnFrom;
    [Token(Token = "0x400532B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int turnTo;
    [Token(Token = "0x400532C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int score;

    [Token(Token = "0x17000EA7")]
    public int Key
    {
      [Token(Token = "0x6006238"), Address(RVA = "0x4ADD930", Offset = "0x4ADD930", VA = "0x4ADD930", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006239")]
    [Address(RVA = "0x4ADD938", Offset = "0x4ADD938", VA = "0x4ADD938", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600623A")]
    [Address(RVA = "0x4ADDB64", Offset = "0x4ADDB64", VA = "0x4ADDB64", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600623B")]
    [Address(RVA = "0x4ADDC18", Offset = "0x4ADDC18", VA = "0x4ADDC18")]
    public ClearTurnScoreData()
    {
    }
  }
}
