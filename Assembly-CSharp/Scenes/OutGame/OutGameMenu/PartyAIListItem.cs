// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PartyAIListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AEB")]
  public class PartyAIListItem : MonoBehaviour
  {
    [Token(Token = "0x401037B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x401037C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI aiName;
    [Token(Token = "0x401037D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI summary;
    [Token(Token = "0x401037E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject onButton;
    [Token(Token = "0x401037F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject offButton;

    [Token(Token = "0x17004BAE")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60172E2"), Address(RVA = "0x30129F8", Offset = "0x30129F8", VA = "0x30129F8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004BAF")]
    public Action<int> OnSelectPartyAI
    {
      [Token(Token = "0x60172E3"), Address(RVA = "0x3012A00", Offset = "0x3012A00", VA = "0x3012A00")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60172E4"), Address(RVA = "0x3012A08", Offset = "0x3012A08", VA = "0x3012A08")] set
      {
      }
    }

    [Token(Token = "0x17004BB0")]
    public int PartyAiID
    {
      [Token(Token = "0x60172E5"), Address(RVA = "0x3012A10", Offset = "0x3012A10", VA = "0x3012A10")] get
      {
        return new int();
      }
      [Token(Token = "0x60172E6"), Address(RVA = "0x3012A18", Offset = "0x3012A18", VA = "0x3012A18")] private set
      {
      }
    }

    [Token(Token = "0x60172E7")]
    [Address(RVA = "0x3012A20", Offset = "0x3012A20", VA = "0x3012A20")]
    public void SetPartyAI(int partyAiId, int nowPartyAiId)
    {
    }

    [Token(Token = "0x60172E8")]
    [Address(RVA = "0x3012A74", Offset = "0x3012A74", VA = "0x3012A74")]
    public void OnClickToToggle()
    {
    }

    [Token(Token = "0x60172E9")]
    [Address(RVA = "0x3012AC8", Offset = "0x3012AC8", VA = "0x3012AC8")]
    public void ChangeOffButton()
    {
    }

    [Token(Token = "0x60172EA")]
    [Address(RVA = "0x3012B00", Offset = "0x3012B00", VA = "0x3012B00")]
    public PartyAIListItem()
    {
    }
  }
}
