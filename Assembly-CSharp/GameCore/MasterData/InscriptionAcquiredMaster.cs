// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionAcquiredMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F50")]
  [Serializable]
  public sealed class InscriptionAcquiredMaster : BaseMaster<InscriptionAcquiredData>
  {
    [Token(Token = "0x6005A2A")]
    [Address(RVA = "0x3C3BE24", Offset = "0x3C3BE24", VA = "0x3C3BE24")]
    public IReadOnlyDictionary<int, InscriptionAcquiredData> GetEntities()
    {
      return (IReadOnlyDictionary<int, InscriptionAcquiredData>) null;
    }

    [Token(Token = "0x6005A2B")]
    [Address(RVA = "0x3C3BE2C", Offset = "0x3C3BE2C", VA = "0x3C3BE2C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A2C")]
    [Address(RVA = "0x3C3BE8C", Offset = "0x3C3BE8C", VA = "0x3C3BE8C", Slot = "5")]
    protected override InscriptionAcquiredData LoadEntity(IMasterDataReader reader)
    {
      return (InscriptionAcquiredData) null;
    }

    [Token(Token = "0x6005A2D")]
    [Address(RVA = "0x3C3BEE4", Offset = "0x3C3BEE4", VA = "0x3C3BEE4")]
    public InscriptionAcquiredMaster()
    {
    }
  }
}
