// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.IFreeMapClipActionHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018BC")]
  public interface IFreeMapClipActionHandler
  {
    [Token(Token = "0x6008C73")]
    IEnumerator WaitCoroutine();

    [Token(Token = "0x1700168B")]
    bool IsFinish { [Token(Token = "0x6008C74")] get; }
  }
}
