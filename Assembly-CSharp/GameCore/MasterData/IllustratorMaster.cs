// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IllustratorMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001395")]
  [Serializable]
  public sealed class IllustratorMaster : BaseMaster<IllustratorData>
  {
    [Token(Token = "0x6006E10")]
    [Address(RVA = "0x4701B48", Offset = "0x4701B48", VA = "0x4701B48")]
    public IReadOnlyDictionary<int, IllustratorData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IllustratorData>) null;
    }

    [Token(Token = "0x6006E11")]
    [Address(RVA = "0x4701B50", Offset = "0x4701B50", VA = "0x4701B50", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E12")]
    [Address(RVA = "0x4701BB0", Offset = "0x4701BB0", VA = "0x4701BB0", Slot = "5")]
    protected override IllustratorData LoadEntity(IMasterDataReader reader)
    {
      return (IllustratorData) null;
    }

    [Token(Token = "0x6006E13")]
    [Address(RVA = "0x4701C08", Offset = "0x4701C08", VA = "0x4701C08")]
    public IllustratorMaster()
    {
    }
  }
}
