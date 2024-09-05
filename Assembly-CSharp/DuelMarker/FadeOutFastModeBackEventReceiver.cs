// Decompiled with JetBrains decompiler
// Type: DuelMarker.FadeOutFastModeBackEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021E0")]
  public class FadeOutFastModeBackEventReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x4008F36")]
    [FieldOffset(Offset = "0x18")]
    public DuelManager duelManager;

    [Token(Token = "0x600CEAD")]
    [Address(RVA = "0x4B65894", Offset = "0x4B65894", VA = "0x4B65894", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x600CEAE")]
    [Address(RVA = "0x4B65974", Offset = "0x4B65974", VA = "0x4B65974")]
    public FadeOutFastModeBackEventReceiver()
    {
    }
  }
}
