// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillCategoryTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F17")]
  [Serializable]
  public sealed class SkillCategoryTypeMaster : BaseMaster<SkillCategoryTypeData>
  {
    [Token(Token = "0x4004B2D")]
    public const string TEXT_AB = "text_masterdata_skill";

    [Token(Token = "0x600598A")]
    [Address(RVA = "0x3C32BC4", Offset = "0x3C32BC4", VA = "0x3C32BC4")]
    public IReadOnlyDictionary<int, SkillCategoryTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillCategoryTypeData>) null;
    }

    [Token(Token = "0x600598B")]
    [Address(RVA = "0x3C32BCC", Offset = "0x3C32BCC", VA = "0x3C32BCC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600598C")]
    [Address(RVA = "0x3C32C2C", Offset = "0x3C32C2C", VA = "0x3C32C2C", Slot = "5")]
    protected override SkillCategoryTypeData LoadEntity(IMasterDataReader reader)
    {
      return (SkillCategoryTypeData) null;
    }

    [Token(Token = "0x600598D")]
    [Address(RVA = "0x3C32C84", Offset = "0x3C32C84", VA = "0x3C32C84")]
    public SkillCategoryTypeMaster()
    {
    }
  }
}
