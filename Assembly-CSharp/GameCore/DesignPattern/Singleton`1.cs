// Decompiled with JetBrains decompiler
// Type: GameCore.DesignPattern.Singleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.DesignPattern
{
  [Token(Token = "0x20014D7")]
  public class Singleton<T> where T : class, new()
  {
    [Token(Token = "0x4005FE1")]
    [FieldOffset(Offset = "0x0")]
    protected static T instance;

    [Token(Token = "0x1700121B")]
    public static T Instance
    {
      [Token(Token = "0x600758C")] get => (T) null;
    }

    [Token(Token = "0x600758D")]
    public Singleton()
    {
    }
  }
}
