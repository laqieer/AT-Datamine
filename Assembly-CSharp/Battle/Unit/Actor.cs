// Decompiled with JetBrains decompiler
// Type: Battle.Unit.Actor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022D9")]
  public abstract class Actor : MonoBehaviour, IActor
  {
    [Token(Token = "0x4009341")]
    [FieldOffset(Offset = "0x18")]
    protected GameObject displayedObject;
    [Token(Token = "0x4009342")]
    [FieldOffset(Offset = "0x20")]
    protected Animator animator;
    [Token(Token = "0x4009344")]
    [FieldOffset(Offset = "0x2C")]
    private Actor.AnimationInfo currentAnimInfo;
    [Token(Token = "0x4009345")]
    [FieldOffset(Offset = "0x38")]
    private Actor.AnimationInfo nextAnimInfo;
    [Token(Token = "0x4009346")]
    [FieldOffset(Offset = "0x44")]
    private bool animationModified;
    [Token(Token = "0x400934A")]
    private const string DotRootObjectName = "Root";
    [Token(Token = "0x400934B")]
    [FieldOffset(Offset = "0x68")]
    private Transform dotRoot;

    [Token(Token = "0x17002DF1")]
    public virtual Transform LocatorEffectHead
    {
      [Token(Token = "0x600D481"), Address(RVA = "0x19E7C94", Offset = "0x19E7C94", VA = "0x19E7C94", Slot = "36")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002DF2")]
    public virtual Transform LocatorEffectBody
    {
      [Token(Token = "0x600D482"), Address(RVA = "0x19E7C9C", Offset = "0x19E7C9C", VA = "0x19E7C9C", Slot = "37")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002DF3")]
    public virtual Transform LocatorEffectBottom
    {
      [Token(Token = "0x600D483"), Address(RVA = "0x19E7CA4", Offset = "0x19E7CA4", VA = "0x19E7CA4", Slot = "38")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002DF4")]
    public virtual Transform LocatorEffectWeapon
    {
      [Token(Token = "0x600D484"), Address(RVA = "0x19E7CAC", Offset = "0x19E7CAC", VA = "0x19E7CAC", Slot = "39")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002DF5")]
    public Actor.Direction DefaultDirection
    {
      [Token(Token = "0x600D485"), Address(RVA = "0x19E7CB4", Offset = "0x19E7CB4", VA = "0x19E7CB4", Slot = "28")] get
      {
        return new Actor.Direction();
      }
      [Token(Token = "0x600D486"), Address(RVA = "0x19E7CBC", Offset = "0x19E7CBC", VA = "0x19E7CBC")] set
      {
      }
    }

    [Token(Token = "0x17002DF6")]
    public Actor.AnimationType CurrentAnimation
    {
      [Token(Token = "0x600D487"), Address(RVA = "0x19E7CC4", Offset = "0x19E7CC4", VA = "0x19E7CC4", Slot = "26")] get
      {
        return new Actor.AnimationType();
      }
    }

    [Token(Token = "0x17002DF7")]
    public Actor.Direction CurrentDirection
    {
      [Token(Token = "0x600D488"), Address(RVA = "0x19E7CE0", Offset = "0x19E7CE0", VA = "0x19E7CE0", Slot = "27")] get
      {
        return new Actor.Direction();
      }
    }

    [Token(Token = "0x17002DF8")]
    public Vector3 PositionOffset
    {
      [Token(Token = "0x600D489"), Address(RVA = "0x19E7CFC", Offset = "0x19E7CFC", VA = "0x19E7CFC", Slot = "40")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600D48A"), Address(RVA = "0x19E7D08", Offset = "0x19E7D08", VA = "0x19E7D08", Slot = "41")] set
      {
      }
    }

    [Token(Token = "0x17002DF9")]
    public Quaternion RotationOffset
    {
      [Token(Token = "0x600D48B"), Address(RVA = "0x19E7D14", Offset = "0x19E7D14", VA = "0x19E7D14", Slot = "42")] get
      {
        return new Quaternion();
      }
      [Token(Token = "0x600D48C"), Address(RVA = "0x19E7D20", Offset = "0x19E7D20", VA = "0x19E7D20", Slot = "43")] set
      {
      }
    }

    [Token(Token = "0x17002DFA")]
    public bool Initialized
    {
      [Token(Token = "0x600D48D"), Address(RVA = "0x19E7D2C", Offset = "0x19E7D2C", VA = "0x19E7D2C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D48E"), Address(RVA = "0x19E7D34", Offset = "0x19E7D34", VA = "0x19E7D34")] private set
      {
      }
    }

    [Token(Token = "0x17002DFB")]
    public bool IsPlayingAnimation
    {
      [Token(Token = "0x600D48F"), Address(RVA = "0x19E7D40", Offset = "0x19E7D40", VA = "0x19E7D40", Slot = "29")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D490")]
    [Address(RVA = "0x19E7DA4", Offset = "0x19E7DA4", VA = "0x19E7DA4")]
    public void Initialize(
      GameObject display,
      IActorViewData actorViewData,
      BattleConfigAsset config)
    {
    }

    [Token(Token = "0x600D491")]
    [Address(RVA = "0x19E7EE4", Offset = "0x19E7EE4", VA = "0x19E7EE4", Slot = "44")]
    public virtual void Show()
    {
    }

    [Token(Token = "0x600D492")]
    [Address(RVA = "0x19E7F08", Offset = "0x19E7F08", VA = "0x19E7F08", Slot = "45")]
    public virtual void Hide()
    {
    }

    [Token(Token = "0x600D493")]
    [Address(RVA = "0x19E7F2C", Offset = "0x19E7F2C", VA = "0x19E7F2C", Slot = "46")]
    public virtual void ChangeMotions(IDotWeaponAssetData weaponAssetData)
    {
    }

    [Token(Token = "0x600D494")]
    protected abstract void InitializeInternal(
      IActorViewData actorViewData,
      BattleConfigAsset config);

    [Token(Token = "0x600D495")]
    protected abstract void InternalPlayAnimation(
      Actor.AnimationType animation,
      Actor.Direction direction,
      bool resetTime);

    [Token(Token = "0x600D496")]
    [Address(RVA = "0x19E7F30", Offset = "0x19E7F30", VA = "0x19E7F30", Slot = "49")]
    public virtual void PlayIdle(bool reset = true)
    {
    }

    [Token(Token = "0x600D497")]
    [Address(RVA = "0x19E7F48", Offset = "0x19E7F48", VA = "0x19E7F48", Slot = "50")]
    public virtual void PlaySquat(bool reset = true)
    {
    }

    [Token(Token = "0x600D498")]
    [Address(RVA = "0x19E7F60", Offset = "0x19E7F60", VA = "0x19E7F60", Slot = "51")]
    public virtual void PlayMove(bool reset = true)
    {
    }

    [Token(Token = "0x600D499")]
    [Address(RVA = "0x19E7F7C", Offset = "0x19E7F7C", VA = "0x19E7F7C", Slot = "52")]
    public virtual void PlayAttack(bool reset = true)
    {
    }

    [Token(Token = "0x600D49A")]
    [Address(RVA = "0x19E7F98", Offset = "0x19E7F98", VA = "0x19E7F98", Slot = "53")]
    public virtual void PlayMagic(bool reset = true)
    {
    }

    [Token(Token = "0x600D49B")]
    [Address(RVA = "0x19E7FB4", Offset = "0x19E7FB4", VA = "0x19E7FB4", Slot = "54")]
    public virtual void PlayKnockback(bool reset = true)
    {
    }

    [Token(Token = "0x600D49C")]
    [Address(RVA = "0x19E7FD0", Offset = "0x19E7FD0", VA = "0x19E7FD0", Slot = "55")]
    public virtual void PlayBuff(bool reset = true)
    {
    }

    [Token(Token = "0x600D49D")]
    [Address(RVA = "0x19E7FEC", Offset = "0x19E7FEC", VA = "0x19E7FEC", Slot = "56")]
    public virtual void PlayDown(bool reset = true)
    {
    }

    [Token(Token = "0x600D49E")]
    [Address(RVA = "0x19E8008", Offset = "0x19E8008", VA = "0x19E8008", Slot = "57")]
    public virtual void PlayWin(bool reset = true)
    {
    }

    [Token(Token = "0x600D49F")]
    [Address(RVA = "0x19E8024", Offset = "0x19E8024", VA = "0x19E8024", Slot = "58")]
    public virtual void PlayAttackTui(bool reset = true)
    {
    }

    [Token(Token = "0x600D4A0")]
    [Address(RVA = "0x19E8040", Offset = "0x19E8040", VA = "0x19E8040", Slot = "59")]
    public virtual void PlaySkillDf(bool reset = true)
    {
    }

    [Token(Token = "0x600D4A1")]
    [Address(RVA = "0x19E805C", Offset = "0x19E805C", VA = "0x19E805C", Slot = "60")]
    public virtual void PlaySkillFf(bool reset = true)
    {
    }

    [Token(Token = "0x600D4A2")]
    [Address(RVA = "0x19E8078", Offset = "0x19E8078", VA = "0x19E8078", Slot = "61")]
    public virtual void PlayAdvP01(bool reset = true)
    {
    }

    [Token(Token = "0x600D4A3")]
    [Address(RVA = "0x19E8094", Offset = "0x19E8094", VA = "0x19E8094", Slot = "62")]
    public virtual void PlayAdvP02(bool reset = true)
    {
    }

    [Token(Token = "0x600D4A4")]
    [Address(RVA = "0x19E80B0", Offset = "0x19E80B0", VA = "0x19E80B0", Slot = "63")]
    public virtual void TurnTo(Actor.Direction direction, bool reset = true)
    {
    }

    [Token(Token = "0x600D4A5")]
    [Address(RVA = "0x19E80C8", Offset = "0x19E80C8", VA = "0x19E80C8", Slot = "64")]
    public virtual void PlayWithDirection(
      Actor.AnimationType animation,
      Actor.Direction direction,
      bool reset = true)
    {
    }

    [Token(Token = "0x600D4A6")]
    [Address(RVA = "0x19E80E0", Offset = "0x19E80E0", VA = "0x19E80E0", Slot = "65")]
    public virtual void ForceModifiedAnimation()
    {
    }

    [Token(Token = "0x600D4A7")]
    public abstract void PlayDefaultAnimation();

    [Token(Token = "0x600D4A8")]
    [Address(RVA = "0x19E80EC", Offset = "0x19E80EC", VA = "0x19E80EC")]
    private void UpdateAnimationIfModified()
    {
    }

    [Token(Token = "0x600D4A9")]
    [Address(RVA = "0x19E8124", Offset = "0x19E8124", VA = "0x19E8124", Slot = "67")]
    public virtual void UpdateUnitAlpha(float alpha)
    {
    }

    [Token(Token = "0x600D4AA")]
    [Address(RVA = "0x19E8128", Offset = "0x19E8128", VA = "0x19E8128", Slot = "68")]
    public virtual void ResetBadStatusShaderProperty()
    {
    }

    [Token(Token = "0x600D4AB")]
    [Address(RVA = "0x19E812C", Offset = "0x19E812C", VA = "0x19E812C", Slot = "69")]
    public virtual void UpdateUnitColor(Color color)
    {
    }

    [Token(Token = "0x600D4AC")]
    [Address(RVA = "0x19E8130", Offset = "0x19E8130", VA = "0x19E8130", Slot = "70")]
    public virtual void UpdateUnitMonochrome(float enable)
    {
    }

    [Token(Token = "0x600D4AD")]
    [Address(RVA = "0x19E8134", Offset = "0x19E8134", VA = "0x19E8134", Slot = "71")]
    public virtual void UpdateUnitHardlightBlend(float blend)
    {
    }

    [Token(Token = "0x600D4AE")]
    [Address(RVA = "0x19E8138", Offset = "0x19E8138", VA = "0x19E8138", Slot = "72")]
    public virtual void UpdateUnitHardlightColor(Color color)
    {
    }

    [Token(Token = "0x600D4AF")]
    [Address(RVA = "0x19E813C", Offset = "0x19E813C", VA = "0x19E813C", Slot = "73")]
    public virtual void ForceUpdateUnitMaterial()
    {
    }

    [Token(Token = "0x600D4B0")]
    [Address(RVA = "0x19E8140", Offset = "0x19E8140", VA = "0x19E8140", Slot = "74")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x600D4B1")]
    [Address(RVA = "0x19E8144", Offset = "0x19E8144", VA = "0x19E8144", Slot = "75")]
    protected virtual void OnUpdateMapViewCameraRotation(Quaternion quaternion)
    {
    }

    [Token(Token = "0x600D4B2")]
    [Address(RVA = "0x19E8238", Offset = "0x19E8238", VA = "0x19E8238")]
    public void TakeOverOtherUnitAnimation(Actor actor)
    {
    }

    [Token(Token = "0x600D4B3")]
    [Address(RVA = "0x19E835C", Offset = "0x19E835C", VA = "0x19E835C")]
    public void ShowDot()
    {
    }

    [Token(Token = "0x600D4B4")]
    [Address(RVA = "0x19E841C", Offset = "0x19E841C", VA = "0x19E841C")]
    public void HideDot()
    {
    }

    [Token(Token = "0x600D4B5")]
    [Address(RVA = "0x19E84DC", Offset = "0x19E84DC", VA = "0x19E84DC")]
    public void ChangeAnimationSpeed(float speed)
    {
    }

    [Token(Token = "0x600D4B6")]
    [Address(RVA = "0x19E8574", Offset = "0x19E8574", VA = "0x19E8574")]
    protected Actor()
    {
    }

    [Token(Token = "0x600D4B7")]
    [Address(RVA = "0x19E85C0", Offset = "0x19E85C0", VA = "0x19E85C0", Slot = "31")]
    private Transform Battle\u002EUnit\u002EIActor\u002Eget_transform() => (Transform) null;

    [Token(Token = "0x20022DA")]
    protected struct AnimationInfo
    {
      [Token(Token = "0x400934C")]
      [FieldOffset(Offset = "0x0")]
      public Actor.AnimationType type;
      [Token(Token = "0x400934D")]
      [FieldOffset(Offset = "0x4")]
      public Actor.Direction direction;
      [Token(Token = "0x400934E")]
      [FieldOffset(Offset = "0x8")]
      public bool needReset;

      [Token(Token = "0x600D4B8")]
      [Address(RVA = "0x19E85B4", Offset = "0x19E85B4", VA = "0x19E85B4")]
      public AnimationInfo(Actor.AnimationType type, Actor.Direction direction)
      {
      }
    }

    [Token(Token = "0x20022DB")]
    public enum AnimationType
    {
      [Token(Token = "0x4009350")] Idle,
      [Token(Token = "0x4009351")] Squat,
      [Token(Token = "0x4009352")] Move,
      [Token(Token = "0x4009353")] Attack,
      [Token(Token = "0x4009354")] Magic,
      [Token(Token = "0x4009355")] Buff,
      [Token(Token = "0x4009356")] Damage,
      [Token(Token = "0x4009357")] Down,
      [Token(Token = "0x4009358")] Win,
      [Token(Token = "0x4009359")] AttackTui,
      [Token(Token = "0x400935A")] SkillDf,
      [Token(Token = "0x400935B")] SkillFf,
      [Token(Token = "0x400935C")] AdvP01,
      [Token(Token = "0x400935D")] AdvP02,
    }

    [Token(Token = "0x20022DC")]
    public enum Direction
    {
      [Token(Token = "0x400935F")] Up,
      [Token(Token = "0x4009360")] Down,
      [Token(Token = "0x4009361")] Left,
      [Token(Token = "0x4009362")] Right,
    }
  }
}
