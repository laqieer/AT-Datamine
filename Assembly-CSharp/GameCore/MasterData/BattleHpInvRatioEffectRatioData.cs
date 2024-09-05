// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleHpInvRatioEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E17")]
  [Serializable]
  public sealed class BattleHpInvRatioEffectRatioData : 
    IMasterDataEntity,
    IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x4004321")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004322")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4004323")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004324")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4004325")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C52")]
    public int Key
    {
      [Token(Token = "0x60055DC"), Address(RVA = "0x3E2F1D4", Offset = "0x3E2F1D4", VA = "0x3E2F1D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055DD")]
    [Address(RVA = "0x3E2F1DC", Offset = "0x3E2F1DC", VA = "0x3E2F1DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055DE")]
    [Address(RVA = "0x3E2F408", Offset = "0x3E2F408", VA = "0x3E2F408", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055DF")]
    [Address(RVA = "0x3E2F4BC", Offset = "0x3E2F4BC", VA = "0x3E2F4BC", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x60055E0")]
    [Address(RVA = "0x3E2F4C4", Offset = "0x3E2F4C4", VA = "0x3E2F4C4")]
    public BattleHpInvRatioEffectRatioData()
    {
    }
  }
}
