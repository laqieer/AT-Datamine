// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.CommonPopupContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CE1")]
  public class CommonPopupContent
  {
    [Token(Token = "0x17000ACA")]
    public bool IsNoTitle
    {
      [Token(Token = "0x60049F7"), Address(RVA = "0x313C4CC", Offset = "0x313C4CC", VA = "0x313C4CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60049F8"), Address(RVA = "0x313C4D4", Offset = "0x313C4D4", VA = "0x313C4D4")] private set
      {
      }
    }

    [Token(Token = "0x17000ACB")]
    public string Title
    {
      [Token(Token = "0x60049F9"), Address(RVA = "0x313C4E0", Offset = "0x313C4E0", VA = "0x313C4E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60049FA"), Address(RVA = "0x313C4E8", Offset = "0x313C4E8", VA = "0x313C4E8")] private set
      {
      }
    }

    [Token(Token = "0x17000ACC")]
    public string[] Message
    {
      [Token(Token = "0x60049FB"), Address(RVA = "0x313C4F0", Offset = "0x313C4F0", VA = "0x313C4F0")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x60049FC"), Address(RVA = "0x313C4F8", Offset = "0x313C4F8", VA = "0x313C4F8")] private set
      {
      }
    }

    [Token(Token = "0x17000ACD")]
    public bool IsReplaceColorTag
    {
      [Token(Token = "0x60049FD"), Address(RVA = "0x313C500", Offset = "0x313C500", VA = "0x313C500")] get
      {
        return new bool();
      }
      [Token(Token = "0x60049FE"), Address(RVA = "0x313C508", Offset = "0x313C508", VA = "0x313C508")] private set
      {
      }
    }

    [Token(Token = "0x17000ACE")]
    public bool IsReplaceSizeTag
    {
      [Token(Token = "0x60049FF"), Address(RVA = "0x313C514", Offset = "0x313C514", VA = "0x313C514")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A00"), Address(RVA = "0x313C51C", Offset = "0x313C51C", VA = "0x313C51C")] private set
      {
      }
    }

    [Token(Token = "0x17000ACF")]
    public bool IsOverrideTextAnchor
    {
      [Token(Token = "0x6004A01"), Address(RVA = "0x313C528", Offset = "0x313C528", VA = "0x313C528")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A02"), Address(RVA = "0x313C530", Offset = "0x313C530", VA = "0x313C530")] private set
      {
      }
    }

    [Token(Token = "0x17000AD0")]
    public TextAnchor OverrideAnchorType
    {
      [Token(Token = "0x6004A03"), Address(RVA = "0x313C53C", Offset = "0x313C53C", VA = "0x313C53C")] get
      {
        return new TextAnchor();
      }
      [Token(Token = "0x6004A04"), Address(RVA = "0x313C544", Offset = "0x313C544", VA = "0x313C544")] private set
      {
      }
    }

    [Token(Token = "0x17000AD1")]
    public bool IsHtml
    {
      [Token(Token = "0x6004A05"), Address(RVA = "0x313C54C", Offset = "0x313C54C", VA = "0x313C54C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A06"), Address(RVA = "0x313C554", Offset = "0x313C554", VA = "0x313C554")] private set
      {
      }
    }

    [Token(Token = "0x6004A07")]
    [Address(RVA = "0x313C560", Offset = "0x313C560", VA = "0x313C560")]
    public CommonPopupContent(string title, params string[] message)
    {
    }

    [Token(Token = "0x6004A08")]
    [Address(RVA = "0x313C41C", Offset = "0x313C41C", VA = "0x313C41C")]
    public CommonPopupContent(params string[] message)
    {
    }

    [Token(Token = "0x6004A09")]
    [Address(RVA = "0x313C60C", Offset = "0x313C60C", VA = "0x313C60C")]
    public static CommonPopupContentNoTitle NoTitle(
      string message,
      bool replaceColorTag = true,
      bool replaceSizeTag = true,
      bool overrideTextAnchor = false,
      TextAnchor overrideTextAnchorType = TextAnchor.MiddleCenter,
      bool enabledHtml = false)
    {
      return (CommonPopupContentNoTitle) null;
    }

    [Token(Token = "0x6004A0A")]
    [Address(RVA = "0x313C718", Offset = "0x313C718", VA = "0x313C718")]
    public static CommonPopupContentNoTitle NoTitleByGetText(
      string abName,
      string key,
      bool replaceColorTag = true,
      bool replaceSizeTag = true,
      bool overrideTextAnchor = false,
      TextAnchor overrideTextAnchorType = TextAnchor.MiddleCenter,
      bool enabledHtml = false)
    {
      return (CommonPopupContentNoTitle) null;
    }

    [Token(Token = "0x6004A0B")]
    [Address(RVA = "0x313C7BC", Offset = "0x313C7BC", VA = "0x313C7BC")]
    public static CommonPopupContentNoTitle NoTitleByGetTextSystem(
      string key,
      bool replaceColorTag = true,
      bool replaceSizeTag = true,
      bool overrideTextAnchor = false,
      TextAnchor overrideTextAnchorType = TextAnchor.MiddleCenter,
      bool enabledHtml = false)
    {
      return (CommonPopupContentNoTitle) null;
    }

    [Token(Token = "0x6004A0C")]
    [Address(RVA = "0x313C844", Offset = "0x313C844", VA = "0x313C844")]
    public static CommonPopupContent WithTitle(
      string title,
      string message,
      bool replaceColorTag = true,
      bool replaceSizeTag = true,
      bool overrideTextAnchor = false,
      TextAnchor overrideTextAnchorType = TextAnchor.MiddleCenter,
      bool enabledHtml = false)
    {
      return (CommonPopupContent) null;
    }

    [Token(Token = "0x6004A0D")]
    [Address(RVA = "0x313C958", Offset = "0x313C958", VA = "0x313C958")]
    public static CommonPopupContent WithTitle(
      string title,
      string[] message,
      bool replaceColorTag = true,
      bool replaceSizeTag = true,
      bool overrideTextAnchor = false,
      TextAnchor overrideTextAnchorType = TextAnchor.MiddleCenter,
      bool enabledHtml = false)
    {
      return (CommonPopupContent) null;
    }
  }
}
