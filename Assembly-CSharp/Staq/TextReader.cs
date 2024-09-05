// Decompiled with JetBrains decompiler
// Type: staq.TextReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C54")]
  public class TextReader
  {
    [Token(Token = "0x4010BA8")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<string, string> TextsValue;
    [Token(Token = "0x4010BA9")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<string, TextVoice> TextVoicesValue;

    [Token(Token = "0x17004D42")]
    public Dictionary<string, string> Texts
    {
      [Token(Token = "0x6017B7B"), Address(RVA = "0x37B33EC", Offset = "0x37B33EC", VA = "0x37B33EC")] get
      {
        return (Dictionary<string, string>) null;
      }
    }

    [Token(Token = "0x17004D43")]
    public Dictionary<string, TextVoice> TextVoices
    {
      [Token(Token = "0x6017B7C"), Address(RVA = "0x37B361C", Offset = "0x37B361C", VA = "0x37B361C")] get
      {
        return (Dictionary<string, TextVoice>) null;
      }
    }

    [Token(Token = "0x6017B7D")]
    [Address(RVA = "0x37B38A4", Offset = "0x37B38A4", VA = "0x37B38A4")]
    public TextReader(Stream stream)
    {
    }

    [Token(Token = "0x6017B7E")]
    [Address(RVA = "0x37B38D0", Offset = "0x37B38D0", VA = "0x37B38D0")]
    public void Read(Stream stream)
    {
    }

    [Token(Token = "0x6017B7F")]
    [Address(RVA = "0x37B3C08", Offset = "0x37B3C08", VA = "0x37B3C08")]
    public static Dictionary<string, string> Load(string path) => (Dictionary<string, string>) null;

    [Token(Token = "0x2003C55")]
    public class Initializer : FileListInitializer
    {
      [Token(Token = "0x4010BAA")]
      [FieldOffset(Offset = "0x10")]
      public Dictionary<string, string> Texts;
      [Token(Token = "0x4010BAB")]
      [FieldOffset(Offset = "0x18")]
      public Dictionary<string, TextVoice> TextVoices;

      [Token(Token = "0x6017B80")]
      [Address(RVA = "0x37B3DD4", Offset = "0x37B3DD4", VA = "0x37B3DD4")]
      public Initializer(FileReader reader)
      {
      }

      [Token(Token = "0x6017B81")]
      [Address(RVA = "0x37B3DDC", Offset = "0x37B3DDC", VA = "0x37B3DDC", Slot = "5")]
      public override void Read(FileReader reader)
      {
      }
    }

    [Token(Token = "0x2003C57")]
    private class Reader : FileReader
    {
      [Token(Token = "0x6017B86")]
      [Address(RVA = "0x37B3BA0", Offset = "0x37B3BA0", VA = "0x37B3BA0")]
      public Reader(Stream stream)
      {
      }

      [Token(Token = "0x6017B87")]
      [Address(RVA = "0x37B474C", Offset = "0x37B474C", VA = "0x37B474C", Slot = "28")]
      public override FileInitializer ReadInitializer() => (FileInitializer) null;
    }
  }
}
