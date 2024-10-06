// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoFreeBattleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x2002949")]
  [AddComponentMenu("ScenarioQuestTopFreeBattleUI")]
  public class GotoFreeBattleUI : MonoBehaviour
  {
    [Token(Token = "0x400AFFB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton btn;
    [Token(Token = "0x400AFFC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector lockObj;
    [Token(Token = "0x400AFFD")]
    [FieldOffset(Offset = "0x28")]
    private bool isOpen;
    [Token(Token = "0x400AFFE")]
    [FieldOffset(Offset = "0x29")]
    private bool isNewOpen;
    [Token(Token = "0x400B000")]
    private const int WaitFrame = 20;

    [Token(Token = "0x14000147")]
    public event Action<bool> OnClick
    {
      [Token(Token = "0x60103B9"), Address(RVA = "0x4751B50", Offset = "0x4751B50", VA = "0x4751B50")] add
      {
      }
      [Token(Token = "0x60103BA"), Address(RVA = "0x4751C00", Offset = "0x4751C00", VA = "0x4751C00")] remove
      {
      }
    }

    [Token(Token = "0x60103BB")]
    [Address(RVA = "0x4751CB0", Offset = "0x4751CB0", VA = "0x4751CB0")]
    public void Initialize(bool isOpen, bool isNew)
    {
    }

    [Token(Token = "0x60103BC")]
    [Address(RVA = "0x4751DA0", Offset = "0x4751DA0", VA = "0x4751DA0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103BD")]
    [Address(RVA = "0x4751CD8", Offset = "0x4751CD8", VA = "0x4751CD8")]
    private void SettingButtonColor()
    {
    }

    [Token(Token = "0x60103BE")]
    [Address(RVA = "0x4751D18", Offset = "0x4751D18", VA = "0x4751D18")]
    private void SettingLockObject()
    {
    }

    [Token(Token = "0x60103BF")]
    [Address(RVA = "0x4751E8C", Offset = "0x4751E8C", VA = "0x4751E8C")]
    private IEnumerator DelayButtonColorChange() => (IEnumerator) null;

    [Token(Token = "0x60103C0")]
    [Address(RVA = "0x4751F1C", Offset = "0x4751F1C", VA = "0x4751F1C")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103C1")]
    [Address(RVA = "0x4751F3C", Offset = "0x4751F3C", VA = "0x4751F3C")]
    public GotoFreeBattleUI()
    {
    }
  }
}
