// Decompiled with JetBrains decompiler
// Type: GameCore.MissionNotification.MissionNotificationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

#nullable disable
namespace GameCore.MissionNotification
{
  [Token(Token = "0x2000D2E")]
  public class MissionNotificationItem : MonoBehaviour
  {
    [Token(Token = "0x4003B01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI text;
    [Token(Token = "0x4003B02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Animator animator;
    [Token(Token = "0x4003B03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup stampTweenGroup;
    [Token(Token = "0x4003B04")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton commonButton;
    [Token(Token = "0x4003B05")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayableDirector playableDirector;

    [Token(Token = "0x17000B12")]
    public PlayableDirector PlayableDirector
    {
      [Token(Token = "0x6004BCF"), Address(RVA = "0x32E9050", Offset = "0x32E9050", VA = "0x32E9050")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x140000F5")]
    public event UnityAction OnClick
    {
      [Token(Token = "0x6004BD0"), Address(RVA = "0x32E9058", Offset = "0x32E9058", VA = "0x32E9058")] add
      {
      }
      [Token(Token = "0x6004BD1"), Address(RVA = "0x32E90F4", Offset = "0x32E90F4", VA = "0x32E90F4")] remove
      {
      }
    }

    [Token(Token = "0x6004BD2")]
    [Address(RVA = "0x32E9190", Offset = "0x32E9190", VA = "0x32E9190")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004BD3")]
    [Address(RVA = "0x32E9224", Offset = "0x32E9224", VA = "0x32E9224")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6004BD4")]
    [Address(RVA = "0x32E9248", Offset = "0x32E9248", VA = "0x32E9248")]
    public void Show()
    {
    }

    [Token(Token = "0x6004BD5")]
    [Address(RVA = "0x32E9264", Offset = "0x32E9264", VA = "0x32E9264")]
    public void Hide()
    {
    }

    [Token(Token = "0x6004BD6")]
    [Address(RVA = "0x32E9484", Offset = "0x32E9484", VA = "0x32E9484")]
    public void SetPlayableDirectorTime(float hideStartAnimTime)
    {
    }

    [Token(Token = "0x6004BD7")]
    [Address(RVA = "0x32E94A4", Offset = "0x32E94A4", VA = "0x32E94A4")]
    public bool IsHideAnimEnd() => new bool();

    [Token(Token = "0x6004BD8")]
    [Address(RVA = "0x32E94EC", Offset = "0x32E94EC", VA = "0x32E94EC")]
    public MissionNotificationItem()
    {
    }
  }
}
