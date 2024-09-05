// Decompiled with JetBrains decompiler
// Type: Home.V2.LoginBonus.LoginBonusVoiceTriggerReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LoginBonus;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Home.V2.LoginBonus
{
  [Token(Token = "0x2000B5E")]
  public class LoginBonusVoiceTriggerReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x40033F0")]
    [FieldOffset(Offset = "0x18")]
    public LoginBonusManager loginBonusManager;

    [Token(Token = "0x60040C8")]
    [Address(RVA = "0x2A29A70", Offset = "0x2A29A70", VA = "0x2A29A70", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x60040C9")]
    [Address(RVA = "0x2A29B4C", Offset = "0x2A29B4C", VA = "0x2A29B4C")]
    public LoginBonusVoiceTriggerReceiver()
    {
    }
  }
}
