// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceLevelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F69")]
  [Serializable]
  public sealed class SkillEnhanceLevelData : IMasterDataEntity
  {
    [Token(Token = "0x4004D86")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D87")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004D88")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int successPercentage;
    [Token(Token = "0x4004D89")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int maxEnergy;

    [Token(Token = "0x17000D70")]
    public int Key
    {
      [Token(Token = "0x6005AAE"), Address(RVA = "0x3C425A0", Offset = "0x3C425A0", VA = "0x3C425A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AAF")]
    [Address(RVA = "0x3C425A8", Offset = "0x3C425A8", VA = "0x3C425A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AB0")]
    [Address(RVA = "0x3C42774", Offset = "0x3C42774", VA = "0x3C42774", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005AB1")]
    [Address(RVA = "0x3C42818", Offset = "0x3C42818", VA = "0x3C42818")]
    public SkillEnhanceLevelData()
    {
    }
  }
}
