// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDistanceEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E0A")]
  [Serializable]
  public sealed class BattleDistanceEffectRatioData : IMasterDataEntity, IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x4004305")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004306")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4004307")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004308")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4004309")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C4B")]
    public int Key
    {
      [Token(Token = "0x600559F"), Address(RVA = "0x3E2D02C", Offset = "0x3E2D02C", VA = "0x3E2D02C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055A0")]
    [Address(RVA = "0x3E2D034", Offset = "0x3E2D034", VA = "0x3E2D034", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055A1")]
    [Address(RVA = "0x3E2D260", Offset = "0x3E2D260", VA = "0x3E2D260", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055A2")]
    [Address(RVA = "0x3E2D314", Offset = "0x3E2D314", VA = "0x3E2D314", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x60055A3")]
    [Address(RVA = "0x3E2D31C", Offset = "0x3E2D31C", VA = "0x3E2D31C")]
    public BattleDistanceEffectRatioData()
    {
    }
  }
}
