// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EmblemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138D")]
  [Serializable]
  public sealed class EmblemMaster : BaseMaster<EmblemData>
  {
    [Token(Token = "0x4005B61")]
    public const string TEXT_AB = "text_masterdata_unit";

    [Token(Token = "0x6006DEF")]
    [Address(RVA = "0x4700E10", Offset = "0x4700E10", VA = "0x4700E10")]
    public IReadOnlyDictionary<int, EmblemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EmblemData>) null;
    }

    [Token(Token = "0x6006DF0")]
    [Address(RVA = "0x4700E18", Offset = "0x4700E18", VA = "0x4700E18", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DF1")]
    [Address(RVA = "0x4700E78", Offset = "0x4700E78", VA = "0x4700E78", Slot = "5")]
    protected override EmblemData LoadEntity(IMasterDataReader reader) => (EmblemData) null;

    [Token(Token = "0x6006DF2")]
    [Address(RVA = "0x4700ED0", Offset = "0x4700ED0", VA = "0x4700ED0")]
    public EmblemMaster()
    {
    }
  }
}
