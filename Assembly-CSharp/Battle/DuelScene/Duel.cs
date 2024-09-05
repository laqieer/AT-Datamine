// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.Duel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x200254C")]
  public class Duel
  {
    [Token(Token = "0x400A077")]
    [FieldOffset(Offset = "0x10")]
    private Queue<IDuelAction> actions;

    [Token(Token = "0x600E63A")]
    [Address(RVA = "0x486DC34", Offset = "0x486DC34", VA = "0x486DC34")]
    public static Duel Create(DuelData data, IDirector mainDirector, bool simple) => (Duel) null;

    [Token(Token = "0x600E63B")]
    [Address(RVA = "0x486DD5C", Offset = "0x486DD5C", VA = "0x486DD5C")]
    public static Duel Create(Queue<IDuelAction> actions) => (Duel) null;

    [Token(Token = "0x600E63C")]
    [Address(RVA = "0x486DCCC", Offset = "0x486DCCC", VA = "0x486DCCC")]
    protected Duel(Queue<IDuelAction> actions)
    {
    }

    [Token(Token = "0x600E63D")]
    [Address(RVA = "0x486DDBC", Offset = "0x486DDBC", VA = "0x486DDBC")]
    protected Duel()
    {
    }

    [Token(Token = "0x600E63E")]
    [Address(RVA = "0x486DE38", Offset = "0x486DE38", VA = "0x486DE38")]
    public void RequestStaging()
    {
    }
  }
}
