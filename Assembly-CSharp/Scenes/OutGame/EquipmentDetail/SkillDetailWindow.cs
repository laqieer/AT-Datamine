// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.SkillDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003694")]
  public class SkillDetailWindow : SkillWindowBase
  {
    [Token(Token = "0x400ED69")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _closeButton;
    [Token(Token = "0x400ED6A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton _prevButton;
    [Token(Token = "0x400ED6B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton _nextButton;

    [Token(Token = "0x601577C")]
    [Address(RVA = "0x18E7EE0", Offset = "0x18E7EE0", VA = "0x18E7EE0")]
    public void SetDetailMode()
    {
    }

    [Token(Token = "0x601577D")]
    [Address(RVA = "0x18E7F30", Offset = "0x18E7F30", VA = "0x18E7F30")]
    public void SetLvChangeInfoMode()
    {
    }

    [Token(Token = "0x601577E")]
    [Address(RVA = "0x18E7F80", Offset = "0x18E7F80", VA = "0x18E7F80")]
    public void SetCloseEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x601577F")]
    [Address(RVA = "0x18E7FD0", Offset = "0x18E7FD0", VA = "0x18E7FD0")]
    public void SetPrevEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015780")]
    [Address(RVA = "0x18E8020", Offset = "0x18E8020", VA = "0x18E8020")]
    public void SetPrevInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6015781")]
    [Address(RVA = "0x18E8040", Offset = "0x18E8040", VA = "0x18E8040")]
    public void SetNextEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015782")]
    [Address(RVA = "0x18E8090", Offset = "0x18E8090", VA = "0x18E8090")]
    public void SetNextInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6015783")]
    [Address(RVA = "0x18E80B0", Offset = "0x18E80B0", VA = "0x18E80B0")]
    public SkillDetailWindow()
    {
    }
  }
}
