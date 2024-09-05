// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionLineRewardEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A0C")]
  public class PanelMissionLineRewardEffect : MonoBehaviour
  {
    [Token(Token = "0x4002E7F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController side1;
    [Token(Token = "0x4002E80")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController side2;
    [Token(Token = "0x4002E81")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController side3;
    [Token(Token = "0x4002E82")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController vertical1;
    [Token(Token = "0x4002E83")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITimelineController vertical2;
    [Token(Token = "0x4002E84")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITimelineController vertical3;
    [Token(Token = "0x4002E85")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITimelineController slant1;
    [Token(Token = "0x4002E86")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UITimelineController slant2;
    [Token(Token = "0x4002E87")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayableDirector> playableDirectors;

    [Token(Token = "0x600393F")]
    [Address(RVA = "0x310FACC", Offset = "0x310FACC", VA = "0x310FACC")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003940")]
    [Address(RVA = "0x310ED10", Offset = "0x310ED10", VA = "0x310ED10")]
    public void PlayLineEffect(
      PanelMissionLineRewardEffect.LineEffectId lineEffectId,
      UITimelineController.DirectionType directionType)
    {
    }

    [Token(Token = "0x6003941")]
    [Address(RVA = "0x3111A3C", Offset = "0x3111A3C", VA = "0x3111A3C")]
    public IEnumerator WaitAllAnimationEnd() => (IEnumerator) null;

    [Token(Token = "0x6003942")]
    [Address(RVA = "0x3113090", Offset = "0x3113090", VA = "0x3113090")]
    public PanelMissionLineRewardEffect()
    {
    }

    [Token(Token = "0x2000A0D")]
    public enum LineEffectId
    {
      [Token(Token = "0x4002E89")] Side1,
      [Token(Token = "0x4002E8A")] Side2,
      [Token(Token = "0x4002E8B")] Side3,
      [Token(Token = "0x4002E8C")] Vertical1,
      [Token(Token = "0x4002E8D")] Vertical2,
      [Token(Token = "0x4002E8E")] Vertical3,
      [Token(Token = "0x4002E8F")] Slant1,
      [Token(Token = "0x4002E90")] Slant2,
    }
  }
}
