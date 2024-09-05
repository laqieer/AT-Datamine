// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA0")]
  [Serializable]
  public sealed class SpeciesDescriptionMaster : BaseMaster<SpeciesDescriptionData>
  {
    [Token(Token = "0x40046B3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SpeciesDescriptionData>> mapByGroupId;

    [Token(Token = "0x60058F3")]
    [Address(RVA = "0x3C2EF38", Offset = "0x3C2EF38", VA = "0x3C2EF38")]
    public IReadOnlyDictionary<int, SpeciesDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpeciesDescriptionData>) null;
    }

    [Token(Token = "0x60058F4")]
    [Address(RVA = "0x3C2EF40", Offset = "0x3C2EF40", VA = "0x3C2EF40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058F5")]
    [Address(RVA = "0x3C2EFA0", Offset = "0x3C2EFA0", VA = "0x3C2EFA0", Slot = "5")]
    protected override SpeciesDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (SpeciesDescriptionData) null;
    }

    [Token(Token = "0x60058F6")]
    [Address(RVA = "0x3C2F010", Offset = "0x3C2F010", VA = "0x3C2F010")]
    private void OnLoadEntity(SpeciesDescriptionData entity)
    {
    }

    [Token(Token = "0x60058F7")]
    [Address(RVA = "0x3C2F164", Offset = "0x3C2F164", VA = "0x3C2F164")]
    public IReadOnlyList<SpeciesDescriptionData> GetListByGroup(int groupId)
    {
      return (IReadOnlyList<SpeciesDescriptionData>) null;
    }

    [Token(Token = "0x60058F8")]
    [Address(RVA = "0x3C2F1D4", Offset = "0x3C2F1D4", VA = "0x3C2F1D4")]
    public SpeciesDescriptionMaster()
    {
    }
  }
}
