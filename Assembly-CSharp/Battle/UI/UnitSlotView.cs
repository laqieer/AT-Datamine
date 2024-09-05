// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitSlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Style.UI;
using Scenes.OutGame.Info.Unit;
using Scenes.OutGame.OutGameMenu;
using System;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023AE")]
  public class UnitSlotView : MonoBehaviour
  {
    [Token(Token = "0x4009803")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PartySlotUI slotUI;
    [Token(Token = "0x4009804")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleLpUI lpUI;
    [Token(Token = "0x4009805")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipmentSlotView equipmentView;
    [Token(Token = "0x4009806")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CustomSkillView customSkillView;
    [Token(Token = "0x4009807")]
    [FieldOffset(Offset = "0x38")]
    private Sprite lpSpriteOn;
    [Token(Token = "0x4009808")]
    [FieldOffset(Offset = "0x40")]
    private Sprite lpSpriteOff;
    [Token(Token = "0x4009809")]
    [FieldOffset(Offset = "0x48")]
    private StyleThumb styleThumbPrefab;
    [Token(Token = "0x400980B")]
    [FieldOffset(Offset = "0x58")]
    private bool isDisplayLp;
    [Token(Token = "0x400980C")]
    [FieldOffset(Offset = "0x60")]
    public Action OnClickStyleThumb;

    [Token(Token = "0x17002F17")]
    public StyleThumb StyleThumb
    {
      [Token(Token = "0x600DA59"), Address(RVA = "0x22D84E8", Offset = "0x22D84E8", VA = "0x22D84E8")] get
      {
        return (StyleThumb) null;
      }
      [Token(Token = "0x600DA5A"), Address(RVA = "0x22D84F0", Offset = "0x22D84F0", VA = "0x22D84F0")] protected set
      {
      }
    }

    [Token(Token = "0x600DA5B")]
    [Address(RVA = "0x22D3F1C", Offset = "0x22D3F1C", VA = "0x22D3F1C")]
    public void Initialize(bool isDisplayLp, Action finishInitializeAction)
    {
    }

    [Token(Token = "0x600DA5C")]
    [Address(RVA = "0x22D4180", Offset = "0x22D4180", VA = "0x22D4180")]
    public void UpdateView(UnitModelBase model)
    {
    }

    [Token(Token = "0x600DA5D")]
    [Address(RVA = "0x22D84F8", Offset = "0x22D84F8", VA = "0x22D84F8")]
    private StyleThumb CreateStyleThumb() => (StyleThumb) null;

    [Token(Token = "0x600DA5E")]
    [Address(RVA = "0x22D40D4", Offset = "0x22D40D4", VA = "0x22D40D4")]
    public void SetOnClickEquipment(
      Action<OrganizationEquipmentSlot.EquipmentSlotType> onClick)
    {
    }

    [Token(Token = "0x600DA5F")]
    [Address(RVA = "0x22D8640", Offset = "0x22D8640", VA = "0x22D8640")]
    private void OnStyleThumbButton()
    {
    }

    [Token(Token = "0x600DA60")]
    [Address(RVA = "0x22D4EDC", Offset = "0x22D4EDC", VA = "0x22D4EDC")]
    public void SetActiveLpUI(bool isEnable)
    {
    }

    [Token(Token = "0x600DA61")]
    [Address(RVA = "0x22D4EF4", Offset = "0x22D4EF4", VA = "0x22D4EF4")]
    public void SetActiveEquipmentDurableUI(bool isEnable)
    {
    }

    [Token(Token = "0x600DA62")]
    [Address(RVA = "0x22D865C", Offset = "0x22D865C", VA = "0x22D865C")]
    public UnitSlotView()
    {
    }
  }
}
