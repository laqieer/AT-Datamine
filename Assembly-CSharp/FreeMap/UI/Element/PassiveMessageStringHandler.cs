// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.PassiveMessageStringHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.Element
{
  [Token(Token = "0x20016A8")]
  public class PassiveMessageStringHandler
  {
    [Token(Token = "0x40065A1")]
    private const string TextIndentionCode = "\n";
    [Token(Token = "0x40065A2")]
    private const string DefaultNullText = "0";

    [Token(Token = "0x170013DA")]
    public List<string> MessageBlockList
    {
      [Token(Token = "0x6008038"), Address(RVA = "0x41F1DBC", Offset = "0x41F1DBC", VA = "0x41F1DBC")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6008039"), Address(RVA = "0x41F1DC4", Offset = "0x41F1DC4", VA = "0x41F1DC4")] private set
      {
      }
    }

    [Token(Token = "0x170013DB")]
    public int MessageBlockCount
    {
      [Token(Token = "0x600803A"), Address(RVA = "0x41F1DCC", Offset = "0x41F1DCC", VA = "0x41F1DCC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600803B")]
    [Address(RVA = "0x41F1E14", Offset = "0x41F1E14", VA = "0x41F1E14")]
    public PassiveMessageStringHandler(StoryFreeActionPassiveTalkMessageData data)
    {
    }

    [Token(Token = "0x600803C")]
    [Address(RVA = "0x41F2120", Offset = "0x41F2120", VA = "0x41F2120")]
    private string ConnectText(string text1, string text2) => (string) null;

    [Token(Token = "0x600803D")]
    [Address(RVA = "0x41F21BC", Offset = "0x41F21BC", VA = "0x41F21BC")]
    private bool IsTextNull(string text) => new bool();
  }
}
