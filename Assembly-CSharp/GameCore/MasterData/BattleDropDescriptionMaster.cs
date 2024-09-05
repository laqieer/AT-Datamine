// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E32")]
  [Serializable]
  public sealed class BattleDropDescriptionMaster : BaseMaster<BattleDropDescriptionData>
  {
    [Token(Token = "0x40043D3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleDropDescriptionData>> dropTable;

    [Token(Token = "0x6005674")]
    [Address(RVA = "0x3E36BBC", Offset = "0x3E36BBC", VA = "0x3E36BBC")]
    public IReadOnlyDictionary<int, BattleDropDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDropDescriptionData>) null;
    }

    [Token(Token = "0x6005675")]
    [Address(RVA = "0x3E36BC4", Offset = "0x3E36BC4", VA = "0x3E36BC4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005676")]
    [Address(RVA = "0x3E36C24", Offset = "0x3E36C24", VA = "0x3E36C24", Slot = "5")]
    protected override BattleDropDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDropDescriptionData) null;
    }

    [Token(Token = "0x6005677")]
    [Address(RVA = "0x3E36C94", Offset = "0x3E36C94", VA = "0x3E36C94")]
    private void OnLoadEntity(BattleDropDescriptionData entity)
    {
    }

    [Token(Token = "0x6005678")]
    [Address(RVA = "0x3E36C98", Offset = "0x3E36C98", VA = "0x3E36C98")]
    private void GroupingByDrop(BattleDropDescriptionData entity)
    {
    }

    [Token(Token = "0x6005679")]
    [Address(RVA = "0x3E36E54", Offset = "0x3E36E54", VA = "0x3E36E54")]
    public List<BattleDropDescriptionData> GetListBySet(int set)
    {
      return (List<BattleDropDescriptionData>) null;
    }

    [Token(Token = "0x600567A")]
    [Address(RVA = "0x3E36F10", Offset = "0x3E36F10", VA = "0x3E36F10")]
    public BattleDropDescriptionMaster()
    {
    }
  }
}
