// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleVoiceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2D")]
  [Serializable]
  public sealed class BattleVoiceData : IMasterDataEntity
  {
    [Token(Token = "0x40043A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043A4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public BattleVoiceTimingEnum timing;
    [Token(Token = "0x40043A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public BattleVoiceOverlappingEnum overlapping;
    [Token(Token = "0x40043A6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleVoiceTypeEnum voicetype;
    [Token(Token = "0x40043A7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool isAuto;
    [Token(Token = "0x40043A8")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    public bool isSpeed;

    [Token(Token = "0x17000C6E")]
    public int Key
    {
      [Token(Token = "0x600565A"), Address(RVA = "0x3E35260", Offset = "0x3E35260", VA = "0x3E35260", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600565B")]
    [Address(RVA = "0x3E35268", Offset = "0x3E35268", VA = "0x3E35268", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600565C")]
    [Address(RVA = "0x3E354FC", Offset = "0x3E354FC", VA = "0x3E354FC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600565D")]
    [Address(RVA = "0x3E355C0", Offset = "0x3E355C0", VA = "0x3E355C0")]
    public BattleVoiceData()
    {
    }
  }
}
