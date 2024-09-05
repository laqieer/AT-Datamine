// Decompiled with JetBrains decompiler
// Type: Battle.Grid.PredictionMoveParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200253B")]
  public class PredictionMoveParameter
  {
    [Token(Token = "0x17003168")]
    public PredictionMoveViewType ViewType
    {
      [Token(Token = "0x600E601"), Address(RVA = "0x486BBF8", Offset = "0x486BBF8", VA = "0x486BBF8")] get
      {
        return new PredictionMoveViewType();
      }
      [Token(Token = "0x600E602"), Address(RVA = "0x486BC00", Offset = "0x486BC00", VA = "0x486BC00")] set
      {
      }
    }

    [Token(Token = "0x17003169")]
    public AdjoiningDirection Direction
    {
      [Token(Token = "0x600E603"), Address(RVA = "0x486BC08", Offset = "0x486BC08", VA = "0x486BC08")] get
      {
        return new AdjoiningDirection();
      }
      [Token(Token = "0x600E604"), Address(RVA = "0x486BC10", Offset = "0x486BC10", VA = "0x486BC10")] set
      {
      }
    }

    [Token(Token = "0x600E605")]
    [Address(RVA = "0x486B3F4", Offset = "0x486B3F4", VA = "0x486B3F4")]
    public PredictionMoveParameter()
    {
    }
  }
}
