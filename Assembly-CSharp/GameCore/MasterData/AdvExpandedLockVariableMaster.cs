// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockVariableMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB0")]
  [Serializable]
  public sealed class AdvExpandedLockVariableMaster : BaseMaster<AdvExpandedLockVariableData>
  {
    [Token(Token = "0x60053C5")]
    [Address(RVA = "0x3A9D538", Offset = "0x3A9D538", VA = "0x3A9D538")]
    public IReadOnlyDictionary<int, AdvExpandedLockVariableData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvExpandedLockVariableData>) null;
    }

    [Token(Token = "0x60053C6")]
    [Address(RVA = "0x3A9D540", Offset = "0x3A9D540", VA = "0x3A9D540", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053C7")]
    [Address(RVA = "0x3A9D5A0", Offset = "0x3A9D5A0", VA = "0x3A9D5A0", Slot = "5")]
    protected override AdvExpandedLockVariableData LoadEntity(IMasterDataReader reader)
    {
      return (AdvExpandedLockVariableData) null;
    }

    [Token(Token = "0x60053C8")]
    [Address(RVA = "0x3A9D5F8", Offset = "0x3A9D5F8", VA = "0x3A9D5F8")]
    public AdvExpandedLockVariableMaster()
    {
    }
  }
}
