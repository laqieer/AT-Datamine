// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BossChallengeTicketMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001040")]
  [Serializable]
  public sealed class BossChallengeTicketMaster : BaseMaster<BossChallengeTicketData>
  {
    [Token(Token = "0x6005E69")]
    [Address(RVA = "0x28C3498", Offset = "0x28C3498", VA = "0x28C3498")]
    public IReadOnlyDictionary<int, BossChallengeTicketData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BossChallengeTicketData>) null;
    }

    [Token(Token = "0x6005E6A")]
    [Address(RVA = "0x28C34A0", Offset = "0x28C34A0", VA = "0x28C34A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E6B")]
    [Address(RVA = "0x28C3500", Offset = "0x28C3500", VA = "0x28C3500", Slot = "5")]
    protected override BossChallengeTicketData LoadEntity(IMasterDataReader reader)
    {
      return (BossChallengeTicketData) null;
    }

    [Token(Token = "0x6005E6C")]
    [Address(RVA = "0x28C3558", Offset = "0x28C3558", VA = "0x28C3558")]
    public BossChallengeTicketMaster()
    {
    }
  }
}
