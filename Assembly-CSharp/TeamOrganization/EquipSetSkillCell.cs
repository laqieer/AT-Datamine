// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetSkillCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C8")]
  public class EquipSetSkillCell : MonoBehaviour
  {
    [Token(Token = "0x4002468")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform skillSlotParent;
    [Token(Token = "0x4002469")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private DetailSkillListThumb skillSlot;
    [Token(Token = "0x400246A")]
    [FieldOffset(Offset = "0x28")]
    private List<DetailSkillListThumb> equipSetSkillSlots;
    [Token(Token = "0x400246B")]
    [FieldOffset(Offset = "0x30")]
    private Style style;

    [Token(Token = "0x6002C16")]
    [Address(RVA = "0x3877E8C", Offset = "0x3877E8C", VA = "0x3877E8C")]
    public void UpdateSkill(
      (UnitSkill skill, string openCondition)[] unitSkills,
      IAssetProvider assetProvider,
      Style style)
    {
    }

    [Token(Token = "0x6002C17")]
    [Address(RVA = "0x3878468", Offset = "0x3878468", VA = "0x3878468")]
    public void UpdateSkill(
      (CommunicationSkill skill, string openCondition)[] commuSkills,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C18")]
    [Address(RVA = "0x387853C", Offset = "0x387853C", VA = "0x387853C")]
    public void UpdateSkill(EquipSkillData[] equipSkillDatas, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C19")]
    [Address(RVA = "0x3878610", Offset = "0x3878610", VA = "0x3878610")]
    public void UpdateSkill(CustomSkill[] customSkills, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C1A")]
    [Address(RVA = "0x3877F70", Offset = "0x3877F70", VA = "0x3877F70")]
    private void UpdateSkillInternal(
      int skillCount,
      Func<int, (int, int, RarityTypeEnum, string)> callback,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6002C1B")]
    [Address(RVA = "0x38786F4", Offset = "0x38786F4", VA = "0x38786F4")]
    private bool IsExSkill(int skillId) => new bool();

    [Token(Token = "0x6002C1C")]
    [Address(RVA = "0x3878824", Offset = "0x3878824", VA = "0x3878824")]
    public EquipSetSkillCell()
    {
    }
  }
}
