// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleOpMovieDownloadPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028F2")]
  public class TitleOpMovieDownloadPopup : MonoBehaviour
  {
    [Token(Token = "0x400AEA8")]
    private const string TITLEMENU_TWEEN_IN = "in";
    [Token(Token = "0x400AEA9")]
    private const string TITLEMENU_TWEEN_OUT = "out";
    [Token(Token = "0x400AEAA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;

    [Token(Token = "0x1700387A")]
    public Action OnClickToConfirmAction
    {
      [Token(Token = "0x60101BB"), Address(RVA = "0x41727B8", Offset = "0x41727B8", VA = "0x41727B8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60101BC"), Address(RVA = "0x41727C0", Offset = "0x41727C0", VA = "0x41727C0")] set
      {
      }
    }

    [Token(Token = "0x1700387B")]
    public Action OnClickToSkippAction
    {
      [Token(Token = "0x60101BD"), Address(RVA = "0x41727C8", Offset = "0x41727C8", VA = "0x41727C8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60101BE"), Address(RVA = "0x41727D0", Offset = "0x41727D0", VA = "0x41727D0")] set
      {
      }
    }

    [Token(Token = "0x60101BF")]
    [Address(RVA = "0x41727D8", Offset = "0x41727D8", VA = "0x41727D8")]
    public void Show()
    {
    }

    [Token(Token = "0x60101C0")]
    [Address(RVA = "0x41728AC", Offset = "0x41728AC", VA = "0x41728AC")]
    private void FinishedInAnime()
    {
    }

    [Token(Token = "0x60101C1")]
    [Address(RVA = "0x4172938", Offset = "0x4172938", VA = "0x4172938")]
    public void Close()
    {
    }

    [Token(Token = "0x60101C2")]
    [Address(RVA = "0x41729F0", Offset = "0x41729F0", VA = "0x41729F0")]
    private void FinishedOutAnime()
    {
    }

    [Token(Token = "0x60101C3")]
    [Address(RVA = "0x4172A98", Offset = "0x4172A98", VA = "0x4172A98")]
    public void OnConfirmButton()
    {
    }

    [Token(Token = "0x60101C4")]
    [Address(RVA = "0x4172AB4", Offset = "0x4172AB4", VA = "0x4172AB4")]
    public void OnSkippButton()
    {
    }

    [Token(Token = "0x60101C5")]
    [Address(RVA = "0x4172AD0", Offset = "0x4172AD0", VA = "0x4172AD0")]
    public TitleOpMovieDownloadPopup()
    {
    }
  }
}
