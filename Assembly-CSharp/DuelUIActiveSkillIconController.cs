// Decompiled with JetBrains decompiler
// Type: DuelUIActiveSkillIconController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000174")]
public class DuelUIActiveSkillIconController : MonoBehaviour
{
  [Token(Token = "0x4000950")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Transform skillIconRoot;
  [Token(Token = "0x4000951")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Text skillNameText;
  [Token(Token = "0x4000952")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private UITweenGroup iconTweenGroup;
  [Token(Token = "0x4000953")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private DuelUIGradientSwitcher _gradientSwitcher;
  [Token(Token = "0x4000954")]
  [FieldOffset(Offset = "0x38")]
  private float displayStartTime;
  [Token(Token = "0x4000955")]
  private const string TWEEN_GROUP_ID_ACTIVATESKILL_IN = "ActivateSkill_in";
  [Token(Token = "0x4000956")]
  private const string TWEEN_GROUP_ID_ACTIVATESKILL_OUT = "ActivateSkill_out";

  [Token(Token = "0x6000A1F")]
  [Address(RVA = "0x4BB26D0", Offset = "0x4BB26D0", VA = "0x4BB26D0")]
  public IEnumerator Initialize(
    string name,
    SkillData skill,
    int level,
    GameObject skillIconSubPrefabMini,
    ForceTypeEnum forceTypeEnum)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000A20")]
  [Address(RVA = "0x4BB2788", Offset = "0x4BB2788", VA = "0x4BB2788")]
  public void Show(float displayDuration)
  {
  }

  [Token(Token = "0x6000A21")]
  [Address(RVA = "0x4BB2828", Offset = "0x4BB2828", VA = "0x4BB2828")]
  private IEnumerator HideCoroutine(float displayDuration) => (IEnumerator) null;

  [Token(Token = "0x6000A22")]
  [Address(RVA = "0x4BB28C8", Offset = "0x4BB28C8", VA = "0x4BB28C8")]
  private IEnumerator DestroyCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000A23")]
  [Address(RVA = "0x4BB2958", Offset = "0x4BB2958", VA = "0x4BB2958")]
  public DuelUIActiveSkillIconController()
  {
  }
}
