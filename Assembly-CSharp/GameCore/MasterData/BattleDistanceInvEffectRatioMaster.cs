// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDistanceInvEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E0B")]
  [Serializable]
  public sealed class BattleDistanceInvEffectRatioMaster : 
    BaseMaster<BattleDistanceInvEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleDistanceInvEffectRatioData>
  {
    [Token(Token = "0x400430A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleDistanceInvEffectRatioData>> mapByGroup;

    [Token(Token = "0x60055A4")]
    [Address(RVA = "0x3E2D324", Offset = "0x3E2D324", VA = "0x3E2D324")]
    public IReadOnlyDictionary<int, BattleDistanceInvEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDistanceInvEffectRatioData>) null;
    }

    [Token(Token = "0x60055A5")]
    [Address(RVA = "0x3E2D32C", Offset = "0x3E2D32C", VA = "0x3E2D32C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055A6")]
    [Address(RVA = "0x3E2D38C", Offset = "0x3E2D38C", VA = "0x3E2D38C", Slot = "5")]
    protected override BattleDistanceInvEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDistanceInvEffectRatioData) null;
    }

    [Token(Token = "0x60055A7")]
    [Address(RVA = "0x3E2D3FC", Offset = "0x3E2D3FC", VA = "0x3E2D3FC")]
    private void OnLoadEntity(BattleDistanceInvEffectRatioData entity)
    {
    }

    [Token(Token = "0x60055A8")]
    [Address(RVA = "0x3E2D550", Offset = "0x3E2D550", VA = "0x3E2D550", Slot = "6")]
    public BattleDistanceInvEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleDistanceInvEffectRatioData) null;
    }

    [Token(Token = "0x60055A9")]
    [Address(RVA = "0x3E2D700", Offset = "0x3E2D700", VA = "0x3E2D700")]
    public BattleDistanceInvEffectRatioMaster()
    {
    }
  }
}
