// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoScoreAttackUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x200294E")]
  [AddComponentMenu("ScenarioQuestTopScoreAttackUI")]
  public class GotoScoreAttackUI : MonoBehaviour
  {
    [Token(Token = "0x400B00D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton btn;
    [Token(Token = "0x400B00E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector lockObj;
    [Token(Token = "0x400B00F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI textScore;
    [Token(Token = "0x400B010")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI textRank;
    [Token(Token = "0x400B011")]
    [FieldOffset(Offset = "0x38")]
    private bool isOpen;
    [Token(Token = "0x400B012")]
    [FieldOffset(Offset = "0x39")]
    private bool isNewOpen;
    [Token(Token = "0x400B014")]
    private const int WaitFrame = 20;

    [Token(Token = "0x14000149")]
    public event Action OnClick
    {
      [Token(Token = "0x60103D4"), Address(RVA = "0x475252C", Offset = "0x475252C", VA = "0x475252C")] add
      {
      }
      [Token(Token = "0x60103D5"), Address(RVA = "0x47525C8", Offset = "0x47525C8", VA = "0x47525C8")] remove
      {
      }
    }

    [Token(Token = "0x60103D6")]
    [Address(RVA = "0x4752664", Offset = "0x4752664", VA = "0x4752664")]
    public void Initialize(bool isOpen, bool isNewOpen, bool isActive)
    {
    }

    [Token(Token = "0x60103D7")]
    [Address(RVA = "0x4752798", Offset = "0x4752798", VA = "0x4752798")]
    public void SetPointText(int score, int rank)
    {
    }

    [Token(Token = "0x60103D8")]
    [Address(RVA = "0x475290C", Offset = "0x475290C", VA = "0x475290C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103D9")]
    [Address(RVA = "0x47526DC", Offset = "0x47526DC", VA = "0x47526DC")]
    private void SettingButtonColor()
    {
    }

    [Token(Token = "0x60103DA")]
    [Address(RVA = "0x4752708", Offset = "0x4752708", VA = "0x4752708")]
    private void SettingLockObject()
    {
    }

    [Token(Token = "0x60103DB")]
    [Address(RVA = "0x47529F8", Offset = "0x47529F8", VA = "0x47529F8")]
    private IEnumerator DelayButtonColorChange() => (IEnumerator) null;

    [Token(Token = "0x60103DC")]
    [Address(RVA = "0x4752A88", Offset = "0x4752A88", VA = "0x4752A88")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103DD")]
    [Address(RVA = "0x4752AA4", Offset = "0x4752AA4", VA = "0x4752AA4")]
    public GotoScoreAttackUI()
    {
    }
  }
}
