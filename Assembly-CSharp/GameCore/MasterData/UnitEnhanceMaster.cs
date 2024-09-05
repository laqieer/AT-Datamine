// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UnitEnhanceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001068")]
  [Serializable]
  public sealed class UnitEnhanceMaster : BaseMaster<UnitEnhanceData>
  {
    [Token(Token = "0x4005135")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005F34")]
    [Address(RVA = "0x28CBD78", Offset = "0x28CBD78", VA = "0x28CBD78")]
    public IReadOnlyDictionary<int, UnitEnhanceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, UnitEnhanceData>) null;
    }

    [Token(Token = "0x6005F35")]
    [Address(RVA = "0x28CBD80", Offset = "0x28CBD80", VA = "0x28CBD80", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F36")]
    [Address(RVA = "0x28CBDE0", Offset = "0x28CBDE0", VA = "0x28CBDE0", Slot = "5")]
    protected override UnitEnhanceData LoadEntity(IMasterDataReader reader)
    {
      return (UnitEnhanceData) null;
    }

    [Token(Token = "0x6005F37")]
    [Address(RVA = "0x28CBE38", Offset = "0x28CBE38", VA = "0x28CBE38")]
    public UnitEnhanceMaster()
    {
    }
  }
}
