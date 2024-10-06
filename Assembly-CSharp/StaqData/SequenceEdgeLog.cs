// Decompiled with JetBrains decompiler
// Type: StaqData.SequenceEdgeLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C8")]
  public class SequenceEdgeLog
  {
    [Token(Token = "0x17002A88")]
    public int FromSequenceID
    {
      [Token(Token = "0x600C695"), Address(RVA = "0x1CD8004", Offset = "0x1CD8004", VA = "0x1CD8004")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A89")]
    public int ToSequenceID
    {
      [Token(Token = "0x600C696"), Address(RVA = "0x1CD800C", Offset = "0x1CD800C", VA = "0x1CD800C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C697")]
    [Address(RVA = "0x1CD8014", Offset = "0x1CD8014", VA = "0x1CD8014")]
    public SequenceEdgeLog(int fromSequenceID, int toSequenceID)
    {
    }
  }
}
