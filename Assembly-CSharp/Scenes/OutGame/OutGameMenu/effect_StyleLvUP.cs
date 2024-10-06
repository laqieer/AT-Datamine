// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.effect_StyleLvUP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A5E")]
  public class effect_StyleLvUP : MonoBehaviour
  {
    [Token(Token = "0x400FFDA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FFDB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FFDC")]
    private const string inoutTimeLineAssetbundleName = "content_effect_common_ui_effect_stylelvup_timeline";
    [Token(Token = "0x400FFDD")]
    private const string inoutTimeLineAssetName = "effect_StyleLvUP";
    [Token(Token = "0x400FFDE")]
    [FieldOffset(Offset = "0x28")]
    private bool isInDirection;
    [Token(Token = "0x400FFDF")]
    [FieldOffset(Offset = "0x30")]
    private Action directFinish;

    [Token(Token = "0x17004B34")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6016F17"), Address(RVA = "0x29C141C", Offset = "0x29C141C", VA = "0x29C141C")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x6016F18")]
    [Address(RVA = "0x29C1424", Offset = "0x29C1424", VA = "0x29C1424")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016F19")]
    [Address(RVA = "0x29C1428", Offset = "0x29C1428", VA = "0x29C1428")]
    public void StartEffect(Action finish)
    {
    }

    [Token(Token = "0x6016F1A")]
    [Address(RVA = "0x29C14F8", Offset = "0x29C14F8", VA = "0x29C14F8")]
    private IEnumerator WaitOutDirection() => (IEnumerator) null;

    [Token(Token = "0x6016F1B")]
    [Address(RVA = "0x29C1588", Offset = "0x29C1588", VA = "0x29C1588")]
    public effect_StyleLvUP()
    {
    }
  }
}
