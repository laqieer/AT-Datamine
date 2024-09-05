// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UsageNameMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106E")]
  [Serializable]
  public sealed class UsageNameMaster : BaseMaster<UsageNameData>
  {
    [Token(Token = "0x400514C")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005F50")]
    [Address(RVA = "0x28CCF80", Offset = "0x28CCF80", VA = "0x28CCF80")]
    public IReadOnlyDictionary<int, UsageNameData> GetEntities()
    {
      return (IReadOnlyDictionary<int, UsageNameData>) null;
    }

    [Token(Token = "0x6005F51")]
    [Address(RVA = "0x28CCF88", Offset = "0x28CCF88", VA = "0x28CCF88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F52")]
    [Address(RVA = "0x28CCFE8", Offset = "0x28CCFE8", VA = "0x28CCFE8", Slot = "5")]
    protected override UsageNameData LoadEntity(IMasterDataReader reader) => (UsageNameData) null;

    [Token(Token = "0x6005F53")]
    [Address(RVA = "0x28CD040", Offset = "0x28CD040", VA = "0x28CD040")]
    public UsageNameMaster()
    {
    }
  }
}
