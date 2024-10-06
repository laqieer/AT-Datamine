// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleHpInvRatioEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E16")]
  [Serializable]
  public sealed class BattleHpInvRatioEffectRatioMaster : 
    BaseMaster<BattleHpInvRatioEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleHpInvRatioEffectRatioData>
  {
    [Token(Token = "0x4004320")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleHpInvRatioEffectRatioData>> mapByGroup;

    [Token(Token = "0x60055D6")]
    [Address(RVA = "0x3E2ED68", Offset = "0x3E2ED68", VA = "0x3E2ED68")]
    public IReadOnlyDictionary<int, BattleHpInvRatioEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleHpInvRatioEffectRatioData>) null;
    }

    [Token(Token = "0x60055D7")]
    [Address(RVA = "0x3E2ED70", Offset = "0x3E2ED70", VA = "0x3E2ED70", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055D8")]
    [Address(RVA = "0x3E2EDD0", Offset = "0x3E2EDD0", VA = "0x3E2EDD0", Slot = "5")]
    protected override BattleHpInvRatioEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleHpInvRatioEffectRatioData) null;
    }

    [Token(Token = "0x60055D9")]
    [Address(RVA = "0x3E2EE40", Offset = "0x3E2EE40", VA = "0x3E2EE40")]
    private void OnLoadEntity(BattleHpInvRatioEffectRatioData entity)
    {
    }

    [Token(Token = "0x60055DA")]
    [Address(RVA = "0x3E2EF94", Offset = "0x3E2EF94", VA = "0x3E2EF94", Slot = "6")]
    public BattleHpInvRatioEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleHpInvRatioEffectRatioData) null;
    }

    [Token(Token = "0x60055DB")]
    [Address(RVA = "0x3E2F144", Offset = "0x3E2F144", VA = "0x3E2F144")]
    public BattleHpInvRatioEffectRatioMaster()
    {
    }
  }
}
