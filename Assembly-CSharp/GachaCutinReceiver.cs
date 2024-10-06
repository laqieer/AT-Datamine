// Decompiled with JetBrains decompiler
// Type: GachaCutinReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20001ED")]
public class GachaCutinReceiver : MonoBehaviour, INotificationReceiver
{
  [Token(Token = "0x4000B01")]
  [FieldOffset(Offset = "0x18")]
  public GachaManager gachaManager;

  [Token(Token = "0x6000C40")]
  [Address(RVA = "0x4C740C4", Offset = "0x4C740C4", VA = "0x4C740C4", Slot = "4")]
  public void OnNotify(Playable origin, INotification notification, object context)
  {
  }

  [Token(Token = "0x6000C41")]
  [Address(RVA = "0x4C743AC", Offset = "0x4C743AC", VA = "0x4C743AC")]
  public GachaCutinReceiver()
  {
  }
}
