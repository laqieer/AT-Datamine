// Decompiled with JetBrains decompiler
// Type: StaqDebug.HTMLLogStrage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F65")]
  public class HTMLLogStrage : SingletonMonoBehaviour<HTMLLogStrage>
  {
    [Token(Token = "0x4008679")]
    private const string fileName = "response.html";

    [Token(Token = "0x170026AF")]
    public string FileName
    {
      [Token(Token = "0x600BA60"), Address(RVA = "0x1E450A4", Offset = "0x1E450A4", VA = "0x1E450A4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170026B0")]
    public string ResponceBody
    {
      [Token(Token = "0x600BA61"), Address(RVA = "0x1E450E4", Offset = "0x1E450E4", VA = "0x1E450E4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BA62"), Address(RVA = "0x1E450EC", Offset = "0x1E450EC", VA = "0x1E450EC")] set
      {
      }
    }

    [Token(Token = "0x600BA63")]
    [Address(RVA = "0x1E450F4", Offset = "0x1E450F4", VA = "0x1E450F4")]
    public HTMLLogStrage()
    {
    }
  }
}
