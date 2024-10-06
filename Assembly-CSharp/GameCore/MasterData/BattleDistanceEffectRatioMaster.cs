// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDistanceEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E09")]
  [Serializable]
  public sealed class BattleDistanceEffectRatioMaster : 
    BaseMaster<BattleDistanceEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleDistanceEffectRatioData>
  {
    [Token(Token = "0x4004304")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleDistanceEffectRatioData>> mapByGroup;

    [Token(Token = "0x6005599")]
    [Address(RVA = "0x3AB2670", Offset = "0x3AB2670", VA = "0x3AB2670")]
    public IReadOnlyDictionary<int, BattleDistanceEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDistanceEffectRatioData>) null;
    }

    [Token(Token = "0x600559A")]
    [Address(RVA = "0x3AB2678", Offset = "0x3AB2678", VA = "0x3AB2678", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600559B")]
    [Address(RVA = "0x3AB26D8", Offset = "0x3AB26D8", VA = "0x3AB26D8", Slot = "5")]
    protected override BattleDistanceEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDistanceEffectRatioData) null;
    }

    [Token(Token = "0x600559C")]
    [Address(RVA = "0x3AB2748", Offset = "0x3AB2748", VA = "0x3AB2748")]
    private void OnLoadEntity(BattleDistanceEffectRatioData entity)
    {
    }

    [Token(Token = "0x600559D")]
    [Address(RVA = "0x3AB289C", Offset = "0x3AB289C", VA = "0x3AB289C", Slot = "6")]
    public BattleDistanceEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleDistanceEffectRatioData) null;
    }

    [Token(Token = "0x600559E")]
    [Address(RVA = "0x3AB2A4C", Offset = "0x3AB2A4C", VA = "0x3AB2A4C")]
    public BattleDistanceEffectRatioMaster()
    {
    }
  }
}
