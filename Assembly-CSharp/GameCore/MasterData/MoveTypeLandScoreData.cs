// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveTypeLandScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD5")]
  [Serializable]
  public sealed class MoveTypeLandScoreData : IMasterDataEntity
  {
    [Token(Token = "0x4004237")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004238")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int move;
    [Token(Token = "0x4004239")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public LandformTypeEnum landformType;
    [Token(Token = "0x400423A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int score;

    [Token(Token = "0x17000C0B")]
    public int Key
    {
      [Token(Token = "0x6005470"), Address(RVA = "0x3AA55D0", Offset = "0x3AA55D0", VA = "0x3AA55D0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005471")]
    [Address(RVA = "0x3AA55D8", Offset = "0x3AA55D8", VA = "0x3AA55D8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005472")]
    [Address(RVA = "0x3AA57A4", Offset = "0x3AA57A4", VA = "0x3AA57A4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005473")]
    [Address(RVA = "0x3AA5848", Offset = "0x3AA5848", VA = "0x3AA5848")]
    public MoveTypeLandScoreData()
    {
    }
  }
}
