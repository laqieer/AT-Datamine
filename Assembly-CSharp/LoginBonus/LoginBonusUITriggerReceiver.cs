// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusUITriggerReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AB0")]
  public class LoginBonusUITriggerReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x4003126")]
    [FieldOffset(Offset = "0x18")]
    public LoginBonusManager loginBonusManager;

    [Token(Token = "0x6003CD0")]
    [Address(RVA = "0x2C06860", Offset = "0x2C06860", VA = "0x2C06860", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x6003CD1")]
    [Address(RVA = "0x2C0693C", Offset = "0x2C0693C", VA = "0x2C0693C")]
    public LoginBonusUITriggerReceiver()
    {
    }
  }
}
