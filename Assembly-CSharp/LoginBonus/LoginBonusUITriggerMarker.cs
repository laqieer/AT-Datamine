// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusUITriggerMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AAF")]
  public class LoginBonusUITriggerMarker : Marker, INotification, INotificationOptionProvider
  {
    [Token(Token = "0x170008BA")]
    public PropertyName id
    {
      [Token(Token = "0x6003CCD"), Address(RVA = "0x2C06848", Offset = "0x2C06848", VA = "0x2C06848", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x170008BB")]
    public NotificationFlags flags
    {
      [Token(Token = "0x6003CCE"), Address(RVA = "0x2C06850", Offset = "0x2C06850", VA = "0x2C06850", Slot = "10")] get
      {
        return new NotificationFlags();
      }
    }

    [Token(Token = "0x6003CCF")]
    [Address(RVA = "0x2C06858", Offset = "0x2C06858", VA = "0x2C06858")]
    public LoginBonusUITriggerMarker()
    {
    }
  }
}
