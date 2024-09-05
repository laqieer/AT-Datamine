// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitCellGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032B9")]
  public class UnitCellGroup : MonoBehaviour
  {
    [Token(Token = "0x400D9AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitCell[] unitCells;
    [Token(Token = "0x400D9AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image partyImage;
    [Token(Token = "0x400D9AC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform skillcCellParent;
    [Token(Token = "0x400D9AD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SkillCell baseItem;
    [Token(Token = "0x400D9AE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject nextPartyArrow;
    [Token(Token = "0x400D9AF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject prevPartyArrow;
    [Token(Token = "0x400D9B0")]
    [FieldOffset(Offset = "0x48")]
    private List<SkillCell> skillCells;

    [Token(Token = "0x6013CD6")]
    [Address(RVA = "0x1ADED20", Offset = "0x1ADED20", VA = "0x1ADED20")]
    public void SetData(Sprite partyIndexSprite, int[] styleIds)
    {
    }

    [Token(Token = "0x6013CD7")]
    [Address(RVA = "0x1ADEDD0", Offset = "0x1ADEDD0", VA = "0x1ADEDD0")]
    public void SetMindEquipment(
      bool isSupport,
      OrganizationPartySlot[] partySlots,
      EffectFactory effectFactory,
      BattleData battleData,
      BoardData boardData)
    {
    }

    [Token(Token = "0x6013CD8")]
    [Address(RVA = "0x1ADF4C0", Offset = "0x1ADF4C0", VA = "0x1ADF4C0")]
    public void SetPartyArrow(bool isNextArrow, bool isPrevArrow)
    {
    }

    [Token(Token = "0x6013CD9")]
    [Address(RVA = "0x1AE2BE0", Offset = "0x1AE2BE0", VA = "0x1AE2BE0")]
    public void Delete()
    {
    }

    [Token(Token = "0x6013CDA")]
    [Address(RVA = "0x1AE2A28", Offset = "0x1AE2A28", VA = "0x1AE2A28")]
    public void SkillCellDestroy()
    {
    }

    [Token(Token = "0x6013CDB")]
    [Address(RVA = "0x1AE2C44", Offset = "0x1AE2C44", VA = "0x1AE2C44")]
    public UnitCellGroup()
    {
    }
  }
}
