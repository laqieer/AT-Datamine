// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Instance.MovableMobInstanceBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.FadeContent;
using Area.MovableMob.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Instance
{
  [Token(Token = "0x2002834")]
  public abstract class MovableMobInstanceBase : MonoBehaviour
  {
    [Token(Token = "0x400AB78")]
    protected const string ObjectLayerName = "Chara";
    [Token(Token = "0x400AB7A")]
    [FieldOffset(Offset = "0x20")]
    protected MovableMobRouteHandler owner;
    [Token(Token = "0x400AB7B")]
    [FieldOffset(Offset = "0x28")]
    protected float destroyTime;
    [Token(Token = "0x400AB7C")]
    [FieldOffset(Offset = "0x2C")]
    protected float currentDestroyTime;
    [Token(Token = "0x400AB7D")]
    [FieldOffset(Offset = "0x30")]
    protected float changeDuration;
    [Token(Token = "0x400AB7E")]
    [FieldOffset(Offset = "0x34")]
    protected float currentChangeTime;
    [Token(Token = "0x400AB7F")]
    [FieldOffset(Offset = "0x38")]
    protected IMovableMobAnchor currentAnchor;
    [Token(Token = "0x400AB81")]
    [FieldOffset(Offset = "0x48")]
    private readonly List<AreaMovableMobFadeContent> fadeContents;
    [Token(Token = "0x400AB82")]
    [FieldOffset(Offset = "0x50")]
    private float fadeMobCameraRadius;
    [Token(Token = "0x400AB83")]
    [FieldOffset(Offset = "0x54")]
    private float fadeMobPlayerRadius;
    [Token(Token = "0x400AB84")]
    [FieldOffset(Offset = "0x58")]
    private float fadeMobPlayerDistance;

    [Token(Token = "0x170037A4")]
    public virtual int InstanceDataID
    {
      [Token(Token = "0x600FD15"), Address(RVA = "0x442BA34", Offset = "0x442BA34", VA = "0x442BA34", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FD16"), Address(RVA = "0x442BA3C", Offset = "0x442BA3C", VA = "0x442BA3C", Slot = "5")] protected set
      {
      }
    }

    [Token(Token = "0x170037A5")]
    protected Transform ControllTransform
    {
      [Token(Token = "0x600FD17"), Address(RVA = "0x442BA44", Offset = "0x442BA44", VA = "0x442BA44")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170037A6")]
    private List<MovableMobAnimator> myAnimatorList
    {
      [Token(Token = "0x600FD18"), Address(RVA = "0x442BA4C", Offset = "0x442BA4C", VA = "0x442BA4C")] set
      {
      }
      [Token(Token = "0x600FD19"), Address(RVA = "0x442BA54", Offset = "0x442BA54", VA = "0x442BA54")] get
      {
        return (List<MovableMobAnimator>) null;
      }
    }

    [Token(Token = "0x170037A7")]
    public List<MovableMobAnimator> Animators
    {
      [Token(Token = "0x600FD1A"), Address(RVA = "0x442BA5C", Offset = "0x442BA5C", VA = "0x442BA5C")] get
      {
        return (List<MovableMobAnimator>) null;
      }
    }

    [Token(Token = "0x170037A8")]
    public bool ActiveSelf
    {
      [Token(Token = "0x600FD1B"), Address(RVA = "0x4429428", Offset = "0x4429428", VA = "0x4429428")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170037A9")]
    public bool IsDestroyed
    {
      [Token(Token = "0x600FD1C"), Address(RVA = "0x442BA64", Offset = "0x442BA64", VA = "0x442BA64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FD1D")]
    [Address(RVA = "0x442BAD4", Offset = "0x442BAD4", VA = "0x442BAD4")]
    protected void InitialzeInternal(
      MovableMobInstanceDataBase data,
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor)
    {
    }

    [Token(Token = "0x600FD1E")]
    [Address(RVA = "0x442BBE4", Offset = "0x442BBE4", VA = "0x442BBE4")]
    protected void FadeInitialize(GameObject obj)
    {
    }

    [Token(Token = "0x600FD1F")]
    [Address(RVA = "0x4429E0C", Offset = "0x4429E0C", VA = "0x4429E0C")]
    public void SetAnchor(IMovableMobAnchor startAnchor, float ratio)
    {
    }

    [Token(Token = "0x600FD20")]
    [Address(RVA = "0x442BEC8", Offset = "0x442BEC8", VA = "0x442BEC8")]
    private void SetPositionAndRotation(float ratio)
    {
    }

    [Token(Token = "0x600FD21")]
    [Address(RVA = "0x4429088", Offset = "0x4429088", VA = "0x4429088")]
    public void MoveUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x600FD22")]
    [Address(RVA = "0x4429758", Offset = "0x4429758", VA = "0x4429758")]
    public void ViewUpdate(Camera camera, Transform playerTransform)
    {
    }

    [Token(Token = "0x600FD23")]
    [Address(RVA = "0x442C19C", Offset = "0x442C19C", VA = "0x442C19C")]
    private void TransformUpdate(float ratio)
    {
    }

    [Token(Token = "0x600FD24")]
    [Address(RVA = "0x442C138", Offset = "0x442C138", VA = "0x442C138")]
    protected Quaternion GetNextRotation(Vector3 newPosition, Vector3 oldPosition)
    {
      return new Quaternion();
    }

    [Token(Token = "0x600FD25")]
    [Address(RVA = "0x442A200", Offset = "0x442A200", VA = "0x442A200")]
    public void SetActive(bool enable)
    {
    }

    [Token(Token = "0x600FD26")]
    [Address(RVA = "0x442947C", Offset = "0x442947C", VA = "0x442947C")]
    public bool IsOverLifeTime() => new bool();

    [Token(Token = "0x600FD27")]
    [Address(RVA = "0x4429448", Offset = "0x4429448", VA = "0x4429448")]
    public void DeactiveUpdate()
    {
    }

    [Token(Token = "0x600FD28")]
    [Address(RVA = "0x442948C", Offset = "0x442948C", VA = "0x442948C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600FD29")]
    [Address(RVA = "0x442C438", Offset = "0x442C438", VA = "0x442C438")]
    protected void OnDestroy()
    {
    }

    [Token(Token = "0x600FD2A")]
    [Address(RVA = "0x442C67C", Offset = "0x442C67C", VA = "0x442C67C")]
    protected MovableMobAnimator SetAnimation(GameObject modelObject, AnimationClip clip)
    {
      return (MovableMobAnimator) null;
    }

    [Token(Token = "0x600FD2B")]
    [Address(RVA = "0x442C7FC", Offset = "0x442C7FC", VA = "0x442C7FC")]
    protected void AttachProp(
      GameObject prop,
      GameObject model,
      MovableMobAnimator animator,
      PropSettingData settingData,
      StoryCharacterLookWeatherTypeEnum lookWeatherType)
    {
    }

    [Token(Token = "0x600FD2C")]
    public abstract MovableMobType GetMobType();

    [Token(Token = "0x600FD2D")]
    [Address(RVA = "0x442C9F8", Offset = "0x442C9F8", VA = "0x442C9F8")]
    protected void SetObjectLayer(GameObject obj)
    {
    }

    [Token(Token = "0x600FD2E")]
    [Address(RVA = "0x442C340", Offset = "0x442C340", VA = "0x442C340")]
    private void FadeUpdate(
      AreaMovableMobFadeContent fadeContent,
      Camera usingCamera,
      Transform playerTransform)
    {
    }

    [Token(Token = "0x600FD2F")]
    [Address(RVA = "0x442CD14", Offset = "0x442CD14", VA = "0x442CD14")]
    private bool IsFadeDecision(
      AreaMovableMobFadeContent fadeContent,
      Camera usingCamera,
      Transform playerTransform = null)
    {
      return new bool();
    }

    [Token(Token = "0x600FD30")]
    [Address(RVA = "0x442D29C", Offset = "0x442D29C", VA = "0x442D29C")]
    protected MovableMobInstanceBase()
    {
    }
  }
}
