// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GachaTicketMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001059")]
  [Serializable]
  public sealed class GachaTicketMaster : BaseMaster<GachaTicketData>
  {
    [Token(Token = "0x6005EEA")]
    [Address(RVA = "0x28C90C4", Offset = "0x28C90C4", VA = "0x28C90C4")]
    public IReadOnlyDictionary<int, GachaTicketData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GachaTicketData>) null;
    }

    [Token(Token = "0x6005EEB")]
    [Address(RVA = "0x28C90CC", Offset = "0x28C90CC", VA = "0x28C90CC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EEC")]
    [Address(RVA = "0x28C912C", Offset = "0x28C912C", VA = "0x28C912C", Slot = "5")]
    protected override GachaTicketData LoadEntity(IMasterDataReader reader)
    {
      return (GachaTicketData) null;
    }

    [Token(Token = "0x6005EED")]
    [Address(RVA = "0x28C9184", Offset = "0x28C9184", VA = "0x28C9184")]
    public GachaTicketMaster()
    {
    }
  }
}
