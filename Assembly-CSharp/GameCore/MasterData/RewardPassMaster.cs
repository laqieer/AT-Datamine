// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RewardPassMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C6")]
  [Serializable]
  public sealed class RewardPassMaster : BaseMaster<RewardPassData>
  {
    [Token(Token = "0x60060FB")]
    [Address(RVA = "0x28DBF90", Offset = "0x28DBF90", VA = "0x28DBF90")]
    public IReadOnlyDictionary<int, RewardPassData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RewardPassData>) null;
    }

    [Token(Token = "0x60060FC")]
    [Address(RVA = "0x28DBF98", Offset = "0x28DBF98", VA = "0x28DBF98", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060FD")]
    [Address(RVA = "0x28DBFF8", Offset = "0x28DBFF8", VA = "0x28DBFF8", Slot = "5")]
    protected override RewardPassData LoadEntity(IMasterDataReader reader) => (RewardPassData) null;

    [Token(Token = "0x60060FE")]
    [Address(RVA = "0x28DC050", Offset = "0x28DC050", VA = "0x28DC050")]
    public RewardPassMaster()
    {
    }
  }
}
