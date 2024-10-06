// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SupportRankData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001371")]
  [Serializable]
  public sealed class SupportRankData : IMasterDataEntity
  {
    [Token(Token = "0x4005B25")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B26")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public SupportRankTypeEnum supportRank;
    [Token(Token = "0x4005B27")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4005B28")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4005B29")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int supportEffectValue;
    [Token(Token = "0x4005B2A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int effectChance;
    [Token(Token = "0x4005B2B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int statusOffsetRate;

    [Token(Token = "0x1700107A")]
    public int Key
    {
      [Token(Token = "0x6006D72"), Address(RVA = "0x46FD05C", Offset = "0x46FD05C", VA = "0x46FD05C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D73")]
    [Address(RVA = "0x46FD064", Offset = "0x46FD064", VA = "0x46FD064", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D74")]
    [Address(RVA = "0x46FD350", Offset = "0x46FD350", VA = "0x46FD350", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D75")]
    [Address(RVA = "0x46FD424", Offset = "0x46FD424", VA = "0x46FD424")]
    public SupportRankData()
    {
    }
  }
}
