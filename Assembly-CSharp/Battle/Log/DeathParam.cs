// Decompiled with JetBrains decompiler
// Type: Battle.Log.DeathParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002523")]
  public class DeathParam
  {
    [Token(Token = "0x17003145")]
    public CauseOfDeath Cause
    {
      [Token(Token = "0x600E56F"), Address(RVA = "0x4868EE4", Offset = "0x4868EE4", VA = "0x4868EE4")] get
      {
        return new CauseOfDeath();
      }
      [Token(Token = "0x600E570"), Address(RVA = "0x4868EEC", Offset = "0x4868EEC", VA = "0x4868EEC")] private set
      {
      }
    }

    [Token(Token = "0x17003146")]
    public int Count
    {
      [Token(Token = "0x600E571"), Address(RVA = "0x4868EF4", Offset = "0x4868EF4", VA = "0x4868EF4")] get
      {
        return new int();
      }
      [Token(Token = "0x600E572"), Address(RVA = "0x4868EFC", Offset = "0x4868EFC", VA = "0x4868EFC")] private set
      {
      }
    }

    [Token(Token = "0x600E573")]
    [Address(RVA = "0x4868B58", Offset = "0x4868B58", VA = "0x4868B58")]
    public DeathParam(CauseOfDeath cause, int count = 1)
    {
    }

    [Token(Token = "0x600E574")]
    [Address(RVA = "0x4868B48", Offset = "0x4868B48", VA = "0x4868B48")]
    public void AddDeathCount(int count)
    {
    }
  }
}
