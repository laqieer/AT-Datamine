// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionPartyReleaseMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA1")]
  [Serializable]
  public sealed class ExpeditionPartyReleaseMaster : BaseMaster<ExpeditionPartyReleaseData>
  {
    [Token(Token = "0x6005BCA")]
    [Address(RVA = "0x2786528", Offset = "0x2786528", VA = "0x2786528")]
    public IReadOnlyDictionary<int, ExpeditionPartyReleaseData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionPartyReleaseData>) null;
    }

    [Token(Token = "0x6005BCB")]
    [Address(RVA = "0x2786530", Offset = "0x2786530", VA = "0x2786530", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BCC")]
    [Address(RVA = "0x2786590", Offset = "0x2786590", VA = "0x2786590", Slot = "5")]
    protected override ExpeditionPartyReleaseData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionPartyReleaseData) null;
    }

    [Token(Token = "0x6005BCD")]
    [Address(RVA = "0x27865E8", Offset = "0x27865E8", VA = "0x27865E8")]
    public ExpeditionPartyReleaseMaster()
    {
    }
  }
}
