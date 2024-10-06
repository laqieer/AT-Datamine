// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.SkillModelList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x200357D")]
  public class SkillModelList : SkillModelListBase
  {
    [Token(Token = "0x6015007")]
    [Address(RVA = "0x4AA3104", Offset = "0x4AA3104", VA = "0x4AA3104")]
    public void SetSkills(EquipmentSkill[] skills)
    {
    }

    [Token(Token = "0x6015008")]
    [Address(RVA = "0x4AA326C", Offset = "0x4AA326C", VA = "0x4AA326C")]
    public SkillModelBase CurrentSkill() => (SkillModelBase) null;

    [Token(Token = "0x6015009")]
    [Address(RVA = "0x4AA3270", Offset = "0x4AA3270", VA = "0x4AA3270")]
    public IEnumerable<SkillModelBase> GetSkillModels() => (IEnumerable<SkillModelBase>) null;

    [Token(Token = "0x601500A")]
    [Address(RVA = "0x4AA3278", Offset = "0x4AA3278", VA = "0x4AA3278")]
    public SkillModelList()
    {
    }
  }
}
