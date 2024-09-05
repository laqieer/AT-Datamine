// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SupportSkillDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C4")]
  [Serializable]
  public sealed class SupportSkillDetailMaster : BaseMaster<SupportSkillDetailData>
  {
    [Token(Token = "0x60065B2")]
    [Address(RVA = "0x4D1E2B4", Offset = "0x4D1E2B4", VA = "0x4D1E2B4")]
    public IReadOnlyDictionary<int, SupportSkillDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SupportSkillDetailData>) null;
    }

    [Token(Token = "0x60065B3")]
    [Address(RVA = "0x4D1E2BC", Offset = "0x4D1E2BC", VA = "0x4D1E2BC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065B4")]
    [Address(RVA = "0x4D1E31C", Offset = "0x4D1E31C", VA = "0x4D1E31C", Slot = "5")]
    protected override SupportSkillDetailData LoadEntity(IMasterDataReader reader)
    {
      return (SupportSkillDetailData) null;
    }

    [Token(Token = "0x60065B5")]
    [Address(RVA = "0x4D1E374", Offset = "0x4D1E374", VA = "0x4D1E374")]
    public SupportSkillDetailMaster()
    {
    }
  }
}
