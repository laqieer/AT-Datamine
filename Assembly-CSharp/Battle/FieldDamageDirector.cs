// Decompiled with JetBrains decompiler
// Type: Battle.FieldDamageDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using Battle.Unit;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200226E")]
  public class FieldDamageDirector : MonoBehaviour, ISubDirector<IDirector>
  {
    [Token(Token = "0x4009121")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Vector3 UI_OFFSET;
    [Token(Token = "0x4009122")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FieldDamageTween fieldDamage;
    [Token(Token = "0x4009123")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SingleDirectionTween miss;
    [Token(Token = "0x4009124")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SingleDirectionTween weakness;
    [Token(Token = "0x4009125")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SingleDirectionTween critical;
    [Token(Token = "0x4009126")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SingleDirectionTween spGuard;
    [Token(Token = "0x4009127")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SingleDirectionTween spAttack;
    [Token(Token = "0x4009128")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SingleDirectionTween spHeal;
    [Token(Token = "0x4009129")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private FieldDamageDirection fieldDamageDirection;
    [Token(Token = "0x400912A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float uiScreenCoefficient;
    [Token(Token = "0x400912B")]
    [FieldOffset(Offset = "0x5C")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float currentDistanceCoefficient;
    [Token(Token = "0x400912D")]
    [FieldOffset(Offset = "0x68")]
    protected CameraDirector cameraDirector;
    [Token(Token = "0x400912E")]
    [FieldOffset(Offset = "0x70")]
    protected ActorDirector actorDirector;

    [Token(Token = "0x17002D71")]
    public bool Initialized
    {
      [Token(Token = "0x600D164"), Address(RVA = "0x1957768", Offset = "0x1957768", VA = "0x1957768", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D165"), Address(RVA = "0x1957770", Offset = "0x1957770", VA = "0x1957770")] protected set
      {
      }
    }

    [Token(Token = "0x17002D72")]
    public virtual bool IsPlayingAny
    {
      [Token(Token = "0x600D166"), Address(RVA = "0x195777C", Offset = "0x195777C", VA = "0x195777C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002D73")]
    public bool IsVisibleFieldDamage
    {
      [Token(Token = "0x600D167"), Address(RVA = "0x19579A4", Offset = "0x19579A4", VA = "0x19579A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D168"), Address(RVA = "0x19579AC", Offset = "0x19579AC", VA = "0x19579AC")] set
      {
      }
    }

    [Token(Token = "0x600D169")]
    [Address(RVA = "0x19579B8", Offset = "0x19579B8", VA = "0x19579B8", Slot = "9")]
    public virtual void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D16A")]
    [Address(RVA = "0x1957A84", Offset = "0x1957A84", VA = "0x1957A84", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D16B")]
    [Address(RVA = "0x1957A90", Offset = "0x1957A90", VA = "0x1957A90", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D16C")]
    [Address(RVA = "0x1957A9C", Offset = "0x1957A9C", VA = "0x1957A9C", Slot = "10")]
    public virtual void StopAll()
    {
    }

    [Token(Token = "0x600D16D")]
    [Address(RVA = "0x1957B0C", Offset = "0x1957B0C", VA = "0x1957B0C")]
    public void HideAll()
    {
    }

    [Token(Token = "0x600D16E")]
    [Address(RVA = "0x1957B6C", Offset = "0x1957B6C", VA = "0x1957B6C", Slot = "11")]
    public virtual void PlayDamage(
      int damageValue,
      bool isCritical,
      bool isWeakness,
      CharacterActor actor)
    {
    }

    [Token(Token = "0x600D16F")]
    [Address(RVA = "0x1957BD4", Offset = "0x1957BD4", VA = "0x1957BD4")]
    public void PlayDamage(int damageValue, bool isCritical, bool isWeakness, Vector3 worldPos)
    {
    }

    [Token(Token = "0x600D170")]
    [Address(RVA = "0x1957DA4", Offset = "0x1957DA4", VA = "0x1957DA4", Slot = "12")]
    public virtual void PlayHealing(int healingValue, CharacterActor actor)
    {
    }

    [Token(Token = "0x600D171")]
    [Address(RVA = "0x1957DD0", Offset = "0x1957DD0", VA = "0x1957DD0")]
    public void PlayHealing(int healingValue, Vector3 worldPos)
    {
    }

    [Token(Token = "0x600D172")]
    [Address(RVA = "0x1957E1C", Offset = "0x1957E1C", VA = "0x1957E1C", Slot = "13")]
    public virtual void PlayMiss(CharacterActor actor)
    {
    }

    [Token(Token = "0x600D173")]
    [Address(RVA = "0x1957E34", Offset = "0x1957E34", VA = "0x1957E34")]
    public void PlayMiss(Vector3 worldPos)
    {
    }

    [Token(Token = "0x600D174")]
    [Address(RVA = "0x1957E70", Offset = "0x1957E70", VA = "0x1957E70")]
    public void PlaySupportTween(CharacterActor actor, string tweenName)
    {
    }

    [Token(Token = "0x600D175")]
    [Address(RVA = "0x1957BA4", Offset = "0x1957BA4", VA = "0x1957BA4")]
    protected Vector3 CalcOffsetPosition(CharacterActor actor) => new Vector3();

    [Token(Token = "0x600D176")]
    [Address(RVA = "0x1957C24", Offset = "0x1957C24", VA = "0x1957C24")]
    protected Vector3 CalcWorldToUILocalPoint(Vector3 worldPos) => new Vector3();

    [Token(Token = "0x600D177")]
    [Address(RVA = "0x1957EAC", Offset = "0x1957EAC", VA = "0x1957EAC")]
    public FieldDamageDirector()
    {
    }

    [Token(Token = "0x600D178")]
    [Address(RVA = "0x1957EC4", Offset = "0x1957EC4", VA = "0x1957EC4")]
    static FieldDamageDirector()
    {
    }
  }
}
