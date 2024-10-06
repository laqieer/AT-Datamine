// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvOptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DBB")]
  [Serializable]
  public sealed class AdvOptionMaster : BaseMaster<AdvOptionData>
  {
    [Token(Token = "0x60053FD")]
    [Address(RVA = "0x3AA01E8", Offset = "0x3AA01E8", VA = "0x3AA01E8")]
    public IReadOnlyDictionary<int, AdvOptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvOptionData>) null;
    }

    [Token(Token = "0x60053FE")]
    [Address(RVA = "0x3AA01F0", Offset = "0x3AA01F0", VA = "0x3AA01F0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053FF")]
    [Address(RVA = "0x3AA0250", Offset = "0x3AA0250", VA = "0x3AA0250", Slot = "5")]
    protected override AdvOptionData LoadEntity(IMasterDataReader reader) => (AdvOptionData) null;

    [Token(Token = "0x6005400")]
    [Address(RVA = "0x3AA02A8", Offset = "0x3AA02A8", VA = "0x3AA02A8")]
    public AdvOptionMaster()
    {
    }
  }
}
