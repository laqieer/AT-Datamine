// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionRapidTicketMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001055")]
  [Serializable]
  public sealed class ExpeditionRapidTicketMaster : BaseMaster<ExpeditionRapidTicketData>
  {
    [Token(Token = "0x40050E6")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005ED4")]
    [Address(RVA = "0x28C7EBC", Offset = "0x28C7EBC", VA = "0x28C7EBC")]
    public IReadOnlyDictionary<int, ExpeditionRapidTicketData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionRapidTicketData>) null;
    }

    [Token(Token = "0x6005ED5")]
    [Address(RVA = "0x28C7EC4", Offset = "0x28C7EC4", VA = "0x28C7EC4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005ED6")]
    [Address(RVA = "0x28C7F24", Offset = "0x28C7F24", VA = "0x28C7F24", Slot = "5")]
    protected override ExpeditionRapidTicketData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionRapidTicketData) null;
    }

    [Token(Token = "0x6005ED7")]
    [Address(RVA = "0x28C7F7C", Offset = "0x28C7F7C", VA = "0x28C7F7C")]
    public ExpeditionRapidTicketMaster()
    {
    }
  }
}
