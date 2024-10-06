// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SupportSkillActivateRateMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C2")]
  [Serializable]
  public sealed class SupportSkillActivateRateMaster : BaseMaster<SupportSkillActivateRateData>
  {
    [Token(Token = "0x60065AA")]
    [Address(RVA = "0x4D1DF98", Offset = "0x4D1DF98", VA = "0x4D1DF98")]
    public IReadOnlyDictionary<int, SupportSkillActivateRateData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SupportSkillActivateRateData>) null;
    }

    [Token(Token = "0x60065AB")]
    [Address(RVA = "0x4D1DFA0", Offset = "0x4D1DFA0", VA = "0x4D1DFA0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065AC")]
    [Address(RVA = "0x4D1E000", Offset = "0x4D1E000", VA = "0x4D1E000", Slot = "5")]
    protected override SupportSkillActivateRateData LoadEntity(IMasterDataReader reader)
    {
      return (SupportSkillActivateRateData) null;
    }

    [Token(Token = "0x60065AD")]
    [Address(RVA = "0x4D1E058", Offset = "0x4D1E058", VA = "0x4D1E058")]
    public SupportSkillActivateRateMaster()
    {
    }
  }
}
