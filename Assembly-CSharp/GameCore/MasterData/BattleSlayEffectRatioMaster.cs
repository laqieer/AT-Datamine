// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSlayEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E24")]
  [Serializable]
  public sealed class BattleSlayEffectRatioMaster : BaseMaster<BattleSlayEffectRatioData>
  {
    [Token(Token = "0x600562E")]
    [Address(RVA = "0x3E327E4", Offset = "0x3E327E4", VA = "0x3E327E4")]
    public IReadOnlyDictionary<int, BattleSlayEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleSlayEffectRatioData>) null;
    }

    [Token(Token = "0x600562F")]
    [Address(RVA = "0x3E327EC", Offset = "0x3E327EC", VA = "0x3E327EC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005630")]
    [Address(RVA = "0x3E3284C", Offset = "0x3E3284C", VA = "0x3E3284C", Slot = "5")]
    protected override BattleSlayEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleSlayEffectRatioData) null;
    }

    [Token(Token = "0x6005631")]
    [Address(RVA = "0x3E328A4", Offset = "0x3E328A4", VA = "0x3E328A4")]
    public BattleSlayEffectRatioData GetByValue(int value) => (BattleSlayEffectRatioData) null;

    [Token(Token = "0x6005632")]
    [Address(RVA = "0x3E32A34", Offset = "0x3E32A34", VA = "0x3E32A34")]
    public BattleSlayEffectRatioMaster()
    {
    }
  }
}
