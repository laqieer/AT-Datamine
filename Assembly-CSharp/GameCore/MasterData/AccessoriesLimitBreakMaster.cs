// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesLimitBreakMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F4E")]
  [Serializable]
  public sealed class AccessoriesLimitBreakMaster : BaseMaster<AccessoriesLimitBreakData>
  {
    [Token(Token = "0x6005A22")]
    [Address(RVA = "0x3C3BB78", Offset = "0x3C3BB78", VA = "0x3C3BB78")]
    public IReadOnlyDictionary<int, AccessoriesLimitBreakData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoriesLimitBreakData>) null;
    }

    [Token(Token = "0x6005A23")]
    [Address(RVA = "0x3C3BB80", Offset = "0x3C3BB80", VA = "0x3C3BB80", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A24")]
    [Address(RVA = "0x3C3BBE0", Offset = "0x3C3BBE0", VA = "0x3C3BBE0", Slot = "5")]
    protected override AccessoriesLimitBreakData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoriesLimitBreakData) null;
    }

    [Token(Token = "0x6005A25")]
    [Address(RVA = "0x3C3BC38", Offset = "0x3C3BC38", VA = "0x3C3BC38")]
    public AccessoriesLimitBreakMaster()
    {
    }
  }
}
