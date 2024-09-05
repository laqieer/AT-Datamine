// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleNameListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x2003470")]
  public class TitleNameListItem : MonoBehaviour
  {
    [Token(Token = "0x400E40C")]
    private const string TWEEN_KEY_SET = "Set";
    [Token(Token = "0x400E40D")]
    private const string TWEEN_KEY_ON = "On";
    [Token(Token = "0x400E40E")]
    private const string TWEEN_KEY_OFF = "Off";
    [Token(Token = "0x400E40F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E410")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI titleText;
    [Token(Token = "0x400E411")]
    [FieldOffset(Offset = "0x28")]
    private Action onClickAction;

    [Token(Token = "0x17004458")]
    public int TitleId
    {
      [Token(Token = "0x6014927"), Address(RVA = "0x1AA80AC", Offset = "0x1AA80AC", VA = "0x1AA80AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014928"), Address(RVA = "0x1AA80B4", Offset = "0x1AA80B4", VA = "0x1AA80B4")] private set
      {
      }
    }

    [Token(Token = "0x17004459")]
    public bool IsUnlockedTitle
    {
      [Token(Token = "0x6014929"), Address(RVA = "0x1AA80BC", Offset = "0x1AA80BC", VA = "0x1AA80BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x601492A"), Address(RVA = "0x1AA80C4", Offset = "0x1AA80C4", VA = "0x1AA80C4")] private set
      {
      }
    }

    [Token(Token = "0x601492B")]
    [Address(RVA = "0x1AA7AB0", Offset = "0x1AA7AB0", VA = "0x1AA7AB0")]
    public void Initialize(
      ITitleMasterData title,
      int defaultFontSize,
      bool unlocked,
      Action onClickAction)
    {
    }

    [Token(Token = "0x601492C")]
    [Address(RVA = "0x1AA80D0", Offset = "0x1AA80D0", VA = "0x1AA80D0")]
    public void OnItemClick()
    {
    }

    [Token(Token = "0x601492D")]
    [Address(RVA = "0x1AA7DB0", Offset = "0x1AA7DB0", VA = "0x1AA7DB0")]
    public void SetSelected(bool selected)
    {
    }

    [Token(Token = "0x601492E")]
    [Address(RVA = "0x1AA80EC", Offset = "0x1AA80EC", VA = "0x1AA80EC")]
    public TitleNameListItem()
    {
    }
  }
}
