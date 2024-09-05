// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookCommonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DA9")]
  public class PocketBookCommonPopup : MonoBehaviour
  {
    [Token(Token = "0x400C438")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor text;
    [Token(Token = "0x400C439")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor positiveText;
    [Token(Token = "0x400C43A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton positiveButton;
    [Token(Token = "0x400C43B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x17003D01")]
    public TextAccessor Text
    {
      [Token(Token = "0x6011DB6"), Address(RVA = "0x3FA5AE4", Offset = "0x3FA5AE4", VA = "0x3FA5AE4")] get
      {
        return (TextAccessor) null;
      }
    }

    [Token(Token = "0x17003D02")]
    public TextAccessor PositiveText
    {
      [Token(Token = "0x6011DB7"), Address(RVA = "0x3FA5AEC", Offset = "0x3FA5AEC", VA = "0x3FA5AEC")] get
      {
        return (TextAccessor) null;
      }
    }

    [Token(Token = "0x17003D03")]
    public CommonButton PositiveButton
    {
      [Token(Token = "0x6011DB8"), Address(RVA = "0x3FA5AF4", Offset = "0x3FA5AF4", VA = "0x3FA5AF4")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17003D04")]
    public Action OnConfirmAction
    {
      [Token(Token = "0x6011DB9"), Address(RVA = "0x3FA5AFC", Offset = "0x3FA5AFC", VA = "0x3FA5AFC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011DBA"), Address(RVA = "0x3FA5B04", Offset = "0x3FA5B04", VA = "0x3FA5B04")] set
      {
      }
    }

    [Token(Token = "0x17003D05")]
    public Action OnCancelAction
    {
      [Token(Token = "0x6011DBB"), Address(RVA = "0x3FA5B0C", Offset = "0x3FA5B0C", VA = "0x3FA5B0C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011DBC"), Address(RVA = "0x3FA5B14", Offset = "0x3FA5B14", VA = "0x3FA5B14")] set
      {
      }
    }

    [Token(Token = "0x6011DBD")]
    [Address(RVA = "0x3FA5B1C", Offset = "0x3FA5B1C", VA = "0x3FA5B1C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011DBE")]
    [Address(RVA = "0x3FA5BA8", Offset = "0x3FA5BA8", VA = "0x3FA5BA8")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x6011DBF")]
    [Address(RVA = "0x3FA5BC4", Offset = "0x3FA5BC4", VA = "0x3FA5BC4")]
    public void OnClickToCancel()
    {
    }

    [Token(Token = "0x6011DC0")]
    [Address(RVA = "0x3FA5BE0", Offset = "0x3FA5BE0", VA = "0x3FA5BE0")]
    public PocketBookCommonPopup()
    {
    }
  }
}
