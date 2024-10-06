// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionCategoryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F52")]
  [Serializable]
  public sealed class InscriptionCategoryMaster : BaseMaster<InscriptionCategoryData>
  {
    [Token(Token = "0x6005A32")]
    [Address(RVA = "0x3C3C13C", Offset = "0x3C3C13C", VA = "0x3C3C13C")]
    public IReadOnlyDictionary<int, InscriptionCategoryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, InscriptionCategoryData>) null;
    }

    [Token(Token = "0x6005A33")]
    [Address(RVA = "0x3C3C144", Offset = "0x3C3C144", VA = "0x3C3C144", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A34")]
    [Address(RVA = "0x3C3C1A4", Offset = "0x3C3C1A4", VA = "0x3C3C1A4", Slot = "5")]
    protected override InscriptionCategoryData LoadEntity(IMasterDataReader reader)
    {
      return (InscriptionCategoryData) null;
    }

    [Token(Token = "0x6005A35")]
    [Address(RVA = "0x3C3C1FC", Offset = "0x3C3C1FC", VA = "0x3C3C1FC")]
    public InscriptionCategoryMaster()
    {
    }
  }
}
