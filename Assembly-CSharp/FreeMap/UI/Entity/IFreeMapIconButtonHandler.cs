// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.IFreeMapIconButtonHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x2001688")]
  public interface IFreeMapIconButtonHandler
  {
    [Token(Token = "0x6007F30")]
    bool IsHoldUIParam(FreeMapUIParamBase param);

    [Token(Token = "0x6007F31")]
    void InvokeButtonAction(FreeMapUIParamBase param);
  }
}
