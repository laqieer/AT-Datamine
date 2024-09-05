// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryTimeLineFacade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003802")]
  public class ArmouryTimeLineFacade
  {
    [Token(Token = "0x400F4AD")]
    [FieldOffset(Offset = "0x10")]
    private UITimelineController _timeline;
    [Token(Token = "0x400F4AE")]
    [FieldOffset(Offset = "0x18")]
    private bool isEnd;

    [Token(Token = "0x60160A5")]
    [Address(RVA = "0x20ED750", Offset = "0x20ED750", VA = "0x20ED750")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x60160A6")]
    [Address(RVA = "0x20EBAD8", Offset = "0x20EBAD8", VA = "0x20EBAD8")]
    public ArmouryTimeLineFacade(UITimelineController timeline)
    {
    }

    [Token(Token = "0x60160A7")]
    [Address(RVA = "0x20EACE4", Offset = "0x20EACE4", VA = "0x20EACE4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60160A8")]
    [Address(RVA = "0x20EBB00", Offset = "0x20EBB00", VA = "0x20EBB00")]
    protected void Play(ArmouryTimeLineFacade.Direction direction, UnityAction callback)
    {
    }

    [Token(Token = "0x60160A9")]
    [Address(RVA = "0x20ED780", Offset = "0x20ED780", VA = "0x20ED780")]
    public void Play(
      string keyword,
      UITimelineController.DirectionType direction,
      UnityAction callback)
    {
    }

    [Token(Token = "0x60160AA")]
    [Address(RVA = "0x20EA780", Offset = "0x20EA780", VA = "0x20EA780")]
    public void SetLastFrame()
    {
    }

    [Token(Token = "0x2003803")]
    public struct Direction
    {
      [Token(Token = "0x400F4AF")]
      [FieldOffset(Offset = "0x0")]
      public string Keyword;
      [Token(Token = "0x400F4B0")]
      [FieldOffset(Offset = "0x8")]
      public UITimelineController.DirectionType Type;
    }
  }
}
