// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.InOutFaderExtentions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C1")]
  public static class InOutFaderExtentions
  {
    [Token(Token = "0x6013DE0")]
    [Address(RVA = "0x1AE9400", Offset = "0x1AE9400", VA = "0x1AE9400")]
    public static IEnumerator OpenAndWait(this IInOutFader self, Action onFinish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013DE1")]
    [Address(RVA = "0x1AE955C", Offset = "0x1AE955C", VA = "0x1AE955C")]
    public static IEnumerator CloseAndWait(this IInOutFader self, Action onFinish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013DE2")]
    [Address(RVA = "0x1AE94E4", Offset = "0x1AE94E4", VA = "0x1AE94E4")]
    private static IEnumerator DecorateAndWait(Action<Action> action, Action onFinish = null)
    {
      return (IEnumerator) null;
    }
  }
}
