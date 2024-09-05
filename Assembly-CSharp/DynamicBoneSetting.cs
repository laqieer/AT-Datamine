// Decompiled with JetBrains decompiler
// Type: DynamicBoneSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E1")]
public class DynamicBoneSetting
{
  [Token(Token = "0x40003F4")]
  [FieldOffset(Offset = "0x10")]
  private Vector3 environmentalDirection;
  [Token(Token = "0x40003F5")]
  [FieldOffset(Offset = "0x1C")]
  private float environmentalPower;
  [Token(Token = "0x40003F6")]
  [FieldOffset(Offset = "0x20")]
  private float environmentalFluctuationPower;
  [Token(Token = "0x40003F7")]
  [FieldOffset(Offset = "0x24")]
  private float environmentalFluctuationfrequency;
  [Token(Token = "0x40003F8")]
  [FieldOffset(Offset = "0x28")]
  private float ellipseTime;
  [Token(Token = "0x40003F9")]
  [FieldOffset(Offset = "0x2C")]
  private float impulseTime;
  [Token(Token = "0x40003FA")]
  [FieldOffset(Offset = "0x30")]
  private float impulseEellipseTime;
  [Token(Token = "0x40003FB")]
  [FieldOffset(Offset = "0x34")]
  private float fadeTime;
  [Token(Token = "0x40003FC")]
  [FieldOffset(Offset = "0x38")]
  private Vector3 impulsePower;
  [Token(Token = "0x40003FD")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 circularSpreadCenter;
  [Token(Token = "0x40003FE")]
  [FieldOffset(Offset = "0x50")]
  private float circularSpreadPower;
  [Token(Token = "0x40003FF")]
  [FieldOffset(Offset = "0x54")]
  private DynamicBoneSetting.WindMode windMode;
  [Token(Token = "0x4000400")]
  [FieldOffset(Offset = "0x58")]
  public Dictionary<string, DynamicBoneSetting.Parameter> dynamicBones;
  [Token(Token = "0x4000401")]
  [FieldOffset(Offset = "0x60")]
  private bool enable_all;

  [Token(Token = "0x17000064")]
  public bool enabled
  {
    [Token(Token = "0x6000688"), Address(RVA = "0x4184A9C", Offset = "0x4184A9C", VA = "0x4184A9C")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000689"), Address(RVA = "0x4184AA4", Offset = "0x4184AA4", VA = "0x4184AA4")] set
    {
    }
  }

  [Token(Token = "0x600068A")]
  [Address(RVA = "0x4184C28", Offset = "0x4184C28", VA = "0x4184C28")]
  private void FullName(StringBuilder sb, Transform obj)
  {
  }

  [Token(Token = "0x600068B")]
  [Address(RVA = "0x4184D28", Offset = "0x4184D28", VA = "0x4184D28")]
  private string FullName(Transform transform) => (string) null;

  [Token(Token = "0x600068C")]
  [Address(RVA = "0x4184DAC", Offset = "0x4184DAC", VA = "0x4184DAC")]
  public void AddDynamicBone(Transform transform, DynamicBone dynamicBone)
  {
  }

  [Token(Token = "0x600068D")]
  [Address(RVA = "0x4184EFC", Offset = "0x4184EFC", VA = "0x4184EFC")]
  private void TraverseHierarchy(Transform transform)
  {
  }

  [Token(Token = "0x600068E")]
  [Address(RVA = "0x4184FF0", Offset = "0x4184FF0", VA = "0x4184FF0")]
  public void AddCharacter(GameObject character)
  {
  }

  [Token(Token = "0x600068F")]
  [Address(RVA = "0x418508C", Offset = "0x418508C", VA = "0x418508C")]
  public void UnlinkAll()
  {
  }

  [Token(Token = "0x6000690")]
  [Address(RVA = "0x41850DC", Offset = "0x41850DC", VA = "0x41850DC")]
  public void ApplyGravity(Vector3 gravity)
  {
  }

  [Token(Token = "0x6000691")]
  [Address(RVA = "0x4185260", Offset = "0x4185260", VA = "0x4185260")]
  public void ApplyForce(Vector3 force)
  {
  }

  [Token(Token = "0x6000692")]
  [Address(RVA = "0x41853E4", Offset = "0x41853E4", VA = "0x41853E4")]
  public void SetEnvironmentalWind(
    Vector3 direction,
    float power,
    float fluctuationPower,
    float fluctuationfrequency)
  {
  }

  [Token(Token = "0x6000693")]
  [Address(RVA = "0x4185420", Offset = "0x4185420", VA = "0x4185420")]
  public void SetImpulseWind(Vector3 direction, float power, float time)
  {
  }

  [Token(Token = "0x6000694")]
  [Address(RVA = "0x4185470", Offset = "0x4185470", VA = "0x4185470")]
  public void SetCircularSpreadWind(Vector3 center, float power, float time)
  {
  }

  [Token(Token = "0x6000695")]
  [Address(RVA = "0x4185498", Offset = "0x4185498", VA = "0x4185498")]
  public void SetFadeTime(float time)
  {
  }

  [Token(Token = "0x6000696")]
  [Address(RVA = "0x41854A0", Offset = "0x41854A0", VA = "0x41854A0")]
  public Vector3 CalcFluctuation() => new Vector3();

  [Token(Token = "0x6000697")]
  [Address(RVA = "0x41856C4", Offset = "0x41856C4", VA = "0x41856C4")]
  private Vector3 CalcEnvironmentalWind() => new Vector3();

  [Token(Token = "0x6000698")]
  [Address(RVA = "0x4185720", Offset = "0x4185720", VA = "0x4185720")]
  private void ApplyImpulseWind()
  {
  }

  [Token(Token = "0x6000699")]
  [Address(RVA = "0x41857FC", Offset = "0x41857FC", VA = "0x41857FC")]
  private void ApplyCircularSpreadWind()
  {
  }

  [Token(Token = "0x600069A")]
  [Address(RVA = "0x4185B38", Offset = "0x4185B38", VA = "0x4185B38")]
  public void UpdateWind()
  {
  }

  [Token(Token = "0x600069B")]
  [Address(RVA = "0x4185B90", Offset = "0x4185B90", VA = "0x4185B90")]
  public DynamicBoneSetting()
  {
  }

  [Token(Token = "0x20000E2")]
  private enum WindMode
  {
    [Token(Token = "0x4000403")] None,
    [Token(Token = "0x4000404")] Environmental,
    [Token(Token = "0x4000405")] Impulse,
    [Token(Token = "0x4000406")] CircularSpread,
  }

  [Token(Token = "0x20000E3")]
  public class Parameter
  {
    [Token(Token = "0x4000407")]
    [FieldOffset(Offset = "0x10")]
    public Transform transform;
    [Token(Token = "0x4000408")]
    [FieldOffset(Offset = "0x18")]
    public DynamicBone dynamicBone;

    [Token(Token = "0x600069C")]
    [Address(RVA = "0x4184ED0", Offset = "0x4184ED0", VA = "0x4184ED0")]
    public Parameter(Transform transform, DynamicBone dynamicBone)
    {
    }
  }
}
