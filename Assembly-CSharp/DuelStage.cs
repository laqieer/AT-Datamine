// Decompiled with JetBrains decompiler
// Type: DuelStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.DuelScene;
using GameCore.Sound;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200016A")]
public sealed class DuelStage : MonoBehaviour
{
  [Token(Token = "0x4000913")]
  [FieldOffset(Offset = "0x0")]
  private static DuelStage m_Instance;
  [Token(Token = "0x4000914")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Transform duelMapRoot;
  [Token(Token = "0x4000915")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Transform duelUnitRoot;
  [Token(Token = "0x4000916")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Transform duelUIRoot;
  [Token(Token = "0x4000917")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Transform duelCameraRoot;
  [Token(Token = "0x4000918")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Camera battleFieldCamera;
  [Token(Token = "0x4000919")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private Camera battleFieldUICamera;
  [Token(Token = "0x400091A")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private DuelManager duelManager;
  [Token(Token = "0x400091B")]
  [FieldOffset(Offset = "0x50")]
  public DuelStage.DuelStageStatus duelStageStatus;
  [Token(Token = "0x400091C")]
  private const string TRACK_NAME_ALLY_ANIMATION = "Ally_Anim_Track";
  [Token(Token = "0x400091D")]
  private const string TRACK_NAME_ENEMY_ANIMATION = "Enemy_Anim_Track";
  [Token(Token = "0x400091E")]
  [FieldOffset(Offset = "0x54")]
  private bool isAllyType;
  [Token(Token = "0x400091F")]
  [FieldOffset(Offset = "0x55")]
  private bool fastMode;
  [Token(Token = "0x4000920")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Camera transitionCamera;
  [Token(Token = "0x4000921")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private PlayableDirector transitionDirector;
  [Token(Token = "0x4000922")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private DuelAndBattleFieldTransitionRawImageController duelAndFieldTransitionRawImageController;
  [Token(Token = "0x4000923")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private TimelineAsset fieldToDuelTransitionTimeline;
  [Token(Token = "0x4000924")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private TimelineAsset duelToFieldTransitionTimeline;
  [Token(Token = "0x4000925")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private TimelineAsset fieldToStratagemTransitionTimeline;
  [Token(Token = "0x4000926")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private TimelineAsset stratagemToFieldTransitionTimeline;
  [Token(Token = "0x4000927")]
  [FieldOffset(Offset = "0x90")]
  private RenderTexture fullScreenMaskRT;
  [Token(Token = "0x4000928")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Volume fullScreenEffectvolume;
  [Token(Token = "0x4000929")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private GridFadeRawImage fullScreenMaskImage;
  [Token(Token = "0x400092A")]
  [FieldOffset(Offset = "0xA8")]
  private SoundManager soundmanager;

  [Token(Token = "0x170000AD")]
  public static DuelStage Instance
  {
    [Token(Token = "0x60009E1"), Address(RVA = "0x4776194", Offset = "0x4776194", VA = "0x4776194")] get
    {
      return (DuelStage) null;
    }
  }

  [Token(Token = "0x60009E2")]
  [Address(RVA = "0x47761DC", Offset = "0x47761DC", VA = "0x47761DC")]
  private void Awake()
  {
  }

  [Token(Token = "0x60009E3")]
  [Address(RVA = "0x4776274", Offset = "0x4776274", VA = "0x4776274")]
  private void Start()
  {
  }

  [Token(Token = "0x60009E4")]
  [Address(RVA = "0x4776328", Offset = "0x4776328", VA = "0x4776328")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009E5")]
  [Address(RVA = "0x4776384", Offset = "0x4776384", VA = "0x4776384")]
  public void PlayFullAnimation(DuelData data, bool fastMode)
  {
  }

  [Token(Token = "0x60009E6")]
  [Address(RVA = "0x47766F0", Offset = "0x47766F0", VA = "0x47766F0")]
  private IEnumerator PlayDuelAnimationCoroutine(
    DuelData data,
    DuelManager.DuelProcessType duelProcessType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60009E7")]
  [Address(RVA = "0x477676C", Offset = "0x477676C", VA = "0x477676C")]
  private IEnumerator PrepareDuelCoroutine(
    DuelData data,
    DuelManager.DuelProcessType duelProcessType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60009E8")]
  [Address(RVA = "0x47767E8", Offset = "0x47767E8", VA = "0x47767E8")]
  private void SetTrackByForceType(TimelineAsset timelineAsset, bool isAlly)
  {
  }

  [Token(Token = "0x60009E9")]
  [Address(RVA = "0x4776B68", Offset = "0x4776B68", VA = "0x4776B68")]
  private IEnumerator PlayDuelCoroutine() => (IEnumerator) null;

  [Token(Token = "0x60009EA")]
  [Address(RVA = "0x4776BD0", Offset = "0x4776BD0", VA = "0x4776BD0")]
  private IEnumerator AfterDuelCoroutine(DuelManager.DuelProcessType duelProcessType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60009EB")]
  [Address(RVA = "0x4776C48", Offset = "0x4776C48", VA = "0x4776C48")]
  private void SetDuelGameObjectsAndComponentsActive(bool isActive)
  {
  }

  [Token(Token = "0x60009EC")]
  [Address(RVA = "0x4776CC4", Offset = "0x4776CC4", VA = "0x4776CC4")]
  private IEnumerator TakeScreenShotBeforeTransitionCameraRendering() => (IEnumerator) null;

  [Token(Token = "0x60009ED")]
  [Address(RVA = "0x4776D2C", Offset = "0x4776D2C", VA = "0x4776D2C")]
  private void OnBeginTransitionCameraRendering(ScriptableRenderContext context, Camera camera)
  {
  }

  [Token(Token = "0x60009EE")]
  [Address(RVA = "0x4776EE4", Offset = "0x4776EE4", VA = "0x4776EE4")]
  public void PauseTimeline(PlayableDirector director)
  {
  }

  [Token(Token = "0x60009EF")]
  [Address(RVA = "0x4776EFC", Offset = "0x4776EFC", VA = "0x4776EFC")]
  public void ResumeTimeline(PlayableDirector director)
  {
  }

  [Token(Token = "0x60009F0")]
  [Address(RVA = "0x4776F14", Offset = "0x4776F14", VA = "0x4776F14")]
  public void StopTimeline(PlayableDirector director)
  {
  }

  [Token(Token = "0x60009F1")]
  [Address(RVA = "0x4776F2C", Offset = "0x4776F2C", VA = "0x4776F2C")]
  private void ShowFullDuelListIn(DuelData data)
  {
  }

  [Token(Token = "0x60009F2")]
  [Address(RVA = "0x4776FEC", Offset = "0x4776FEC", VA = "0x4776FEC")]
  public DuelStage()
  {
  }

  [Token(Token = "0x200016B")]
  public enum DuelStageStatus
  {
    [Token(Token = "0x400092C")] NotStart,
    [Token(Token = "0x400092D")] Playing,
    [Token(Token = "0x400092E")] Finish,
  }
}
