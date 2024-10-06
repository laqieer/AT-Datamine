// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.OverrideResourceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001397")]
  [Serializable]
  public sealed class OverrideResourceMaster : BaseMaster<OverrideResourceData>
  {
    [Token(Token = "0x6006E18")]
    [Address(RVA = "0x4701DF4", Offset = "0x4701DF4", VA = "0x4701DF4")]
    public IReadOnlyDictionary<int, OverrideResourceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, OverrideResourceData>) null;
    }

    [Token(Token = "0x6006E19")]
    [Address(RVA = "0x4701DFC", Offset = "0x4701DFC", VA = "0x4701DFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E1A")]
    [Address(RVA = "0x4701E5C", Offset = "0x4701E5C", VA = "0x4701E5C", Slot = "5")]
    protected override OverrideResourceData LoadEntity(IMasterDataReader reader)
    {
      return (OverrideResourceData) null;
    }

    [Token(Token = "0x6006E1B")]
    [Address(RVA = "0x4701EB4", Offset = "0x4701EB4", VA = "0x4701EB4")]
    public OverrideResourceMaster()
    {
    }
  }
}
