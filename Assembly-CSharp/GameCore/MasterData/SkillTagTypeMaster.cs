// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTagTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F1B")]
  [Serializable]
  public sealed class SkillTagTypeMaster : BaseMaster<SkillTagTypeData>
  {
    [Token(Token = "0x4004B3F")]
    public const string TEXT_AB = "text_masterdata_skill";

    [Token(Token = "0x6005993")]
    [Address(RVA = "0x3C32F4C", Offset = "0x3C32F4C", VA = "0x3C32F4C")]
    public IReadOnlyDictionary<int, SkillTagTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillTagTypeData>) null;
    }

    [Token(Token = "0x6005994")]
    [Address(RVA = "0x3C32F54", Offset = "0x3C32F54", VA = "0x3C32F54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005995")]
    [Address(RVA = "0x3C32FB4", Offset = "0x3C32FB4", VA = "0x3C32FB4", Slot = "5")]
    protected override SkillTagTypeData LoadEntity(IMasterDataReader reader)
    {
      return (SkillTagTypeData) null;
    }

    [Token(Token = "0x6005996")]
    [Address(RVA = "0x3C3300C", Offset = "0x3C3300C", VA = "0x3C3300C")]
    public SkillTagTypeMaster()
    {
    }
  }
}
