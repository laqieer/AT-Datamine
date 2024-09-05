// Decompiled with JetBrains decompiler
// Type: Battle.Direction.Skill.AlignmentStratagemDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Utilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Battle.Direction.Skill
{
  [Token(Token = "0x20025C3")]
  public class AlignmentStratagemDirection : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x400A26E")]
    private const int MinimumParticipants = 2;
    [Token(Token = "0x400A26F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Range(2f, 4f)]
    [Tooltip("参加者の最大人数")]
    private int maximumParticipants;
    [Token(Token = "0x400A270")]
    [FieldOffset(Offset = "0x1C")]
    [Tooltip("演出終了時の待機時間")]
    [SerializeField]
    private float directionEndDelayTime;
    [Token(Token = "0x400A271")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("ダイシングのタグ名")]
    [SerializeField]
    private string dicingTagName;
    [Token(Token = "0x400A272")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("ダイシングの縦横どちらに合わせるか")]
    [SerializeField]
    private IllustLayoutComponent.MatchMode dicingMatchMode;
    [Token(Token = "0x400A273")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayableDirector director;
    [Token(Token = "0x400A274")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<AlignmentStratagemDirection.UnitContainerSchema> unitContainers;
    [Token(Token = "0x400A275")]
    [FieldOffset(Offset = "0x40")]
    private IReadOnlyList<(int supportPoint, string color, int styleId)> participants;
    [Token(Token = "0x400A276")]
    [FieldOffset(Offset = "0x48")]
    public UnityAction<PlayableDirector> SingleStratagemStartEvent;
    [Token(Token = "0x400A277")]
    [FieldOffset(Offset = "0x50")]
    private bool executedSingleStratagemStartEvent;

    [Token(Token = "0x170031C4")]
    public float DirectionEndDelayTime
    {
      [Token(Token = "0x600E923"), Address(RVA = "0x4C471EC", Offset = "0x4C471EC", VA = "0x4C471EC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170031C5")]
    public bool IsExecutedSingleStratagemStartEvent
    {
      [Token(Token = "0x600E924"), Address(RVA = "0x4C471F4", Offset = "0x4C471F4", VA = "0x4C471F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E925")]
    [Address(RVA = "0x4C36CD4", Offset = "0x4C36CD4", VA = "0x4C36CD4")]
    public IEnumerator Initialize(
      IReadOnlyList<(int supportPoint, string color, int styleId)> participants)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600E926")]
    [Address(RVA = "0x4C47224", Offset = "0x4C47224", VA = "0x4C47224", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600E927")]
    [Address(RVA = "0x4C473C0", Offset = "0x4C473C0", VA = "0x4C473C0")]
    public void Play(Action<PlayableDirector> stopCallbackEvent = null)
    {
    }

    [Token(Token = "0x600E928")]
    [Address(RVA = "0x4C47344", Offset = "0x4C47344", VA = "0x4C47344")]
    private int GetParticipantsCount(int value) => new int();

    [Token(Token = "0x600E929")]
    [Address(RVA = "0x4C47530", Offset = "0x4C47530", VA = "0x4C47530")]
    public void InvokeSingleStratagemDirectionEvent()
    {
    }

    [Token(Token = "0x600E92A")]
    [Address(RVA = "0x4C47558", Offset = "0x4C47558", VA = "0x4C47558")]
    public AlignmentStratagemDirection()
    {
    }

    [Token(Token = "0x20025C4")]
    [Serializable]
    public class UnitContainerSchema
    {
      [Token(Token = "0x400A278")]
      [FieldOffset(Offset = "0x10")]
      public Image baseImage;
      [Token(Token = "0x400A279")]
      [FieldOffset(Offset = "0x18")]
      public Image lineImage;
      [Token(Token = "0x400A27A")]
      [FieldOffset(Offset = "0x20")]
      public Transform faceTransform;
      [Token(Token = "0x400A27B")]
      [FieldOffset(Offset = "0x28")]
      public ImageAdjustController imageAdjustController;

      [Token(Token = "0x600E92B")]
      [Address(RVA = "0x4C475B4", Offset = "0x4C475B4", VA = "0x4C475B4")]
      public UnitContainerSchema()
      {
      }
    }
  }
}
