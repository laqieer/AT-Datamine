// Decompiled with JetBrains decompiler
// Type: DuelMarker.TakeScreenShotEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021EB")]
  public class TakeScreenShotEventReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x4008F47")]
    [FieldOffset(Offset = "0x18")]
    public DuelManager duelManager;

    [Token(Token = "0x600CEC2")]
    [Address(RVA = "0x4B65B30", Offset = "0x4B65B30", VA = "0x4B65B30", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x600CEC3")]
    [Address(RVA = "0x4B65C10", Offset = "0x4B65C10", VA = "0x4B65C10")]
    public TakeScreenShotEventReceiver()
    {
    }
  }
}
