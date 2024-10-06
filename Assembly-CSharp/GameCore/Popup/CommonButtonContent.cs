// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.CommonButtonContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CD1")]
  public class CommonButtonContent
  {
    [Token(Token = "0x17000AC4")]
    public bool IsTextOverride
    {
      [Token(Token = "0x60049B5"), Address(RVA = "0x313B148", Offset = "0x313B148", VA = "0x313B148")] get
      {
        return new bool();
      }
      [Token(Token = "0x60049B6"), Address(RVA = "0x313B150", Offset = "0x313B150", VA = "0x313B150")] private set
      {
      }
    }

    [Token(Token = "0x17000AC5")]
    public bool IsReplaceColorTag
    {
      [Token(Token = "0x60049B7"), Address(RVA = "0x313B15C", Offset = "0x313B15C", VA = "0x313B15C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60049B8"), Address(RVA = "0x313B164", Offset = "0x313B164", VA = "0x313B164")] private set
      {
      }
    }

    [Token(Token = "0x17000AC6")]
    public bool IsDisabledColor
    {
      [Token(Token = "0x60049B9"), Address(RVA = "0x313B170", Offset = "0x313B170", VA = "0x313B170")] get
      {
        return new bool();
      }
      [Token(Token = "0x60049BA"), Address(RVA = "0x313B178", Offset = "0x313B178", VA = "0x313B178")] private set
      {
      }
    }

    [Token(Token = "0x17000AC7")]
    public string Text
    {
      [Token(Token = "0x60049BB"), Address(RVA = "0x313B184", Offset = "0x313B184", VA = "0x313B184")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60049BC"), Address(RVA = "0x313B18C", Offset = "0x313B18C", VA = "0x313B18C")] private set
      {
      }
    }

    [Token(Token = "0x17000AC8")]
    public CommonButtonType CommonButtonType
    {
      [Token(Token = "0x60049BD"), Address(RVA = "0x313B194", Offset = "0x313B194", VA = "0x313B194")] get
      {
        return new CommonButtonType();
      }
      [Token(Token = "0x60049BE"), Address(RVA = "0x313B19C", Offset = "0x313B19C", VA = "0x313B19C")] private set
      {
      }
    }

    [Token(Token = "0x17000AC9")]
    public Action<CommonButtonContent> onClickEvent
    {
      [Token(Token = "0x60049BF"), Address(RVA = "0x313B1A4", Offset = "0x313B1A4", VA = "0x313B1A4")] get
      {
        return (Action<CommonButtonContent>) null;
      }
      [Token(Token = "0x60049C0"), Address(RVA = "0x313B1AC", Offset = "0x313B1AC", VA = "0x313B1AC")] private set
      {
      }
    }

    [Token(Token = "0x60049C1")]
    [Address(RVA = "0x313B1B4", Offset = "0x313B1B4", VA = "0x313B1B4")]
    private CommonButtonContent(
      string text,
      CommonButtonType commonButtonType,
      Action<CommonButtonContent> onClickEvent,
      bool isDisabledColor)
    {
    }

    [Token(Token = "0x60049C2")]
    [Address(RVA = "0x313B254", Offset = "0x313B254", VA = "0x313B254")]
    private CommonButtonContent(
      CommonButtonType commonButtonType,
      Action<CommonButtonContent> onClickEvent,
      bool isDisabledColor)
    {
    }

    [Token(Token = "0x60049C3")]
    [Address(RVA = "0x313B2E4", Offset = "0x313B2E4", VA = "0x313B2E4")]
    public static CommonButtonContent Decide(
      string overwriteLabel,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C4")]
    [Address(RVA = "0x313B3E0", Offset = "0x313B3E0", VA = "0x313B3E0")]
    public static CommonButtonContent Decide(
      string overwriteLabel,
      Action<CommonButtonContent> onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C5")]
    [Address(RVA = "0x313B45C", Offset = "0x313B45C", VA = "0x313B45C")]
    public static CommonButtonContent Decide(Action onClickEvent, bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C6")]
    [Address(RVA = "0x313B550", Offset = "0x313B550", VA = "0x313B550")]
    public static CommonButtonContent DecideByGetText(
      string abName,
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C7")]
    [Address(RVA = "0x313B5D4", Offset = "0x313B5D4", VA = "0x313B5D4")]
    public static CommonButtonContent DecideByGetTextSystem(
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C8")]
    [Address(RVA = "0x313B634", Offset = "0x313B634", VA = "0x313B634")]
    public static CommonButtonContent Cancel(
      string overwriteLabel,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049C9")]
    [Address(RVA = "0x313B730", Offset = "0x313B730", VA = "0x313B730")]
    public static CommonButtonContent Cancel(Action onClickEvent, bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CA")]
    [Address(RVA = "0x313B824", Offset = "0x313B824", VA = "0x313B824")]
    public static CommonButtonContent CancelByGetText(
      string abName,
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CB")]
    [Address(RVA = "0x313B8A8", Offset = "0x313B8A8", VA = "0x313B8A8")]
    public static CommonButtonContent CancelByGetTextSystem(
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CC")]
    [Address(RVA = "0x313B908", Offset = "0x313B908", VA = "0x313B908")]
    public static CommonButtonContent CancelByGetResources(
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CD")]
    [Address(RVA = "0x313B968", Offset = "0x313B968", VA = "0x313B968")]
    public static CommonButtonContent Other(
      string overwriteLabel,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CE")]
    [Address(RVA = "0x313BA64", Offset = "0x313BA64", VA = "0x313BA64")]
    public static CommonButtonContent OtherByGetText(
      string abName,
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049CF")]
    [Address(RVA = "0x313BAE8", Offset = "0x313BAE8", VA = "0x313BAE8")]
    public static CommonButtonContent OtherByGetTextSystem(
      string key,
      Action onClickEvent,
      bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049D0")]
    [Address(RVA = "0x313BB48", Offset = "0x313BB48", VA = "0x313BB48")]
    public static CommonButtonContent Back(Action onClickEvent, bool isDisabledColor = false)
    {
      return (CommonButtonContent) null;
    }

    [Token(Token = "0x60049D1")]
    [Address(RVA = "0x313BC3C", Offset = "0x313BC3C", VA = "0x313BC3C")]
    public void SetDisabledColorFlag(bool isDisabledColor)
    {
    }
  }
}
