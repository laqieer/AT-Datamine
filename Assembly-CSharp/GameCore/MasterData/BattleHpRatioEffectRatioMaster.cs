// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleHpRatioEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E18")]
  [Serializable]
  public sealed class BattleHpRatioEffectRatioMaster : 
    BaseMaster<BattleHpRatioEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleHpRatioEffectRatioData>
  {
    [Token(Token = "0x4004326")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleHpRatioEffectRatioData>> mapByGroup;

    [Token(Token = "0x60055E1")]
    [Address(RVA = "0x3E2F4CC", Offset = "0x3E2F4CC", VA = "0x3E2F4CC")]
    public IReadOnlyDictionary<int, BattleHpRatioEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleHpRatioEffectRatioData>) null;
    }

    [Token(Token = "0x60055E2")]
    [Address(RVA = "0x3E2F4D4", Offset = "0x3E2F4D4", VA = "0x3E2F4D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055E3")]
    [Address(RVA = "0x3E2F534", Offset = "0x3E2F534", VA = "0x3E2F534", Slot = "5")]
    protected override BattleHpRatioEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleHpRatioEffectRatioData) null;
    }

    [Token(Token = "0x60055E4")]
    [Address(RVA = "0x3E2F5A4", Offset = "0x3E2F5A4", VA = "0x3E2F5A4")]
    private void OnLoadEntity(BattleHpRatioEffectRatioData entity)
    {
    }

    [Token(Token = "0x60055E5")]
    [Address(RVA = "0x3E2F6F8", Offset = "0x3E2F6F8", VA = "0x3E2F6F8", Slot = "6")]
    public BattleHpRatioEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleHpRatioEffectRatioData) null;
    }

    [Token(Token = "0x60055E6")]
    [Address(RVA = "0x3E2F8A8", Offset = "0x3E2F8A8", VA = "0x3E2F8A8")]
    public BattleHpRatioEffectRatioMaster()
    {
    }
  }
}
