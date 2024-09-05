// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F66")]
  [Serializable]
  public sealed class SkillEnhanceConstMaster : BaseMaster<SkillEnhanceConstData>
  {
    [Token(Token = "0x6005AA2")]
    [Address(RVA = "0x3C421F0", Offset = "0x3C421F0", VA = "0x3C421F0")]
    public IReadOnlyDictionary<int, SkillEnhanceConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillEnhanceConstData>) null;
    }

    [Token(Token = "0x6005AA3")]
    [Address(RVA = "0x3C421F8", Offset = "0x3C421F8", VA = "0x3C421F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AA4")]
    [Address(RVA = "0x3C42258", Offset = "0x3C42258", VA = "0x3C42258", Slot = "5")]
    protected override SkillEnhanceConstData LoadEntity(IMasterDataReader reader)
    {
      return (SkillEnhanceConstData) null;
    }

    [Token(Token = "0x6005AA5")]
    [Address(RVA = "0x3C422B0", Offset = "0x3C422B0", VA = "0x3C422B0")]
    public SkillEnhanceConstMaster()
    {
    }
  }
}
