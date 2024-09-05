// Decompiled with JetBrains decompiler
// Type: Battle.Log.DealBadStatusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002525")]
  public class DealBadStatusParam
  {
    [Token(Token = "0x1700314C")]
    public int Id
    {
      [Token(Token = "0x600E581"), Address(RVA = "0x4868F58", Offset = "0x4868F58", VA = "0x4868F58")] get
      {
        return new int();
      }
      [Token(Token = "0x600E582"), Address(RVA = "0x4868F60", Offset = "0x4868F60", VA = "0x4868F60")] private set
      {
      }
    }

    [Token(Token = "0x1700314D")]
    public int Count
    {
      [Token(Token = "0x600E583"), Address(RVA = "0x4868F68", Offset = "0x4868F68", VA = "0x4868F68")] get
      {
        return new int();
      }
      [Token(Token = "0x600E584"), Address(RVA = "0x4868F70", Offset = "0x4868F70", VA = "0x4868F70")] private set
      {
      }
    }

    [Token(Token = "0x600E585")]
    [Address(RVA = "0x4868F78", Offset = "0x4868F78", VA = "0x4868F78")]
    public DealBadStatusParam(int id, int count = 1)
    {
    }

    [Token(Token = "0x600E586")]
    [Address(RVA = "0x4868D4C", Offset = "0x4868D4C", VA = "0x4868D4C")]
    public void AddDealCount(int count)
    {
    }
  }
}
