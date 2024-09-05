// Decompiled with JetBrains decompiler
// Type: Scenes.Title.SkipConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028E3")]
  public class SkipConfirmPopup
  {
    [Token(Token = "0x400AE5F")]
    private const string SKIP_CONFIRM_TITLE = "前回と同じキャラクターの外見・名前のまま、オープニングをスキップできます。\nスキップしますか？";
    [Token(Token = "0x400AE60")]
    private const string SKIP_BUTTON_NAME = "スキップする";
    [Token(Token = "0x400AE61")]
    private const string NON_SKIP_BUTTON_NAME = "スキップしない";
    [Token(Token = "0x400AE62")]
    [FieldOffset(Offset = "0x10")]
    public bool isSkip;

    [Token(Token = "0x601015A")]
    [Address(RVA = "0x416F060", Offset = "0x416F060", VA = "0x416F060")]
    public IEnumerator Open() => (IEnumerator) null;

    [Token(Token = "0x601015B")]
    [Address(RVA = "0x416F0F0", Offset = "0x416F0F0", VA = "0x416F0F0")]
    public SkipConfirmPopup()
    {
    }
  }
}
