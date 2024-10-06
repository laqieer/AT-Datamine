// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.DuelFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x200254E")]
  public static class DuelFactory
  {
    [Token(Token = "0x600E641")]
    [Address(RVA = "0x486DCC0", Offset = "0x486DCC0", VA = "0x486DCC0")]
    public static Queue<IDuelAction> Create(DuelData duelData, IDirector mainDirector, bool simple)
    {
      return (Queue<IDuelAction>) null;
    }

    [Token(Token = "0x600E642")]
    [Address(RVA = "0x486E1F0", Offset = "0x486E1F0", VA = "0x486E1F0")]
    private static Queue<IDuelAction> CreateSimpleActions(DuelData duelData, IDirector mainDirector)
    {
      return (Queue<IDuelAction>) null;
    }

    [Token(Token = "0x600E643")]
    [Address(RVA = "0x486E774", Offset = "0x486E774", VA = "0x486E774")]
    private static Queue<IDuelAction> CreateFullActions(DuelData duelData, IDirector mainDirector)
    {
      return (Queue<IDuelAction>) null;
    }
  }
}
