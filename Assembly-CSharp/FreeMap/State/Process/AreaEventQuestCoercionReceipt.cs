// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaEventQuestCoercionReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017A4")]
  public class AreaEventQuestCoercionReceipt : FreeMapProcess
  {
    [Token(Token = "0x1700154D")]
    private Transform notifyRoot
    {
      [Token(Token = "0x600862A"), Address(RVA = "0x406F784", Offset = "0x406F784", VA = "0x406F784")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600862B")]
    [Address(RVA = "0x406F80C", Offset = "0x406F80C", VA = "0x406F80C")]
    public AreaEventQuestCoercionReceipt(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600862C")]
    [Address(RVA = "0x406F814", Offset = "0x406F814", VA = "0x406F814", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600862D")]
    [Address(RVA = "0x406F950", Offset = "0x406F950", VA = "0x406F950")]
    private IEnumerator OnFinished(APIStoryAreaEventQuestReceiptResponse response)
    {
      return (IEnumerator) null;
    }
  }
}
