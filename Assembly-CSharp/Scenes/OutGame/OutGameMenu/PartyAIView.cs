// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PartyAIView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AEC")]
  public class PartyAIView : MonoBehaviour
  {
    [Token(Token = "0x4010382")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010383")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PartyAIListItem baseItem;
    [Token(Token = "0x4010384")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform itemParent;
    [Token(Token = "0x4010386")]
    [FieldOffset(Offset = "0x38")]
    private int partyAITypeId;
    [Token(Token = "0x4010387")]
    [FieldOffset(Offset = "0x40")]
    private List<PartyAIListItem> partyAIListItems;

    [Token(Token = "0x17004BB1")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60172EB"), Address(RVA = "0x3012B08", Offset = "0x3012B08", VA = "0x3012B08")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004BB2")]
    public Action<int> OnClickToCloseAction
    {
      [Token(Token = "0x60172EC"), Address(RVA = "0x3012B10", Offset = "0x3012B10", VA = "0x3012B10")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60172ED"), Address(RVA = "0x3012B18", Offset = "0x3012B18", VA = "0x3012B18")] set
      {
      }
    }

    [Token(Token = "0x60172EE")]
    [Address(RVA = "0x3012B20", Offset = "0x3012B20", VA = "0x3012B20")]
    public void Init(int aiTypeID)
    {
    }

    [Token(Token = "0x60172EF")]
    [Address(RVA = "0x3012B28", Offset = "0x3012B28", VA = "0x3012B28")]
    private void CreatePartyAIList(int aiTypeID)
    {
    }

    [Token(Token = "0x60172F0")]
    [Address(RVA = "0x3012EC0", Offset = "0x3012EC0", VA = "0x3012EC0")]
    public void OnChangePartyAI(int changePartyAiId)
    {
    }

    [Token(Token = "0x60172F1")]
    [Address(RVA = "0x3012F7C", Offset = "0x3012F7C", VA = "0x3012F7C")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x60172F2")]
    [Address(RVA = "0x3012F9C", Offset = "0x3012F9C", VA = "0x3012F9C")]
    public void Delete()
    {
    }

    [Token(Token = "0x60172F3")]
    [Address(RVA = "0x30130A4", Offset = "0x30130A4", VA = "0x30130A4")]
    public PartyAIView()
    {
    }
  }
}
