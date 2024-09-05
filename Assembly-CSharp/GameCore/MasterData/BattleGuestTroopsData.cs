// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleGuestTroopsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E50")]
  [Serializable]
  public sealed class BattleGuestTroopsData : IMasterDataEntity, ITroopsData
  {
    [Token(Token = "0x4004505")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004506")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004507")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4004508")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool initial;
    [Token(Token = "0x4004509")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    public bool quick;

    [Token(Token = "0x17000CB3")]
    public int Key
    {
      [Token(Token = "0x600571E"), Address(RVA = "0x3E3C1B4", Offset = "0x3E3C1B4", VA = "0x3E3C1B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600571F")]
    [Address(RVA = "0x3E3C1BC", Offset = "0x3E3C1BC", VA = "0x3E3C1BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005720")]
    [Address(RVA = "0x3E3C3F0", Offset = "0x3E3C3F0", VA = "0x3E3C3F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CB4")]
    public int Placement
    {
      [Token(Token = "0x6005721"), Address(RVA = "0x3E3C4A4", Offset = "0x3E3C4A4", VA = "0x3E3C4A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CB5")]
    public int Troops
    {
      [Token(Token = "0x6005722"), Address(RVA = "0x3E3C4AC", Offset = "0x3E3C4AC", VA = "0x3E3C4AC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CB6")]
    public bool IsInitial
    {
      [Token(Token = "0x6005723"), Address(RVA = "0x3E3C4B4", Offset = "0x3E3C4B4", VA = "0x3E3C4B4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CB7")]
    public bool IsQuick
    {
      [Token(Token = "0x6005724"), Address(RVA = "0x3E3C4BC", Offset = "0x3E3C4BC", VA = "0x3E3C4BC", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005725")]
    [Address(RVA = "0x3E3C4C4", Offset = "0x3E3C4C4", VA = "0x3E3C4C4")]
    public BattleGuestTroopsData()
    {
    }
  }
}
