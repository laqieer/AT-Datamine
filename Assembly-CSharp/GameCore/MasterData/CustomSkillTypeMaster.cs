// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EDD")]
  [Serializable]
  public sealed class CustomSkillTypeMaster : BaseMaster<CustomSkillTypeData>
  {
    [Token(Token = "0x6005949")]
    [Address(RVA = "0x3C31444", Offset = "0x3C31444", VA = "0x3C31444")]
    public IReadOnlyDictionary<int, CustomSkillTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CustomSkillTypeData>) null;
    }

    [Token(Token = "0x600594A")]
    [Address(RVA = "0x3C3144C", Offset = "0x3C3144C", VA = "0x3C3144C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600594B")]
    [Address(RVA = "0x3C314AC", Offset = "0x3C314AC", VA = "0x3C314AC", Slot = "5")]
    protected override CustomSkillTypeData LoadEntity(IMasterDataReader reader)
    {
      return (CustomSkillTypeData) null;
    }

    [Token(Token = "0x600594C")]
    [Address(RVA = "0x3C31504", Offset = "0x3C31504", VA = "0x3C31504")]
    public CustomSkillTypeMaster()
    {
    }
  }
}
