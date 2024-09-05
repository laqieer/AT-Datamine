// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EFE")]
  [Serializable]
  public sealed class MoveTypeMaster : BaseMaster<MoveTypeData>
  {
    [Token(Token = "0x600596A")]
    [Address(RVA = "0x3C31FB8", Offset = "0x3C31FB8", VA = "0x3C31FB8")]
    public IReadOnlyDictionary<int, MoveTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MoveTypeData>) null;
    }

    [Token(Token = "0x600596B")]
    [Address(RVA = "0x3C31FC0", Offset = "0x3C31FC0", VA = "0x3C31FC0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600596C")]
    [Address(RVA = "0x3C32020", Offset = "0x3C32020", VA = "0x3C32020", Slot = "5")]
    protected override MoveTypeData LoadEntity(IMasterDataReader reader) => (MoveTypeData) null;

    [Token(Token = "0x600596D")]
    [Address(RVA = "0x3C32078", Offset = "0x3C32078", VA = "0x3C32078")]
    public MoveTypeMaster()
    {
    }
  }
}
