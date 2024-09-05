// Decompiled with JetBrains decompiler
// Type: CommonOptionScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200029A")]
public class CommonOptionScene : PopupBase
{
  [Token(Token = "0x4000F4D")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private CanvasGroup canvasGroup;
  [Token(Token = "0x4000F4E")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private UITweenGroup tweenGroup;
  [Token(Token = "0x4000F4F")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private CommonOptionChat commonOptionChat;
  [Token(Token = "0x4000F50")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Toggle[] toggleBtn;
  [Token(Token = "0x4000F51")]
  private const string AnimationKeyIn = "Open";
  [Token(Token = "0x4000F52")]
  private const string AnimationKeyOut = "Close";

  [Token(Token = "0x17000176")]
  private static string OpenTweenName
  {
    [Token(Token = "0x600101D"), Address(RVA = "0x1BE58C8", Offset = "0x1BE58C8", VA = "0x1BE58C8")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000177")]
  private static string CloseTweenName
  {
    [Token(Token = "0x600101E"), Address(RVA = "0x1BE5908", Offset = "0x1BE5908", VA = "0x1BE5908")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000178")]
  private static string OpenBattleName
  {
    [Token(Token = "0x600101F"), Address(RVA = "0x1BE5948", Offset = "0x1BE5948", VA = "0x1BE5948")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000179")]
  private static string OpenSoundName
  {
    [Token(Token = "0x6001020"), Address(RVA = "0x1BE5988", Offset = "0x1BE5988", VA = "0x1BE5988")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700017A")]
  private static string OpenQualityName
  {
    [Token(Token = "0x6001021"), Address(RVA = "0x1BE59C8", Offset = "0x1BE59C8", VA = "0x1BE59C8")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700017B")]
  private static string OpenDownloadName
  {
    [Token(Token = "0x6001022"), Address(RVA = "0x1BE5A08", Offset = "0x1BE5A08", VA = "0x1BE5A08")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700017C")]
  private static string OpenChatName
  {
    [Token(Token = "0x6001023"), Address(RVA = "0x1BE5A48", Offset = "0x1BE5A48", VA = "0x1BE5A48")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700017D")]
  private static string OpenNoticeName
  {
    [Token(Token = "0x6001024"), Address(RVA = "0x1BE5A88", Offset = "0x1BE5A88", VA = "0x1BE5A88")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6001025")]
  [Address(RVA = "0x1BE5AC8", Offset = "0x1BE5AC8", VA = "0x1BE5AC8")]
  private void Awake()
  {
  }

  [Token(Token = "0x6001026")]
  [Address(RVA = "0x1BE5590", Offset = "0x1BE5590", VA = "0x1BE5590")]
  public void ChangePage(CommonOptionScene.PAGETYPE pageType)
  {
  }

  [Token(Token = "0x6001027")]
  [Address(RVA = "0x1BE5818", Offset = "0x1BE5818", VA = "0x1BE5818")]
  public void SetChatOptionCallBack(Action callback)
  {
  }

  [Token(Token = "0x6001028")]
  [Address(RVA = "0x1BE5ACC", Offset = "0x1BE5ACC", VA = "0x1BE5ACC")]
  private void SetInteractable(bool value)
  {
  }

  [Token(Token = "0x6001029")]
  [Address(RVA = "0x1BE5B64", Offset = "0x1BE5B64", VA = "0x1BE5B64")]
  public new void DisableInteractable()
  {
  }

  [Token(Token = "0x600102A")]
  [Address(RVA = "0x1BE5B6C", Offset = "0x1BE5B6C", VA = "0x1BE5B6C")]
  public new void EnableInteractable()
  {
  }

  [Token(Token = "0x600102B")]
  [Address(RVA = "0x1BE5B74", Offset = "0x1BE5B74", VA = "0x1BE5B74", Slot = "5")]
  public override void OnClickClose()
  {
  }

  [Token(Token = "0x600102C")]
  [Address(RVA = "0x1BE5C2C", Offset = "0x1BE5C2C", VA = "0x1BE5C2C")]
  public void OnClickToggleBtn()
  {
  }

  [Token(Token = "0x600102D")]
  [Address(RVA = "0x1BE5C90", Offset = "0x1BE5C90", VA = "0x1BE5C90")]
  public CommonOptionScene()
  {
  }

  [Token(Token = "0x200029B")]
  public enum PAGETYPE
  {
    [Token(Token = "0x4000F54")] BATTLE,
    [Token(Token = "0x4000F55")] SOUND,
    [Token(Token = "0x4000F56")] RENDERING,
    [Token(Token = "0x4000F57")] CHAT,
    [Token(Token = "0x4000F58")] DOWNLOAD,
    [Token(Token = "0x4000F59")] MESSAGE,
  }
}
