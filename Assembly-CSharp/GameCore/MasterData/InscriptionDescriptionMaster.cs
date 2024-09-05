// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F54")]
  [Serializable]
  public sealed class InscriptionDescriptionMaster : BaseMaster<InscriptionDescriptionData>
  {
    [Token(Token = "0x4004D08")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<InscriptionDescriptionData>> descriptionTable;

    [Token(Token = "0x6005A3A")]
    [Address(RVA = "0x3C3C458", Offset = "0x3C3C458", VA = "0x3C3C458")]
    public IReadOnlyDictionary<int, InscriptionDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, InscriptionDescriptionData>) null;
    }

    [Token(Token = "0x6005A3B")]
    [Address(RVA = "0x3C3C460", Offset = "0x3C3C460", VA = "0x3C3C460", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A3C")]
    [Address(RVA = "0x3C3C4C0", Offset = "0x3C3C4C0", VA = "0x3C3C4C0", Slot = "5")]
    protected override InscriptionDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (InscriptionDescriptionData) null;
    }

    [Token(Token = "0x6005A3D")]
    [Address(RVA = "0x3C3C530", Offset = "0x3C3C530", VA = "0x3C3C530")]
    private void OnLoadEntity(InscriptionDescriptionData entity)
    {
    }

    [Token(Token = "0x6005A3E")]
    [Address(RVA = "0x3C3C534", Offset = "0x3C3C534", VA = "0x3C3C534")]
    private void GroupingByInscriptionId(InscriptionDescriptionData entity)
    {
    }

    [Token(Token = "0x6005A3F")]
    [Address(RVA = "0x3C3C68C", Offset = "0x3C3C68C", VA = "0x3C3C68C")]
    public IReadOnlyCollection<InscriptionDescriptionData> GetListByInscriptionId(int inscriptionId)
    {
      return (IReadOnlyCollection<InscriptionDescriptionData>) null;
    }

    [Token(Token = "0x6005A40")]
    [Address(RVA = "0x3C3C748", Offset = "0x3C3C748", VA = "0x3C3C748")]
    public InscriptionDescriptionMaster()
    {
    }
  }
}
