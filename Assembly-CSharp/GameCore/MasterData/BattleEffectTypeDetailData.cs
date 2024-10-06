// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEffectTypeDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E0F")]
  [Serializable]
  public sealed class BattleEffectTypeDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4004311")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004312")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public BattleEffectTypeEnum battleEffectType;
    [Token(Token = "0x4004313")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public BuffDebuffTypeEnum buffDebuffType;

    [Token(Token = "0x17000C4D")]
    public int Key
    {
      [Token(Token = "0x60055B6"), Address(RVA = "0x3E2DCBC", Offset = "0x3E2DCBC", VA = "0x3E2DCBC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055B7")]
    [Address(RVA = "0x3E2DCC4", Offset = "0x3E2DCC4", VA = "0x3E2DCC4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055B8")]
    [Address(RVA = "0x3E2DE30", Offset = "0x3E2DE30", VA = "0x3E2DE30", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055B9")]
    [Address(RVA = "0x3E2DEC4", Offset = "0x3E2DEC4", VA = "0x3E2DEC4")]
    public BattleEffectTypeDetailData()
    {
    }
  }
}
