// Decompiled with JetBrains decompiler
// Type: Battle.Unit.IActorViewData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E9")]
  public interface IActorViewData
  {
    [Token(Token = "0x600D57F")]
    void Initialize();

    [Token(Token = "0x600D580")]
    ActorViewDataBase Get(object enumType);
  }
}
