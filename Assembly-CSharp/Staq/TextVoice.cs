// Decompiled with JetBrains decompiler
// Type: staq.TextVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C53")]
  public class TextVoice
  {
    [Token(Token = "0x4010BA6")]
    [FieldOffset(Offset = "0x10")]
    public string Text;
    [Token(Token = "0x4010BA7")]
    [FieldOffset(Offset = "0x18")]
    public string Voice;

    [Token(Token = "0x6017B79")]
    [Address(RVA = "0x37B3374", Offset = "0x37B3374", VA = "0x37B3374")]
    public TextVoice(string text, string voice)
    {
    }

    [Token(Token = "0x6017B7A")]
    [Address(RVA = "0x37B33A0", Offset = "0x37B33A0", VA = "0x37B33A0", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
