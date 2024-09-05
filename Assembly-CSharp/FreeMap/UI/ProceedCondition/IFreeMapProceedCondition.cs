// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ProceedCondition.IFreeMapProceedCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ProceedCondition
{
  [Token(Token = "0x200161D")]
  public interface IFreeMapProceedCondition
  {
    [Token(Token = "0x6007D49")]
    bool CanProceed();

    [Token(Token = "0x6007D4A")]
    bool CanProceed(out IFreeMapCannotProceedReason detail);
  }
}
