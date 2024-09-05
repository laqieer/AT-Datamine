// Decompiled with JetBrains decompiler
// Type: ISAdQualityJSON.Json
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

#nullable disable
namespace ISAdQualityJSON
{
  [Token(Token = "0x2003FB8")]
  public static class Json
  {
    [Token(Token = "0x6019A06")]
    [Address(RVA = "0x3783CD8", Offset = "0x3783CD8", VA = "0x3783CD8")]
    public static object Deserialize(string json) => (object) null;

    [Token(Token = "0x6019A07")]
    [Address(RVA = "0x3783E80", Offset = "0x3783E80", VA = "0x3783E80")]
    public static string Serialize(object obj) => (string) null;

    [Token(Token = "0x2003FB9")]
    private sealed class Parser : IDisposable
    {
      [Token(Token = "0x4011712")]
      private const string WHITE_SPACE = " \t\n\r";
      [Token(Token = "0x4011713")]
      private const string WORD_BREAK = " \t\n\r{}[],:\"";
      [Token(Token = "0x4011714")]
      [FieldOffset(Offset = "0x10")]
      private StringReader json;

      [Token(Token = "0x6019A08")]
      [Address(RVA = "0x3783EF8", Offset = "0x3783EF8", VA = "0x3783EF8")]
      private Parser(string jsonString)
      {
      }

      [Token(Token = "0x6019A09")]
      [Address(RVA = "0x3783CE4", Offset = "0x3783CE4", VA = "0x3783CE4")]
      public static object Parse(string jsonString) => (object) null;

      [Token(Token = "0x6019A0A")]
      [Address(RVA = "0x3783F90", Offset = "0x3783F90", VA = "0x3783F90", Slot = "4")]
      public void Dispose()
      {
      }

      [Token(Token = "0x6019A0B")]
      [Address(RVA = "0x3783FB8", Offset = "0x3783FB8", VA = "0x3783FB8")]
      private Dictionary<string, object> ParseObject() => (Dictionary<string, object>) null;

      [Token(Token = "0x6019A0C")]
      [Address(RVA = "0x37844DC", Offset = "0x37844DC", VA = "0x37844DC")]
      private List<object> ParseArray() => (List<object>) null;

      [Token(Token = "0x6019A0D")]
      [Address(RVA = "0x3783F74", Offset = "0x3783F74", VA = "0x3783F74")]
      private object ParseValue() => (object) null;

      [Token(Token = "0x6019A0E")]
      [Address(RVA = "0x3784600", Offset = "0x3784600", VA = "0x3784600")]
      private object ParseByToken(Json.Parser.TOKEN token) => (object) null;

      [Token(Token = "0x6019A0F")]
      [Address(RVA = "0x37842A0", Offset = "0x37842A0", VA = "0x37842A0")]
      private string ParseString() => (string) null;

      [Token(Token = "0x6019A10")]
      [Address(RVA = "0x37846E8", Offset = "0x37846E8", VA = "0x37846E8")]
      private object ParseNumber() => (object) null;

      [Token(Token = "0x6019A11")]
      [Address(RVA = "0x3784948", Offset = "0x3784948", VA = "0x3784948")]
      private void EatWhitespace()
      {
      }

      [Token(Token = "0x1700529B")]
      private char PeekChar
      {
        [Token(Token = "0x6019A12"), Address(RVA = "0x37849E4", Offset = "0x37849E4", VA = "0x37849E4")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x1700529C")]
      private char NextChar
      {
        [Token(Token = "0x6019A13"), Address(RVA = "0x37847F8", Offset = "0x37847F8", VA = "0x37847F8")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x1700529D")]
      private string NextWord
      {
        [Token(Token = "0x6019A14"), Address(RVA = "0x3784870", Offset = "0x3784870", VA = "0x3784870")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700529E")]
      private Json.Parser.TOKEN NextToken
      {
        [Token(Token = "0x6019A15"), Address(RVA = "0x37840DC", Offset = "0x37840DC", VA = "0x37840DC")] get
        {
          return new Json.Parser.TOKEN();
        }
      }

      [Token(Token = "0x2003FBA")]
      private enum TOKEN
      {
        [Token(Token = "0x4011716")] NONE,
        [Token(Token = "0x4011717")] CURLY_OPEN,
        [Token(Token = "0x4011718")] CURLY_CLOSE,
        [Token(Token = "0x4011719")] SQUARED_OPEN,
        [Token(Token = "0x401171A")] SQUARED_CLOSE,
        [Token(Token = "0x401171B")] COLON,
        [Token(Token = "0x401171C")] COMMA,
        [Token(Token = "0x401171D")] STRING,
        [Token(Token = "0x401171E")] NUMBER,
        [Token(Token = "0x401171F")] TRUE,
        [Token(Token = "0x4011720")] FALSE,
        [Token(Token = "0x4011721")] NULL,
      }
    }

    [Token(Token = "0x2003FBB")]
    private sealed class Serializer
    {
      [Token(Token = "0x4011722")]
      [FieldOffset(Offset = "0x10")]
      private StringBuilder builder;

      [Token(Token = "0x6019A16")]
      [Address(RVA = "0x3784A5C", Offset = "0x3784A5C", VA = "0x3784A5C")]
      private Serializer()
      {
      }

      [Token(Token = "0x6019A17")]
      [Address(RVA = "0x3783E84", Offset = "0x3783E84", VA = "0x3783E84")]
      public static string Serialize(object obj) => (string) null;

      [Token(Token = "0x6019A18")]
      [Address(RVA = "0x3784AC8", Offset = "0x3784AC8", VA = "0x3784AC8")]
      private void SerializeValue(object value)
      {
      }

      [Token(Token = "0x6019A19")]
      [Address(RVA = "0x3785280", Offset = "0x3785280", VA = "0x3785280")]
      private void SerializeObject(IDictionary obj)
      {
      }

      [Token(Token = "0x6019A1A")]
      [Address(RVA = "0x3784F20", Offset = "0x3784F20", VA = "0x3784F20")]
      private void SerializeArray(IList anArray)
      {
      }

      [Token(Token = "0x6019A1B")]
      [Address(RVA = "0x3784C68", Offset = "0x3784C68", VA = "0x3784C68")]
      private void SerializeString(string str)
      {
      }

      [Token(Token = "0x6019A1C")]
      [Address(RVA = "0x378570C", Offset = "0x378570C", VA = "0x378570C")]
      private void SerializeOther(object value)
      {
      }
    }
  }
}
