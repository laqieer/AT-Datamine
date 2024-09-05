// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapNotifyHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Story.FreeAction.Notify;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017CD")]
  public static class FreeMapNotifyHelper
  {
    [Token(Token = "0x60086D5")]
    [Address(RVA = "0x43D1EC0", Offset = "0x43D1EC0", VA = "0x43D1EC0")]
    public static void UnlockNewCommunicatoin(
      this List<Element> elements,
      IEnumerable<FreeMapCommunicationEventUIParam> commuParams)
    {
    }

    [Token(Token = "0x60086D6")]
    [Address(RVA = "0x43D270C", Offset = "0x43D270C", VA = "0x43D270C")]
    public static void UnlockNewGacha(this List<Element> elements)
    {
    }
  }
}
