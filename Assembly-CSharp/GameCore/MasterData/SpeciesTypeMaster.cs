// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F22")]
  [Serializable]
  public sealed class SpeciesTypeMaster : BaseMaster<SpeciesTypeData>
  {
    [Token(Token = "0x600599C")]
    [Address(RVA = "0x3C33348", Offset = "0x3C33348", VA = "0x3C33348")]
    public IReadOnlyDictionary<int, SpeciesTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpeciesTypeData>) null;
    }

    [Token(Token = "0x600599D")]
    [Address(RVA = "0x3C33350", Offset = "0x3C33350", VA = "0x3C33350", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600599E")]
    [Address(RVA = "0x3C333B0", Offset = "0x3C333B0", VA = "0x3C333B0", Slot = "5")]
    protected override SpeciesTypeData LoadEntity(IMasterDataReader reader)
    {
      return (SpeciesTypeData) null;
    }

    [Token(Token = "0x600599F")]
    [Address(RVA = "0x3C33408", Offset = "0x3C33408", VA = "0x3C33408")]
    public SpeciesTypeMaster()
    {
    }
  }
}
