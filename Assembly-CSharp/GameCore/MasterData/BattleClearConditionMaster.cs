// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleClearConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E07")]
  [Serializable]
  public sealed class BattleClearConditionMaster : BaseMaster<BattleClearConditionData>
  {
    [Token(Token = "0x40042FC")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x40042FD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleClearConditionData>> mapData;

    [Token(Token = "0x600558E")]
    [Address(RVA = "0x3AB1E94", Offset = "0x3AB1E94", VA = "0x3AB1E94")]
    public IReadOnlyDictionary<int, BattleClearConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleClearConditionData>) null;
    }

    [Token(Token = "0x600558F")]
    [Address(RVA = "0x3AB1E9C", Offset = "0x3AB1E9C", VA = "0x3AB1E9C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005590")]
    [Address(RVA = "0x3AB1EFC", Offset = "0x3AB1EFC", VA = "0x3AB1EFC", Slot = "5")]
    protected override BattleClearConditionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleClearConditionData) null;
    }

    [Token(Token = "0x6005591")]
    [Address(RVA = "0x3AB1F6C", Offset = "0x3AB1F6C", VA = "0x3AB1F6C")]
    private void OnLoadEntity(BattleClearConditionData entity)
    {
    }

    [Token(Token = "0x6005592")]
    [Address(RVA = "0x3AB20E8", Offset = "0x3AB20E8", VA = "0x3AB20E8")]
    public List<BattleClearConditionData> GetListByGroupID(int groupId)
    {
      return (List<BattleClearConditionData>) null;
    }

    [Token(Token = "0x6005593")]
    [Address(RVA = "0x3AB21A4", Offset = "0x3AB21A4", VA = "0x3AB21A4")]
    public BattleClearConditionMaster()
    {
    }
  }
}
