// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.effect_StyleReincarnation
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
  [Token(Token = "0x2003A60")]
  public class effect_StyleReincarnation : MonoBehaviour
  {
    [Token(Token = "0x400FFE3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FFE4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FFE5")]
    private const string inoutTimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x400FFE6")]
    private const string inoutTimeLineAssetName = "effect_StyleReincarnation";
    [Token(Token = "0x400FFE7")]
    [FieldOffset(Offset = "0x28")]
    private bool isInDirection;
    [Token(Token = "0x400FFE8")]
    [FieldOffset(Offset = "0x30")]
    private Action directFinish;

    [Token(Token = "0x17004B37")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6016F27"), Address(RVA = "0x29C1968", Offset = "0x29C1968", VA = "0x29C1968")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x6016F28")]
    [Address(RVA = "0x29C1970", Offset = "0x29C1970", VA = "0x29C1970")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016F29")]
    [Address(RVA = "0x29C1990", Offset = "0x29C1990", VA = "0x29C1990")]
    private IEnumerator loadEffectAB() => (IEnumerator) null;

    [Token(Token = "0x6016F2A")]
    [Address(RVA = "0x29C1A18", Offset = "0x29C1A18", VA = "0x29C1A18")]
    public void StartEffect(Action finish)
    {
    }

    [Token(Token = "0x6016F2B")]
    [Address(RVA = "0x29C1BA8", Offset = "0x29C1BA8", VA = "0x29C1BA8")]
    private IEnumerator WaitOutDirection() => (IEnumerator) null;

    [Token(Token = "0x6016F2C")]
    [Address(RVA = "0x29C1C38", Offset = "0x29C1C38", VA = "0x29C1C38")]
    public effect_StyleReincarnation()
    {
    }
  }
}
