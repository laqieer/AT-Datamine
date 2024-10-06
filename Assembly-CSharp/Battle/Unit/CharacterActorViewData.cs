// Decompiled with JetBrains decompiler
// Type: Battle.Unit.CharacterActorViewData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E4")]
  public class CharacterActorViewData : IActorViewData
  {
    [Token(Token = "0x4009395")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, ActorBadStatusViewData> badStatusSettings;

    [Token(Token = "0x600D54F")]
    [Address(RVA = "0x1D14000", Offset = "0x1D14000", VA = "0x1D14000", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D550")]
    [Address(RVA = "0x1D14284", Offset = "0x1D14284", VA = "0x1D14284", Slot = "5")]
    public ActorViewDataBase Get(object type) => (ActorViewDataBase) null;

    [Token(Token = "0x600D551")]
    [Address(RVA = "0x1D14004", Offset = "0x1D14004", VA = "0x1D14004")]
    private void CreateBadStatuses()
    {
    }

    [Token(Token = "0x600D552")]
    [Address(RVA = "0x1D14364", Offset = "0x1D14364", VA = "0x1D14364")]
    public CharacterActorViewData()
    {
    }
  }
}
