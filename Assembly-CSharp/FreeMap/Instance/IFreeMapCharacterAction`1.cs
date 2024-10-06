// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.IFreeMapCharacterAction`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018BA")]
  public interface IFreeMapCharacterAction<TController> where TController : IFreeMapCharacterActionController
  {
    [Token(Token = "0x6008C6E")]
    void Enter(TController motion);

    [Token(Token = "0x6008C6F")]
    bool Execute(TController motion, float deltaTime);

    [Token(Token = "0x6008C70")]
    void Exit(TController motion);
  }
}
