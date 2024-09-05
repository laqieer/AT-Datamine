// Decompiled with JetBrains decompiler
// Type: UpdateCharacterStatusEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20001BD")]
public class UpdateCharacterStatusEventReceiver : MonoBehaviour, INotificationReceiver
{
  [Token(Token = "0x4000AA6")]
  [FieldOffset(Offset = "0x18")]
  public DuelManager duelManager;

  [Token(Token = "0x6000B77")]
  [Address(RVA = "0x4BC97E0", Offset = "0x4BC97E0", VA = "0x4BC97E0", Slot = "4")]
  public void OnNotify(Playable origin, INotification notification, object context)
  {
  }

  [Token(Token = "0x6000B78")]
  [Address(RVA = "0x4BC98B4", Offset = "0x4BC98B4", VA = "0x4BC98B4")]
  public UpdateCharacterStatusEventReceiver()
  {
  }
}
