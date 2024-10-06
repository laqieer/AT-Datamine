// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F56")]
  [Serializable]
  public sealed class InscriptionMaster : BaseMaster<InscriptionData>
  {
    [Token(Token = "0x4004D0D")]
    public const string TEXT_AB = "text_masterdata_equipment";

    [Token(Token = "0x6005A45")]
    [Address(RVA = "0x3C3CA58", Offset = "0x3C3CA58", VA = "0x3C3CA58")]
    public IReadOnlyDictionary<int, InscriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, InscriptionData>) null;
    }

    [Token(Token = "0x6005A46")]
    [Address(RVA = "0x3C3CA60", Offset = "0x3C3CA60", VA = "0x3C3CA60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A47")]
    [Address(RVA = "0x3C3CAC0", Offset = "0x3C3CAC0", VA = "0x3C3CAC0", Slot = "5")]
    protected override InscriptionData LoadEntity(IMasterDataReader reader)
    {
      return (InscriptionData) null;
    }

    [Token(Token = "0x6005A48")]
    [Address(RVA = "0x3C3CB18", Offset = "0x3C3CB18", VA = "0x3C3CB18")]
    public InscriptionMaster()
    {
    }
  }
}
