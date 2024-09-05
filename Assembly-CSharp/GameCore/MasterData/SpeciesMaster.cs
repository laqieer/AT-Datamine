// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA2")]
  [Serializable]
  public sealed class SpeciesMaster : BaseMaster<SpeciesData>
  {
    [Token(Token = "0x60058FD")]
    [Address(RVA = "0x3C2F474", Offset = "0x3C2F474", VA = "0x3C2F474")]
    public IReadOnlyDictionary<int, SpeciesData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpeciesData>) null;
    }

    [Token(Token = "0x60058FE")]
    [Address(RVA = "0x3C2F47C", Offset = "0x3C2F47C", VA = "0x3C2F47C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058FF")]
    [Address(RVA = "0x3C2F4DC", Offset = "0x3C2F4DC", VA = "0x3C2F4DC", Slot = "5")]
    protected override SpeciesData LoadEntity(IMasterDataReader reader) => (SpeciesData) null;

    [Token(Token = "0x6005900")]
    [Address(RVA = "0x3C2F534", Offset = "0x3C2F534", VA = "0x3C2F534")]
    public SpeciesMaster()
    {
    }
  }
}
