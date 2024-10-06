// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Manager.IFreeMapRegistUI`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Entity;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Manager
{
  [Token(Token = "0x2001682")]
  public interface IFreeMapRegistUI<T> where T : FreeMapUIBase
  {
    [Token(Token = "0x6007F04")]
    void AddDrawUI(T target);
  }
}
