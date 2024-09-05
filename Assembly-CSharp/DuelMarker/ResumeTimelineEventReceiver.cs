// Decompiled with JetBrains decompiler
// Type: DuelMarker.ResumeTimelineEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021E4")]
  public class ResumeTimelineEventReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x4008F38")]
    [FieldOffset(Offset = "0x18")]
    public DuelManager duelManager;

    [Token(Token = "0x600CEB3")]
    [Address(RVA = "0x4B6599C", Offset = "0x4B6599C", VA = "0x4B6599C", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x600CEB4")]
    [Address(RVA = "0x4B65A7C", Offset = "0x4B65A7C", VA = "0x4B65A7C")]
    public ResumeTimelineEventReceiver()
    {
    }
  }
}
