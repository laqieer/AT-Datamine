// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.SwipeMoveTutorialUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200183B")]
  public class SwipeMoveTutorialUI
  {
    [Token(Token = "0x40069B5")]
    [FieldOffset(Offset = "0x10")]
    private GameObject uigo;
    [Token(Token = "0x40069B6")]
    [FieldOffset(Offset = "0x18")]
    private UITimelineController con;
    [Token(Token = "0x40069B7")]
    [FieldOffset(Offset = "0x20")]
    private float pastTime;
    [Token(Token = "0x40069B8")]
    [FieldOffset(Offset = "0x24")]
    private bool endreq;
    [Token(Token = "0x40069B9")]
    [FieldOffset(Offset = "0x28")]
    private float displayTimeSec;

    [Token(Token = "0x600890B")]
    [Address(RVA = "0x43E05E0", Offset = "0x43E05E0", VA = "0x43E05E0")]
    public SwipeMoveTutorialUI(float displayTimeSec)
    {
    }

    [Token(Token = "0x1700159D")]
    public bool IsDisplayEnded
    {
      [Token(Token = "0x600890C"), Address(RVA = "0x43E1B80", Offset = "0x43E1B80", VA = "0x43E1B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600890D"), Address(RVA = "0x43E1B88", Offset = "0x43E1B88", VA = "0x43E1B88")] private set
      {
      }
    }

    [Token(Token = "0x600890E")]
    [Address(RVA = "0x43E0610", Offset = "0x43E0610", VA = "0x43E0610")]
    public IEnumerator SetupUI(Transform panet) => (IEnumerator) null;

    [Token(Token = "0x600890F")]
    [Address(RVA = "0x43E0684", Offset = "0x43E0684", VA = "0x43E0684")]
    public void PlayShow()
    {
    }

    [Token(Token = "0x6008910")]
    [Address(RVA = "0x43DDB3C", Offset = "0x43DDB3C", VA = "0x43DDB3C")]
    public void Update()
    {
    }

    [Token(Token = "0x6008911")]
    [Address(RVA = "0x43E1BBC", Offset = "0x43E1BBC", VA = "0x43E1BBC")]
    private void UIHide()
    {
    }

    [Token(Token = "0x6008912")]
    [Address(RVA = "0x43E06A8", Offset = "0x43E06A8", VA = "0x43E06A8")]
    public void EndRequest()
    {
    }

    [Token(Token = "0x6008913")]
    [Address(RVA = "0x43DDAC4", Offset = "0x43DDAC4", VA = "0x43DDAC4")]
    public void Destoy()
    {
    }
  }
}
