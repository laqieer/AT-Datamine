// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSortieConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E26")]
  [Serializable]
  public sealed class BattleSortieConditionMaster : BaseMaster<BattleSortieConditionData>
  {
    [Token(Token = "0x400436A")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x400436B")]
    [FieldOffset(Offset = "0x18")]
    private readonly IReadOnlyList<BattleSortieConditionData> EMPTY_LIST;
    [Token(Token = "0x400436C")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<BattleSortieConditionData>> mapData;

    [Token(Token = "0x6005637")]
    [Address(RVA = "0x3E32D6C", Offset = "0x3E32D6C", VA = "0x3E32D6C")]
    public IReadOnlyDictionary<int, BattleSortieConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleSortieConditionData>) null;
    }

    [Token(Token = "0x6005638")]
    [Address(RVA = "0x3E32D74", Offset = "0x3E32D74", VA = "0x3E32D74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005639")]
    [Address(RVA = "0x3E32DD4", Offset = "0x3E32DD4", VA = "0x3E32DD4", Slot = "5")]
    protected override BattleSortieConditionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleSortieConditionData) null;
    }

    [Token(Token = "0x600563A")]
    [Address(RVA = "0x3E32E44", Offset = "0x3E32E44", VA = "0x3E32E44")]
    private void OnLoadEntity(BattleSortieConditionData entity)
    {
    }

    [Token(Token = "0x600563B")]
    [Address(RVA = "0x3E32FC0", Offset = "0x3E32FC0", VA = "0x3E32FC0")]
    public IReadOnlyList<BattleSortieConditionData> GetListByGroupID(int groupId)
    {
      return (IReadOnlyList<BattleSortieConditionData>) null;
    }

    [Token(Token = "0x600563C")]
    [Address(RVA = "0x3E33038", Offset = "0x3E33038", VA = "0x3E33038")]
    public BattleSortieConditionMaster()
    {
    }
  }
}
