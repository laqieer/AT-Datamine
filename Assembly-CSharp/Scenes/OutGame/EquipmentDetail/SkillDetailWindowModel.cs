// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.SkillDetailWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003695")]
  public class SkillDetailWindowModel
  {
    [Token(Token = "0x400ED6C")]
    [FieldOffset(Offset = "0x10")]
    private readonly EquipmentSkill _skill;
    [Token(Token = "0x400ED6D")]
    [FieldOffset(Offset = "0x18")]
    private int _skillLv;

    [Token(Token = "0x6015784")]
    [Address(RVA = "0x18E80B8", Offset = "0x18E80B8", VA = "0x18E80B8")]
    public SkillDetailWindowModel(EquipmentSkill skill)
    {
    }

    [Token(Token = "0x17004738")]
    public RarityTypeEnum Rarity
    {
      [Token(Token = "0x6015785"), Address(RVA = "0x18E80F0", Offset = "0x18E80F0", VA = "0x18E80F0")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17004739")]
    public SkillDetailData CurentLvSkill
    {
      [Token(Token = "0x6015786"), Address(RVA = "0x18E8110", Offset = "0x18E8110", VA = "0x18E8110")] get
      {
        return (SkillDetailData) null;
      }
    }

    [Token(Token = "0x1700473A")]
    public SkillDetailData PrevLvSkill
    {
      [Token(Token = "0x6015787"), Address(RVA = "0x18E81B4", Offset = "0x18E81B4", VA = "0x18E81B4")] get
      {
        return (SkillDetailData) null;
      }
    }

    [Token(Token = "0x1700473B")]
    public bool IsExistPrevLv
    {
      [Token(Token = "0x6015788"), Address(RVA = "0x18E825C", Offset = "0x18E825C", VA = "0x18E825C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700473C")]
    public SkillDetailData NextLvSkill
    {
      [Token(Token = "0x6015789"), Address(RVA = "0x18E8274", Offset = "0x18E8274", VA = "0x18E8274")] get
      {
        return (SkillDetailData) null;
      }
    }

    [Token(Token = "0x1700473D")]
    public bool IsExistNextLv
    {
      [Token(Token = "0x601578A"), Address(RVA = "0x18E831C", Offset = "0x18E831C", VA = "0x18E831C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601578B")]
    [Address(RVA = "0x18E8334", Offset = "0x18E8334", VA = "0x18E8334")]
    public void OnNextLv()
    {
    }

    [Token(Token = "0x601578C")]
    [Address(RVA = "0x18E8378", Offset = "0x18E8378", VA = "0x18E8378")]
    public void OnPrevLv()
    {
    }
  }
}
