// Decompiled with JetBrains decompiler
// Type: Battle.ISubDirector`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002270")]
  public interface ISubDirector<TDirector> where TDirector : IDirector
  {
    [Token(Token = "0x17002D81")]
    bool Initialized { [Token(Token = "0x600D18B")] get; }

    [Token(Token = "0x600D18C")]
    void Initialize(TDirector mainDirector);

    [Token(Token = "0x600D18D")]
    void Abort();

    [Token(Token = "0x600D18E")]
    void Release();
  }
}
