// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.CustomSkillPopupView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x2003580")]
  public class CustomSkillPopupView : EquipmentPopupView
  {
    [Token(Token = "0x170045B5")]
    public EquipmentTitleUI.WithCustomSkillInfo AdditionalCustomSkill
    {
      [Token(Token = "0x6015012"), Address(RVA = "0x4AA4338", Offset = "0x4AA4338", VA = "0x4AA4338")] private get
      {
        return (EquipmentTitleUI.WithCustomSkillInfo) null;
      }
      [Token(Token = "0x6015013"), Address(RVA = "0x4AA4340", Offset = "0x4AA4340", VA = "0x4AA4340")] set
      {
      }
    }

    [Token(Token = "0x6015014")]
    [Address(RVA = "0x4AA1A88", Offset = "0x4AA1A88", VA = "0x4AA1A88")]
    public void SetCustomSkillLevel(int level)
    {
    }

    [Token(Token = "0x6015015")]
    [Address(RVA = "0x4AA1AD8", Offset = "0x4AA1AD8", VA = "0x4AA1AD8")]
    public void AddSubIcon(Sprite sprite, SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x6015016")]
    [Address(RVA = "0x4AA450C", Offset = "0x4AA450C", VA = "0x4AA450C")]
    public CustomSkillPopupView()
    {
    }
  }
}
