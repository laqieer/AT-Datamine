// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoSpecialBattleUI
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
  [Token(Token = "0x2002951")]
  [AddComponentMenu("ScenarioQuestTopSpecialBattleUI")]
  public class GotoSpecialBattleUI : MonoBehaviour
  {
    [Token(Token = "0x400B01C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton btn;
    [Token(Token = "0x400B01D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector lockObj;
    [Token(Token = "0x400B01E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject thirdLine;
    [Token(Token = "0x400B01F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject emptyObject;
    [Token(Token = "0x400B020")]
    [FieldOffset(Offset = "0x38")]
    private bool isOpen;
    [Token(Token = "0x400B021")]
    [FieldOffset(Offset = "0x39")]
    private bool isNewOpen;
    [Token(Token = "0x400B023")]
    private const int WaitFrame = 20;

    [Token(Token = "0x1400014A")]
    public event Action<bool> OnClick
    {
      [Token(Token = "0x60103E7"), Address(RVA = "0x4752CD8", Offset = "0x4752CD8", VA = "0x4752CD8")] add
      {
      }
      [Token(Token = "0x60103E8"), Address(RVA = "0x4752D88", Offset = "0x4752D88", VA = "0x4752D88")] remove
      {
      }
    }

    [Token(Token = "0x60103E9")]
    [Address(RVA = "0x4752E38", Offset = "0x4752E38", VA = "0x4752E38")]
    public void Initialize(bool isOpen, bool isNew, bool isActive)
    {
    }

    [Token(Token = "0x60103EA")]
    [Address(RVA = "0x4752F74", Offset = "0x4752F74", VA = "0x4752F74")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103EB")]
    [Address(RVA = "0x4752EB8", Offset = "0x4752EB8", VA = "0x4752EB8")]
    private void SettingButtonColor()
    {
    }

    [Token(Token = "0x60103EC")]
    [Address(RVA = "0x4752EE4", Offset = "0x4752EE4", VA = "0x4752EE4")]
    private void SettingLockObject()
    {
    }

    [Token(Token = "0x60103ED")]
    [Address(RVA = "0x4753060", Offset = "0x4753060", VA = "0x4753060")]
    private IEnumerator DelayButtonColorChange() => (IEnumerator) null;

    [Token(Token = "0x60103EE")]
    [Address(RVA = "0x47530F0", Offset = "0x47530F0", VA = "0x47530F0")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103EF")]
    [Address(RVA = "0x4753118", Offset = "0x4753118", VA = "0x4753118")]
    public GotoSpecialBattleUI()
    {
    }
  }
}
