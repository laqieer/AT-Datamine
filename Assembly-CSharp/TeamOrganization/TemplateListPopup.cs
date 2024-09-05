// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TemplateListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using Scenes.OutGame.OutGameMenu;
using System;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000830")]
  public class TemplateListPopup : MonoBehaviour
  {
    [Token(Token = "0x40026FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40026FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4002700")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4002701")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button setEditButton;
    [Token(Token = "0x4002702")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button setLoadButton;
    [Token(Token = "0x4002703")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TemplateListCell[] templateListCells;
    [Token(Token = "0x4002704")]
    [FieldOffset(Offset = "0x48")]
    private Action<bool, int, bool> closeAction;
    [Token(Token = "0x4002705")]
    [FieldOffset(Offset = "0x50")]
    private int selectSetIndex;
    [Token(Token = "0x4002706")]
    [FieldOffset(Offset = "0x54")]
    private int selectIndex;
    [Token(Token = "0x4002707")]
    [FieldOffset(Offset = "0x58")]
    private PartyListBelowScreen partyListBelowScreen;
    [Token(Token = "0x4002708")]
    [FieldOffset(Offset = "0x60")]
    private PartyFomationView partyFomationView;

    [Token(Token = "0x6002F21")]
    [Address(RVA = "0x3E6C1D4", Offset = "0x3E6C1D4", VA = "0x3E6C1D4")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6002F22")]
    [Address(RVA = "0x3E6C360", Offset = "0x3E6C360", VA = "0x3E6C360")]
    public void SetPartyListBelowScreen(PartyListBelowScreen partyListBelowScreen)
    {
    }

    [Token(Token = "0x6002F23")]
    [Address(RVA = "0x3E6C368", Offset = "0x3E6C368", VA = "0x3E6C368")]
    public void SetPartyFomationView(PartyFomationView partyFomationView)
    {
    }

    [Token(Token = "0x6002F24")]
    [Address(RVA = "0x3E6C370", Offset = "0x3E6C370", VA = "0x3E6C370")]
    public void Open(int selectIntex, int editIndex, bool isPartyEdit)
    {
    }

    [Token(Token = "0x6002F25")]
    [Address(RVA = "0x3E6C6E0", Offset = "0x3E6C6E0", VA = "0x3E6C6E0")]
    public void Close(bool isOverrideTemplate, int templateIndex, bool isOpenTemplateEdit)
    {
    }

    [Token(Token = "0x6002F26")]
    [Address(RVA = "0x3E6C840", Offset = "0x3E6C840", VA = "0x3E6C840")]
    public void UpdateCell()
    {
    }

    [Token(Token = "0x6002F27")]
    [Address(RVA = "0x3E6C8A0", Offset = "0x3E6C8A0", VA = "0x3E6C8A0")]
    public void OnSetEditButton()
    {
    }

    [Token(Token = "0x6002F28")]
    [Address(RVA = "0x3E6C920", Offset = "0x3E6C920", VA = "0x3E6C920")]
    private void OnSetLoadButton()
    {
    }

    [Token(Token = "0x6002F29")]
    [Address(RVA = "0x3E6C930", Offset = "0x3E6C930", VA = "0x3E6C930")]
    public void SetCloseAction(Action<bool, int, bool> closeAction)
    {
    }

    [Token(Token = "0x6002F2A")]
    [Address(RVA = "0x3E6C124", Offset = "0x3E6C124", VA = "0x3E6C124")]
    public void OnSelect(int index)
    {
    }

    [Token(Token = "0x6002F2B")]
    [Address(RVA = "0x3E6C938", Offset = "0x3E6C938", VA = "0x3E6C938")]
    public TemplateListPopup()
    {
    }
  }
}
