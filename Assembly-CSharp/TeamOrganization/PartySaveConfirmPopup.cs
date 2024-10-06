// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySaveConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007EB")]
  public static class PartySaveConfirmPopup
  {
    [Token(Token = "0x6002D33")]
    [Address(RVA = "0x3A86388", Offset = "0x3A86388", VA = "0x3A86388")]
    public static IEnumerator RequestAsyncIfNeed(bool condition, Func<IEnumerator> saveCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002D34")]
    [Address(RVA = "0x3A8642C", Offset = "0x3A8642C", VA = "0x3A8642C")]
    public static IEnumerator RequestAsync(Func<IEnumerator> saveCallback) => (IEnumerator) null;

    [Token(Token = "0x6002D35")]
    [Address(RVA = "0x3A864BC", Offset = "0x3A864BC", VA = "0x3A864BC")]
    public static IEnumerator RequestForTransitionAsync(
      Action transitionCallback,
      Func<IEnumerator> saveCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002D36")]
    [Address(RVA = "0x3A86558", Offset = "0x3A86558", VA = "0x3A86558")]
    private static void NotifySave()
    {
    }

    [Token(Token = "0x6002D37")]
    [Address(RVA = "0x3A865EC", Offset = "0x3A865EC", VA = "0x3A865EC")]
    private static void NotifyNoNeedSave()
    {
    }
  }
}
