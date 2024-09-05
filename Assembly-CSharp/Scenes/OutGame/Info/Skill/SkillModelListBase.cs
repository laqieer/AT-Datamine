// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.SkillModelListBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x200357B")]
  public abstract class SkillModelListBase
  {
    [Token(Token = "0x400E894")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChangeSkill;
    [Token(Token = "0x400E896")]
    [FieldOffset(Offset = "0x20")]
    protected int skillIndex;
    [Token(Token = "0x400E897")]
    [FieldOffset(Offset = "0x28")]
    private Scenes.OutGame.Info.Skill.SkillModel empty;

    [Token(Token = "0x170045B0")]
    public SkillModelBase SkillModel
    {
      [Token(Token = "0x6014FF8"), Address(RVA = "0x4AA29D8", Offset = "0x4AA29D8", VA = "0x4AA29D8")] get
      {
        return (SkillModelBase) null;
      }
    }

    [Token(Token = "0x170045B1")]
    public List<SkillModelBase> SkillModels
    {
      [Token(Token = "0x6014FF9"), Address(RVA = "0x4AA2A54", Offset = "0x4AA2A54", VA = "0x4AA2A54")] get
      {
        return (List<SkillModelBase>) null;
      }
      [Token(Token = "0x6014FFA"), Address(RVA = "0x4AA2A5C", Offset = "0x4AA2A5C", VA = "0x4AA2A5C")] protected set
      {
      }
    }

    [Token(Token = "0x170045B2")]
    public bool ExistSkill
    {
      [Token(Token = "0x6014FFB"), Address(RVA = "0x4AA2A64", Offset = "0x4AA2A64", VA = "0x4AA2A64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045B3")]
    public bool ExistFierceSkill
    {
      [Token(Token = "0x6014FFC"), Address(RVA = "0x4AA2AB4", Offset = "0x4AA2AB4", VA = "0x4AA2AB4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045B4")]
    public bool ExistLatentSkill
    {
      [Token(Token = "0x6014FFD"), Address(RVA = "0x4AA2C30", Offset = "0x4AA2C30", VA = "0x4AA2C30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014FFE")]
    [Address(RVA = "0x4AA2DA0", Offset = "0x4AA2DA0", VA = "0x4AA2DA0")]
    public void SetSkillIndex(int index)
    {
    }

    [Token(Token = "0x6014FFF")]
    [Address(RVA = "0x4AA2E1C", Offset = "0x4AA2E1C", VA = "0x4AA2E1C")]
    public void SetSkills(SkillModelBase[] models)
    {
    }

    [Token(Token = "0x6015000")]
    [Address(RVA = "0x4AA2E74", Offset = "0x4AA2E74", VA = "0x4AA2E74")]
    public void AddSkill(SkillModelBase model)
    {
    }

    [Token(Token = "0x6015001")]
    [Address(RVA = "0x4AA2F1C", Offset = "0x4AA2F1C", VA = "0x4AA2F1C")]
    public void DecrementIndex()
    {
    }

    [Token(Token = "0x6015002")]
    [Address(RVA = "0x4AA2F2C", Offset = "0x4AA2F2C", VA = "0x4AA2F2C")]
    public void IncrementIndex()
    {
    }

    [Token(Token = "0x6015003")]
    [Address(RVA = "0x4AA2F3C", Offset = "0x4AA2F3C", VA = "0x4AA2F3C")]
    protected SkillModelListBase()
    {
    }
  }
}
