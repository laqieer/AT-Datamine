// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattleTicketMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103E")]
  [Serializable]
  public sealed class ArenaBattleTicketMaster : BaseMaster<ArenaBattleTicketData>
  {
    [Token(Token = "0x6005E61")]
    [Address(RVA = "0x28C2F40", Offset = "0x28C2F40", VA = "0x28C2F40")]
    public IReadOnlyDictionary<int, ArenaBattleTicketData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaBattleTicketData>) null;
    }

    [Token(Token = "0x6005E62")]
    [Address(RVA = "0x28C2F48", Offset = "0x28C2F48", VA = "0x28C2F48", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E63")]
    [Address(RVA = "0x28C2FA8", Offset = "0x28C2FA8", VA = "0x28C2FA8", Slot = "5")]
    protected override ArenaBattleTicketData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaBattleTicketData) null;
    }

    [Token(Token = "0x6005E64")]
    [Address(RVA = "0x28C3000", Offset = "0x28C3000", VA = "0x28C3000")]
    public ArenaBattleTicketMaster()
    {
    }
  }
}
