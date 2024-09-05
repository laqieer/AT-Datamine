// Decompiled with JetBrains decompiler
// Type: IronSourceJSON.Json
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
namespace IronSourceJSON
{
  [Token(Token = "0x2003FBC")]
  public static class Json
  {
    [Token(Token = "0x6019A1D")]
    [Address(RVA = "0x37858E8", Offset = "0x37858E8", VA = "0x37858E8")]
    public static object Deserialize(string json) => (object) null;

    [Token(Token = "0x6019A1E")]
    [Address(RVA = "0x3785AA4", Offset = "0x3785AA4", VA = "0x3785AA4")]
    public static string Serialize(object obj) => (string) null;

    [Token(Token = "0x2003FBD")]
    private sealed class Parser : IDisposable
    {
      [Token(Token = "0x4011723")]
      private const string WHITE_SPACE = " \t\n\r";
      [Token(Token = "0x4011724")]
      private const string WORD_BREAK = " \t\n\r{}[],:\"";
      [Token(Token = "0x4011725")]
      [FieldOffset(Offset = "0x10")]
      private StringReader json;

      [Token(Token = "0x6019A1F")]
      [Address(RVA = "0x3785B1C", Offset = "0x3785B1C", VA = "0x3785B1C")]
      private Parser(string jsonString)
      {
      }

      [Token(Token = "0x6019A20")]
      [Address(RVA = "0x37858F4", Offset = "0x37858F4", VA = "0x37858F4")]
      public static object Parse(string jsonString) => (object) null;

      [Token(Token = "0x6019A21")]
      [Address(RVA = "0x3785BB4", Offset = "0x3785BB4", VA = "0x3785BB4", Slot = "4")]
      public void Dispose()
      {
      }

      [Token(Token = "0x6019A22")]
      [Address(RVA = "0x3785BDC", Offset = "0x3785BDC", VA = "0x3785BDC")]
      private Dictionary<string, object> ParseObject() => (Dictionary<string, object>) null;

      [Token(Token = "0x6019A23")]
      [Address(RVA = "0x3786100", Offset = "0x3786100", VA = "0x3786100")]
      private List<object> ParseArray() => (List<object>) null;

      [Token(Token = "0x6019A24")]
      [Address(RVA = "0x3785B98", Offset = "0x3785B98", VA = "0x3785B98")]
      private object ParseValue() => (object) null;

      [Token(Token = "0x6019A25")]
      [Address(RVA = "0x3786224", Offset = "0x3786224", VA = "0x3786224")]
      private object ParseByToken(Json.Parser.TOKEN token) => (object) null;

      [Token(Token = "0x6019A26")]
      [Address(RVA = "0x3785EC4", Offset = "0x3785EC4", VA = "0x3785EC4")]
      private string ParseString() => (string) null;

      [Token(Token = "0x6019A27")]
      [Address(RVA = "0x378630C", Offset = "0x378630C", VA = "0x378630C")]
      private object ParseNumber() => (object) null;

      [Token(Token = "0x6019A28")]
      [Address(RVA = "0x378656C", Offset = "0x378656C", VA = "0x378656C")]
      private void EatWhitespace()
      {
      }

      [Token(Token = "0x1700529F")]
      private char PeekChar
      {
        [Token(Token = "0x6019A29"), Address(RVA = "0x3786608", Offset = "0x3786608", VA = "0x3786608")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x170052A0")]
      private char NextChar
      {
        [Token(Token = "0x6019A2A"), Address(RVA = "0x378641C", Offset = "0x378641C", VA = "0x378641C")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x170052A1")]
      private string NextWord
      {
        [Token(Token = "0x6019A2B"), Address(RVA = "0x3786494", Offset = "0x3786494", VA = "0x3786494")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170052A2")]
      private Json.Parser.TOKEN NextToken
      {
        [Token(Token = "0x6019A2C"), Address(RVA = "0x3785D00", Offset = "0x3785D00", VA = "0x3785D00")] get
        {
          return new Json.Parser.TOKEN();
        }
      }

      [Token(Token = "0x2003FBE")]
      private enum TOKEN
      {
        [Token(Token = "0x4011727")] NONE,
        [Token(Token = "0x4011728")] CURLY_OPEN,
        [Token(Token = "0x4011729")] CURLY_CLOSE,
        [Token(Token = "0x401172A")] SQUARED_OPEN,
        [Token(Token = "0x401172B")] SQUARED_CLOSE,
        [Token(Token = "0x401172C")] COLON,
        [Token(Token = "0x401172D")] COMMA,
        [Token(Token = "0x401172E")] STRING,
        [Token(Token = "0x401172F")] NUMBER,
        [Token(Token = "0x4011730")] TRUE,
        [Token(Token = "0x4011731")] FALSE,
        [Token(Token = "0x4011732")] NULL,
      }
    }

    [Token(Token = "0x2003FBF")]
    private sealed class Serializer
    {
      [Token(Token = "0x4011733")]
      [FieldOffset(Offset = "0x10")]
      private StringBuilder builder;

      [Token(Token = "0x6019A2D")]
      [Address(RVA = "0x3786680", Offset = "0x3786680", VA = "0x3786680")]
      private Serializer()
      {
      }

      [Token(Token = "0x6019A2E")]
      [Address(RVA = "0x3785AA8", Offset = "0x3785AA8", VA = "0x3785AA8")]
      public static string Serialize(object obj) => (string) null;

      [Token(Token = "0x6019A2F")]
      [Address(RVA = "0x37866EC", Offset = "0x37866EC", VA = "0x37866EC")]
      private void SerializeValue(object value)
      {
      }

      [Token(Token = "0x6019A30")]
      [Address(RVA = "0x3786EA4", Offset = "0x3786EA4", VA = "0x3786EA4")]
      private void SerializeObject(IDictionary obj)
      {
      }

      [Token(Token = "0x6019A31")]
      [Address(RVA = "0x3786B44", Offset = "0x3786B44", VA = "0x3786B44")]
      private void SerializeArray(IList anArray)
      {
      }

      [Token(Token = "0x6019A32")]
      [Address(RVA = "0x378688C", Offset = "0x378688C", VA = "0x378688C")]
      private void SerializeString(string str)
      {
      }

      [Token(Token = "0x6019A33")]
      [Address(RVA = "0x3787330", Offset = "0x3787330", VA = "0x3787330")]
      private void SerializeOther(object value)
      {
      }
    }
  }
}
