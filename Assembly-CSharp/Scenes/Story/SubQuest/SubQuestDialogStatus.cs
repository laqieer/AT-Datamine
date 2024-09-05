// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.SubQuestDialogStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D8D")]
  public class SubQuestDialogStatus
  {
    [Token(Token = "0x400C3A3")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string> TEXT_RECEIPT;
    [Token(Token = "0x400C3A4")]
    [FieldOffset(Offset = "0x8")]
    private static Func<string> TEXT_COMPLETE;
    [Token(Token = "0x400C3A5")]
    [FieldOffset(Offset = "0x10")]
    private static Func<string> TEXT_AUTOMOVE;
    [Token(Token = "0x400C3A6")]
    [FieldOffset(Offset = "0x18")]
    private static Func<string> TEXT_CLOSE;
    [Token(Token = "0x400C3A7")]
    [FieldOffset(Offset = "0x20")]
    private static Func<string> TEXT_REMOVE;

    [Token(Token = "0x6011CF8")]
    [Address(RVA = "0x3F9E524", Offset = "0x3F9E524", VA = "0x3F9E524")]
    public static DialogStatus Receipt(SubQuestData subquest) => (DialogStatus) null;

    [Token(Token = "0x6011CF9")]
    [Address(RVA = "0x3F9E37C", Offset = "0x3F9E37C", VA = "0x3F9E37C")]
    public static DialogStatus Receipting(SubQuestData subquest) => (DialogStatus) null;

    [Token(Token = "0x6011CFA")]
    [Address(RVA = "0x3F9E218", Offset = "0x3F9E218", VA = "0x3F9E218")]
    public static DialogStatus Complete() => (DialogStatus) null;

    [Token(Token = "0x6011CFB")]
    [Address(RVA = "0x3F9E0DC", Offset = "0x3F9E0DC", VA = "0x3F9E0DC")]
    public static DialogStatus Completed() => (DialogStatus) null;

    [Token(Token = "0x6011CFC")]
    [Address(RVA = "0x3F9ED48", Offset = "0x3F9ED48", VA = "0x3F9ED48")]
    public static DialogStatus AutoMove(SubQuestData subquest) => (DialogStatus) null;

    [Token(Token = "0x6011CFD")]
    [Address(RVA = "0x3F9FCA0", Offset = "0x3F9FCA0", VA = "0x3F9FCA0")]
    public SubQuestDialogStatus()
    {
    }

    [Token(Token = "0x6011CFE")]
    [Address(RVA = "0x3F9FCA8", Offset = "0x3F9FCA8", VA = "0x3F9FCA8")]
    static SubQuestDialogStatus()
    {
    }
  }
}
