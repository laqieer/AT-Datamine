// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Object
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E1C")]
  [ExecuteAlways]
  public class Adv2Object : MonoBehaviour
  {
    [Token(Token = "0x401108C")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2BindRoot bindRoot;
    [Token(Token = "0x401108F")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, Adv2Manager.OnProccessSignal> animationSignals;
    [Token(Token = "0x4011090")]
    [FieldOffset(Offset = "0x30")]
    protected Dictionary<AnimationState, float> animationTimeBackup;
    [Token(Token = "0x4011091")]
    [FieldOffset(Offset = "0x38")]
    protected ParticleSystem[] particles;
    [Token(Token = "0x4011092")]
    [FieldOffset(Offset = "0x40")]
    public Transform turnTargetTransform;
    [Token(Token = "0x4011093")]
    [FieldOffset(Offset = "0x48")]
    public float turnTargetInter;
    [Token(Token = "0x4011094")]
    private const int KeyframeDivisionNumber = 32;
    [Token(Token = "0x4011095")]
    [FieldOffset(Offset = "0x50")]
    private Adv2Object.AroundMoveData aroundMoveData;
    [Token(Token = "0x4011096")]
    [FieldOffset(Offset = "0x58")]
    private Adv2Object lookAtTarget;
    [Token(Token = "0x4011097")]
    [FieldOffset(Offset = "0x60")]
    private float lookAtOfsetY;
    [Token(Token = "0x4011098")]
    [FieldOffset(Offset = "0x68")]
    protected FreeAnimatorController overrideAnimation;
    [Token(Token = "0x4011099")]
    [FieldOffset(Offset = "0x70")]
    protected float exitOverrideAnimationTime;
    [Token(Token = "0x401109A")]
    [FieldOffset(Offset = "0x78")]
    protected Adv2LinkageAnimation bodyLinkage;
    [Token(Token = "0x401109C")]
    protected const string bodyAnimationLayerName = "body";
    [Token(Token = "0x401109D")]
    [FieldOffset(Offset = "0x88")]
    protected RuntimeAnimatorController backupController;
    [Token(Token = "0x401109E")]
    [FieldOffset(Offset = "0x90")]
    private DynamicBonesController[] dynamicBonesControllers;
    [Token(Token = "0x401109F")]
    [FieldOffset(Offset = "0x98")]
    protected Dictionary<string, Dictionary<string, string>> animationEventSoundList;

    [Token(Token = "0x17005150")]
    public bool IsExistBindObject
    {
      [Token(Token = "0x6019024"), Address(RVA = "0x2961B5C", Offset = "0x2961B5C", VA = "0x2961B5C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005151")]
    public bool HaveDutyRecover
    {
      [Token(Token = "0x6019025"), Address(RVA = "0x2961BBC", Offset = "0x2961BBC", VA = "0x2961BBC")] protected set
      {
      }
      [Token(Token = "0x6019026"), Address(RVA = "0x2961BC8", Offset = "0x2961BC8", VA = "0x2961BC8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005152")]
    public Transform RootTransform
    {
      [Token(Token = "0x6019027"), Address(RVA = "0x2961BD0", Offset = "0x2961BD0", VA = "0x2961BD0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17005153")]
    public Vector3 RootPosition
    {
      [Token(Token = "0x6019028"), Address(RVA = "0x2961BEC", Offset = "0x2961BEC", VA = "0x2961BEC")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6019029"), Address(RVA = "0x2961C14", Offset = "0x2961C14", VA = "0x2961C14")] set
      {
      }
    }

    [Token(Token = "0x17005154")]
    public Vector3 RootEulerAngles
    {
      [Token(Token = "0x601902A"), Address(RVA = "0x2961C64", Offset = "0x2961C64", VA = "0x2961C64")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x601902B"), Address(RVA = "0x2961C8C", Offset = "0x2961C8C", VA = "0x2961C8C")] set
      {
      }
    }

    [Token(Token = "0x17005155")]
    public Vector3 RootLocalEulerAngles
    {
      [Token(Token = "0x601902C"), Address(RVA = "0x2961CDC", Offset = "0x2961CDC", VA = "0x2961CDC")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x601902D"), Address(RVA = "0x2961D04", Offset = "0x2961D04", VA = "0x2961D04")] set
      {
      }
    }

    [Token(Token = "0x17005156")]
    public Vector3 RootScale
    {
      [Token(Token = "0x601902E"), Address(RVA = "0x2961D54", Offset = "0x2961D54", VA = "0x2961D54")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x601902F"), Address(RVA = "0x2961D7C", Offset = "0x2961D7C", VA = "0x2961D7C")] set
      {
      }
    }

    [Token(Token = "0x17005157")]
    public Animator RootAnimator
    {
      [Token(Token = "0x6019030"), Address(RVA = "0x2961DCC", Offset = "0x2961DCC", VA = "0x2961DCC")] get
      {
        return (Animator) null;
      }
      [Token(Token = "0x6019031"), Address(RVA = "0x2961DE8", Offset = "0x2961DE8", VA = "0x2961DE8")] set
      {
      }
    }

    [Token(Token = "0x17005158")]
    public bool IsStanding
    {
      [Token(Token = "0x6019032"), Address(RVA = "0x2961E04", Offset = "0x2961E04", VA = "0x2961E04")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019033"), Address(RVA = "0x2961E0C", Offset = "0x2961E0C", VA = "0x2961E0C")] set
      {
      }
    }

    [Token(Token = "0x6019034")]
    [Address(RVA = "0x2961E18", Offset = "0x2961E18", VA = "0x2961E18")]
    public void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x6019035")]
    [Address(RVA = "0x2961EF8", Offset = "0x2961EF8", VA = "0x2961EF8", Slot = "4")]
    protected virtual void CheckParticleSpeed()
    {
    }

    [Token(Token = "0x6019036")]
    [Address(RVA = "0x2961F58", Offset = "0x2961F58", VA = "0x2961F58")]
    protected void CheckTurnLookAt()
    {
    }

    [Token(Token = "0x6019037")]
    [Address(RVA = "0x29620D8", Offset = "0x29620D8", VA = "0x29620D8", Slot = "5")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x6019038")]
    [Address(RVA = "0x29627B8", Offset = "0x29627B8", VA = "0x29627B8", Slot = "6")]
    protected virtual void LateUpdate()
    {
    }

    [Token(Token = "0x6019039")]
    [Address(RVA = "0x2962904", Offset = "0x2962904", VA = "0x2962904")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601903A")]
    [Address(RVA = "0x2962D0C", Offset = "0x2962D0C", VA = "0x2962D0C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x601903B")]
    [Address(RVA = "0x29630AC", Offset = "0x29630AC", VA = "0x29630AC", Slot = "7")]
    protected virtual void UpdateNotPlaying()
    {
    }

    [Token(Token = "0x601903C")]
    [Address(RVA = "0x2963528", Offset = "0x2963528", VA = "0x2963528")]
    protected Adv2Manager.OnProccessSignal AddRootAnimationClip(
      Vector3 oldValue,
      Vector3 newValue,
      float duration,
      Adv2Object.RootAnimationType type,
      string clipName,
      string propertyName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601903D")]
    [Address(RVA = "0x2963B78", Offset = "0x2963B78", VA = "0x2963B78", Slot = "8")]
    public virtual Adv2Manager.OnProccessSignal Move(
      Vector3 targetPosition,
      float duration,
      Adv2Object.RootAnimationType type)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601903E")]
    [Address(RVA = "0x2963900", Offset = "0x2963900", VA = "0x2963900")]
    private Adv2Manager.OnProccessSignal PlayAnimationClip(AnimationClip newClip, string clipName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601903F")]
    [Address(RVA = "0x2963D00", Offset = "0x2963D00", VA = "0x2963D00")]
    private Adv2Manager.OnProccessSignal VectorArrayMove(Vector3[] data, float time, int speedType)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019040")]
    [Address(RVA = "0x296402C", Offset = "0x296402C", VA = "0x296402C")]
    private Func<float, float, float> GetEasingFunc(int speedType)
    {
      return (Func<float, float, float>) null;
    }

    [Token(Token = "0x6019041")]
    [Address(RVA = "0x2964134", Offset = "0x2964134", VA = "0x2964134")]
    private float GetEasingLinear(float totalTime, float progressTime) => new float();

    [Token(Token = "0x6019042")]
    [Address(RVA = "0x296413C", Offset = "0x296413C", VA = "0x296413C")]
    private float GetEasingEaseIn(float totalTime, float progressTime) => new float();

    [Token(Token = "0x6019043")]
    [Address(RVA = "0x296414C", Offset = "0x296414C", VA = "0x296414C")]
    private float GetEasingEaseOut(float totalTime, float progressTime) => new float();

    [Token(Token = "0x6019044")]
    [Address(RVA = "0x2964178", Offset = "0x2964178", VA = "0x2964178")]
    private float GetEasingEaseInOut(float totalTime, float progressTime) => new float();

    [Token(Token = "0x6019045")]
    [Address(RVA = "0x29641CC", Offset = "0x29641CC", VA = "0x29641CC")]
    public Adv2Manager.OnProccessSignal SlideMove(
      Vector3 startPosition,
      Vector3 endPosition,
      float duration,
      int speedType)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019046")]
    [Address(RVA = "0x29643D0", Offset = "0x29643D0", VA = "0x29643D0")]
    public Adv2Manager.OnProccessSignal CurveMove(
      Vector3 startPosition,
      Vector3 pathPosition,
      Vector3 endPosition,
      float duration,
      int speedType)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019047")]
    [Address(RVA = "0x29649DC", Offset = "0x29649DC", VA = "0x29649DC")]
    public Adv2Manager.OnProccessSignal CircleMove(
      Vector3 startPosition,
      Vector3 centerPosition,
      float angle,
      float duration,
      int speedType)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019048")]
    [Address(RVA = "0x2964BC8", Offset = "0x2964BC8", VA = "0x2964BC8")]
    public Adv2Manager.OnProccessSignal AroundMove(
      Adv2Object target,
      float angle,
      float duration,
      int speedType)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019049")]
    [Address(RVA = "0x29627D0", Offset = "0x29627D0", VA = "0x29627D0")]
    private void AroundMoveExec()
    {
    }

    [Token(Token = "0x601904A")]
    [Address(RVA = "0x2964F84", Offset = "0x2964F84", VA = "0x2964F84")]
    public void SetLookAtObject(Adv2Object target)
    {
    }

    [Token(Token = "0x601904B")]
    [Address(RVA = "0x2965070", Offset = "0x2965070", VA = "0x2965070")]
    public void ResetLookAtObject()
    {
    }

    [Token(Token = "0x601904C")]
    [Address(RVA = "0x2962834", Offset = "0x2962834", VA = "0x2962834")]
    private void LookAtObjectExec()
    {
    }

    [Token(Token = "0x601904D")]
    [Address(RVA = "0x29650A4", Offset = "0x29650A4", VA = "0x29650A4")]
    public float CheckGroundHeight(Vector3 pos) => new float();

    [Token(Token = "0x601904E")]
    [Address(RVA = "0x2965260", Offset = "0x2965260", VA = "0x2965260")]
    private IEnumerator GroundMoveProcess(
      Vector3 targetPos,
      float duration,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601904F")]
    [Address(RVA = "0x2965328", Offset = "0x2965328", VA = "0x2965328")]
    private IEnumerator GroundMoveProcessUseNavMesh(
      Vector3 targetPos,
      float duration,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019050")]
    [Address(RVA = "0x29653F4", Offset = "0x29653F4", VA = "0x29653F4")]
    public Adv2Manager.OnProccessSignal GroundMove(
      Vector3 targetPosition,
      float duration,
      bool usenavimesh)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019051")]
    [Address(RVA = "0x296555C", Offset = "0x296555C", VA = "0x296555C", Slot = "9")]
    public virtual Adv2Manager.OnProccessSignal TransMove(Vector3 targetPosition, float duration)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019052")]
    [Address(RVA = "0x29656A0", Offset = "0x29656A0", VA = "0x29656A0")]
    private IEnumerator TransMoveProcess(
      Vector3 targetPos,
      float duration,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019053")]
    [Address(RVA = "0x2965768", Offset = "0x2965768", VA = "0x2965768")]
    public Adv2Manager.OnProccessSignal YRotate(
      float rotateAngle,
      float duration,
      Adv2Object.RootAnimationType type)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019054")]
    [Address(RVA = "0x29658B0", Offset = "0x29658B0", VA = "0x29658B0")]
    public Adv2Manager.OnProccessSignal Rotate(
      Vector3 targetEulerAngles,
      float duration,
      Adv2Object.RootAnimationType type)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019055")]
    [Address(RVA = "0x2965C6C", Offset = "0x2965C6C", VA = "0x2965C6C")]
    public Adv2Manager.OnProccessSignal TransRotate(Vector3 targetEulerAngles, float duration)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019056")]
    [Address(RVA = "0x2965EE4", Offset = "0x2965EE4", VA = "0x2965EE4")]
    private IEnumerator TransRotateProcess(
      Vector3 targetRot,
      float duration,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019057")]
    [Address(RVA = "0x2965BF4", Offset = "0x2965BF4", VA = "0x2965BF4")]
    protected float GetRotateAngle(float myAngle, float targetAngle) => new float();

    [Token(Token = "0x6019058")]
    [Address(RVA = "0x2965FAC", Offset = "0x2965FAC", VA = "0x2965FAC")]
    public void SetBindParent(Adv2Object parent, string[] path)
    {
    }

    [Token(Token = "0x6019059")]
    [Address(RVA = "0x29660CC", Offset = "0x29660CC", VA = "0x29660CC")]
    public void ResetBindParent()
    {
    }

    [Token(Token = "0x601905A")]
    [Address(RVA = "0x296611C", Offset = "0x296611C", VA = "0x296611C")]
    public void SetOffsetPosition(Vector3 offset)
    {
    }

    [Token(Token = "0x601905B")]
    [Address(RVA = "0x296616C", Offset = "0x296616C", VA = "0x296616C")]
    public void SetOffsetEulerAngles(Vector3 offset)
    {
    }

    [Token(Token = "0x601905C")]
    [Address(RVA = "0x29661BC", Offset = "0x29661BC", VA = "0x29661BC", Slot = "10")]
    public virtual void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x601905D")]
    [Address(RVA = "0x29661E4", Offset = "0x29661E4", VA = "0x29661E4", Slot = "11")]
    public virtual bool IsActive() => new bool();

    [Token(Token = "0x601905E")]
    [Address(RVA = "0x2966204", Offset = "0x2966204", VA = "0x2966204")]
    public void SetBindObjectName(string name)
    {
    }

    [Token(Token = "0x17005159")]
    public FreeAnimatorController OverrideAnimation
    {
      [Token(Token = "0x601905F"), Address(RVA = "0x2966220", Offset = "0x2966220", VA = "0x2966220")] get
      {
        return (FreeAnimatorController) null;
      }
    }

    [Token(Token = "0x1700515A")]
    public Adv2LinkageAnimation BodyLinkage
    {
      [Token(Token = "0x6019060"), Address(RVA = "0x2966228", Offset = "0x2966228", VA = "0x2966228")] get
      {
        return (Adv2LinkageAnimation) null;
      }
      [Token(Token = "0x6019061"), Address(RVA = "0x2966230", Offset = "0x2966230", VA = "0x2966230")] set
      {
      }
    }

    [Token(Token = "0x1700515B")]
    public Adv2LinkageAnimation.ReserveLinagePack ReserveBodyAnimationPack
    {
      [Token(Token = "0x6019062"), Address(RVA = "0x2966238", Offset = "0x2966238", VA = "0x2966238")] get
      {
        return (Adv2LinkageAnimation.ReserveLinagePack) null;
      }
      [Token(Token = "0x6019063"), Address(RVA = "0x2966240", Offset = "0x2966240", VA = "0x2966240")] set
      {
      }
    }

    [Token(Token = "0x6019064")]
    [Address(RVA = "0x2966248", Offset = "0x2966248", VA = "0x2966248", Slot = "12")]
    public virtual void SetAnimationSystemChangeTime(float startTime, float exitTime)
    {
    }

    [Token(Token = "0x6019065")]
    [Address(RVA = "0x2966268", Offset = "0x2966268", VA = "0x2966268")]
    public Adv2Manager.OnProccessSignal PlayBodyAnimation(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool isLoop)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019066")]
    [Address(RVA = "0x2966378", Offset = "0x2966378", VA = "0x2966378")]
    public void ReserveBodyAnimation(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool isLoop)
    {
    }

    [Token(Token = "0x6019067")]
    [Address(RVA = "0x296645C", Offset = "0x296645C", VA = "0x296645C", Slot = "13")]
    protected virtual void SetAdv2LinkageAnimation(
      GameObject rootObject,
      Adv2LinkageAnimation[] linkageList)
    {
    }

    [Token(Token = "0x6019068")]
    [Address(RVA = "0x2966524", Offset = "0x2966524", VA = "0x2966524")]
    protected void SetAdv2LinkageAnimation(
      ref Adv2LinkageAnimation output,
      string layerName,
      GameObject rootObject,
      Adv2LinkageAnimation[] linkageList)
    {
    }

    [Token(Token = "0x6019069")]
    [Address(RVA = "0x296663C", Offset = "0x296663C", VA = "0x296663C")]
    public void SetAdv2LinkageAnimation()
    {
    }

    [Token(Token = "0x601906A")]
    [Address(RVA = "0x29667AC", Offset = "0x29667AC", VA = "0x29667AC")]
    public void ResetDynamicBone()
    {
    }

    [Token(Token = "0x601906B")]
    [Address(RVA = "0x29668E4", Offset = "0x29668E4", VA = "0x29668E4", Slot = "14")]
    public virtual void SetAnimationEvent()
    {
    }

    [Token(Token = "0x601906C")]
    [Address(RVA = "0x2966AB0", Offset = "0x2966AB0", VA = "0x2966AB0")]
    public void SetAnimationEventSound(string typeName, string tagName, string soundName)
    {
    }

    [Token(Token = "0x601906D")]
    [Address(RVA = "0x2966B7C", Offset = "0x2966B7C", VA = "0x2966B7C")]
    protected string GetAnimationEventSoundName(string typeName, List<string> argument)
    {
      return (string) null;
    }

    [Token(Token = "0x601906E")]
    [Address(RVA = "0x2966D08", Offset = "0x2966D08", VA = "0x2966D08")]
    protected void OnAnimationEventVoice(List<string> argument)
    {
    }

    [Token(Token = "0x601906F")]
    [Address(RVA = "0x2966DF0", Offset = "0x2966DF0", VA = "0x2966DF0")]
    protected void OnAnimationEventSE(List<string> argument)
    {
    }

    [Token(Token = "0x6019070")]
    [Address(RVA = "0x2966ED4", Offset = "0x2966ED4", VA = "0x2966ED4")]
    public void StopBodyAnimation()
    {
    }

    [Token(Token = "0x6019071")]
    [Address(RVA = "0x2966F28", Offset = "0x2966F28", VA = "0x2966F28")]
    public void ConnectAnimatorController()
    {
    }

    [Token(Token = "0x6019072")]
    [Address(RVA = "0x2966F5C", Offset = "0x2966F5C", VA = "0x2966F5C")]
    public void DisconnectAnimatorController()
    {
    }

    [Token(Token = "0x6019073")]
    [Address(RVA = "0x2966F80", Offset = "0x2966F80", VA = "0x2966F80")]
    public void UseAnimatorController()
    {
    }

    [Token(Token = "0x6019074")]
    [Address(RVA = "0x2966FAC", Offset = "0x2966FAC", VA = "0x2966FAC")]
    public void UnuseAnimatorController()
    {
    }

    [Token(Token = "0x6019075")]
    [Address(RVA = "0x2966FD0", Offset = "0x2966FD0", VA = "0x2966FD0", Slot = "15")]
    public virtual void SetBindObject(GameObject prefab, bool setParent = true)
    {
    }

    [Token(Token = "0x6019076")]
    [Address(RVA = "0x296724C", Offset = "0x296724C", VA = "0x296724C")]
    public List<Adv2Manager.OnProccessSignal> LoadModel(
      string objectAssetbundleName,
      string objectFileName,
      string animationAssetbundleName,
      string animationFileName)
    {
      return (List<Adv2Manager.OnProccessSignal>) null;
    }

    [Token(Token = "0x6019077")]
    [Address(RVA = "0x29674A0", Offset = "0x29674A0", VA = "0x29674A0")]
    public Adv2Manager.OnProccessSignal LoadAnimator(
      string animatorControllerAssetbundleName,
      string animatorControllerFileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019078")]
    [Address(RVA = "0x29675B4", Offset = "0x29675B4", VA = "0x29675B4")]
    public bool CheckControllerName(string controllerName) => new bool();

    [Token(Token = "0x6019079")]
    [Address(RVA = "0x296767C", Offset = "0x296767C", VA = "0x296767C")]
    public Adv2Manager.OnProccessSignal LoadAnimation(
      string animationAssetbundleName,
      string animationFileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601907A")]
    protected void RemoveComponents<T>(GameObject rootObject) where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x601907B")]
    [Address(RVA = "0x296777C", Offset = "0x296777C", VA = "0x296777C", Slot = "16")]
    public virtual void RecoverBindObject()
    {
    }

    [Token(Token = "0x601907C")]
    [Address(RVA = "0x2967A84", Offset = "0x2967A84", VA = "0x2967A84")]
    protected static GameObject CreateObject(string objectName, Transform parent)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x601907D")]
    [Address(RVA = "0x2967B14", Offset = "0x2967B14", VA = "0x2967B14")]
    public static Adv2Object Create(string objectName, Transform parent) => (Adv2Object) null;

    [Token(Token = "0x601907E")]
    [Address(RVA = "0x2967B70", Offset = "0x2967B70", VA = "0x2967B70")]
    public Adv2Object()
    {
    }

    [Token(Token = "0x2003E1D")]
    public enum SpeedType
    {
      [Token(Token = "0x40110A1")] Linear,
      [Token(Token = "0x40110A2")] EaseIn,
      [Token(Token = "0x40110A3")] EaseOut,
      [Token(Token = "0x40110A4")] EaseInOut,
    }

    [Token(Token = "0x2003E1E")]
    protected class RootAnimationName
    {
      [Token(Token = "0x40110A5")]
      public const string MoveClip = "Move";
      [Token(Token = "0x40110A6")]
      public const string RotateClip = "Rotate";
      [Token(Token = "0x40110A7")]
      public const string MoveProperty = "localPosition";
      [Token(Token = "0x40110A8")]
      public const string RotateProperty = "localEulerAngles";

      [Token(Token = "0x601907F")]
      [Address(RVA = "0x2967CB0", Offset = "0x2967CB0", VA = "0x2967CB0")]
      public RootAnimationName()
      {
      }
    }

    [Token(Token = "0x2003E1F")]
    public enum RootAnimationType
    {
      [Token(Token = "0x40110AA")] EaseInOut,
      [Token(Token = "0x40110AB")] Linear,
    }

    [Token(Token = "0x2003E20")]
    private class AroundMoveData
    {
      [Token(Token = "0x40110AC")]
      [FieldOffset(Offset = "0x10")]
      private Adv2Object target;
      [Token(Token = "0x40110AD")]
      [FieldOffset(Offset = "0x18")]
      private float xzDistance;
      [Token(Token = "0x40110AE")]
      [FieldOffset(Offset = "0x1C")]
      private float yDistance;
      [Token(Token = "0x40110AF")]
      [FieldOffset(Offset = "0x20")]
      private AnimationCurve timeCurve;
      [Token(Token = "0x40110B0")]
      [FieldOffset(Offset = "0x28")]
      private float startTime;
      [Token(Token = "0x40110B1")]
      [FieldOffset(Offset = "0x2C")]
      private float endTime;
      [Token(Token = "0x40110B2")]
      [FieldOffset(Offset = "0x30")]
      private Adv2Manager.OnProccessSignal signal;

      [Token(Token = "0x6019080")]
      [Address(RVA = "0x2964E28", Offset = "0x2964E28", VA = "0x2964E28")]
      public AroundMoveData(
        Adv2Object target,
        float xzDistance,
        float yDistance,
        AnimationCurve timeCurve,
        float duration,
        Adv2Manager.OnProccessSignal signal)
      {
      }

      [Token(Token = "0x6019081")]
      [Address(RVA = "0x2964E98", Offset = "0x2964E98", VA = "0x2964E98")]
      public Vector3 GetPosition() => new Vector3();

      [Token(Token = "0x6019082")]
      [Address(RVA = "0x2964F38", Offset = "0x2964F38", VA = "0x2964F38")]
      public bool IsEnd() => new bool();
    }
  }
}
