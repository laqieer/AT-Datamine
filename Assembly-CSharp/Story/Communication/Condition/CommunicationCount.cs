// Decompiled with JetBrains decompiler
// Type: Story.Communication.Condition.CommunicationCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Communication.Condition
{
  [Token(Token = "0x20006B6")]
  public struct CommunicationCount : IRangeCondition
  {
    [Token(Token = "0x17000597")]
    public int Min
    {
      [Token(Token = "0x6002604"), Address(RVA = "0x2F3FCC4", Offset = "0x2F3FCC4", VA = "0x2F3FCC4", Slot = "4")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6002605"), Address(RVA = "0x2F3FCCC", Offset = "0x2F3FCCC", VA = "0x2F3FCCC")] private set
      {
      }
    }

    [Token(Token = "0x17000598")]
    public int Max
    {
      [Token(Token = "0x6002606"), Address(RVA = "0x2F3FCD4", Offset = "0x2F3FCD4", VA = "0x2F3FCD4", Slot = "5")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6002607"), Address(RVA = "0x2F3FCDC", Offset = "0x2F3FCDC", VA = "0x2F3FCDC")] private set
      {
      }
    }

    [Token(Token = "0x17000599")]
    public bool IsDefault
    {
      [Token(Token = "0x6002608"), Address(RVA = "0x2F3FCE4", Offset = "0x2F3FCE4", VA = "0x2F3FCE4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002609")]
    [Address(RVA = "0x2F3FCF8", Offset = "0x2F3FCF8", VA = "0x2F3FCF8")]
    public CommunicationCount(int min, int max)
    {
    }
  }
}
