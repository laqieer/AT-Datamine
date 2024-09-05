// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvComparisonTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA8")]
  [Serializable]
  public sealed class AdvComparisonTypeMaster : BaseMaster<AdvComparisonTypeData>
  {
    [Token(Token = "0x600539F")]
    [Address(RVA = "0x3A9BA98", Offset = "0x3A9BA98", VA = "0x3A9BA98")]
    public IReadOnlyDictionary<int, AdvComparisonTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvComparisonTypeData>) null;
    }

    [Token(Token = "0x60053A0")]
    [Address(RVA = "0x3A9BAA0", Offset = "0x3A9BAA0", VA = "0x3A9BAA0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053A1")]
    [Address(RVA = "0x3A9BB00", Offset = "0x3A9BB00", VA = "0x3A9BB00", Slot = "5")]
    protected override AdvComparisonTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AdvComparisonTypeData) null;
    }

    [Token(Token = "0x60053A2")]
    [Address(RVA = "0x3A9BB58", Offset = "0x3A9BB58", VA = "0x3A9BB58")]
    public AdvComparisonTypeMaster()
    {
    }
  }
}
