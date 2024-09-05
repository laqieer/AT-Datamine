// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDistanceInvEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E0C")]
  [Serializable]
  public sealed class BattleDistanceInvEffectRatioData : 
    IMasterDataEntity,
    IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x400430B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400430C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x400430D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400430E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x400430F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C4C")]
    public int Key
    {
      [Token(Token = "0x60055AA"), Address(RVA = "0x3E2D790", Offset = "0x3E2D790", VA = "0x3E2D790", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055AB")]
    [Address(RVA = "0x3E2D798", Offset = "0x3E2D798", VA = "0x3E2D798", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055AC")]
    [Address(RVA = "0x3E2D9C4", Offset = "0x3E2D9C4", VA = "0x3E2D9C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055AD")]
    [Address(RVA = "0x3E2DA78", Offset = "0x3E2DA78", VA = "0x3E2DA78", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x60055AE")]
    [Address(RVA = "0x3E2DA80", Offset = "0x3E2DA80", VA = "0x3E2DA80")]
    public BattleDistanceInvEffectRatioData()
    {
    }
  }
}
