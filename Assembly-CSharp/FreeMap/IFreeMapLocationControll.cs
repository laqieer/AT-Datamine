// Decompiled with JetBrains decompiler
// Type: FreeMap.IFreeMapLocationControll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E7")]
  public interface IFreeMapLocationControll
  {
    [Token(Token = "0x6007BFA")]
    void RefreshInstance();

    [Token(Token = "0x6007BFB")]
    bool UIExists(FreeMapUIParamBase param);
  }
}
