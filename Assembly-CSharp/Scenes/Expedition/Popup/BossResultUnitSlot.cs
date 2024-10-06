// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.BossResultUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C56")]
  public class BossResultUnitSlot : MonoBehaviour
  {
    [Token(Token = "0x400BCD9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400BCDA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject pararaUpObj;
    [Token(Token = "0x400BCDB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI pararaUp00Text;
    [Token(Token = "0x400BCDC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Animator pararaUp00Anim;
    [Token(Token = "0x400BCDD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI pararaUp01Text;
    [Token(Token = "0x400BCDE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Animator pararaUp01Anim;
    [Token(Token = "0x400BCDF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400BCE0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float pararaAnimLoopWaitTime;
    [Token(Token = "0x400BCE1")]
    [FieldOffset(Offset = "0x58")]
    private List<string> pararaUpTextList;
    [Token(Token = "0x400BCE2")]
    [FieldOffset(Offset = "0x60")]
    private int pararaLoopIndex;
    [Token(Token = "0x400BCE3")]
    [FieldOffset(Offset = "0x64")]
    private bool isLoop;
    [Token(Token = "0x400BCE4")]
    [FieldOffset(Offset = "0x65")]
    private bool isLoopStop00;
    [Token(Token = "0x400BCE5")]
    [FieldOffset(Offset = "0x66")]
    private bool isLoopStop01;

    [Token(Token = "0x60115D6")]
    [Address(RVA = "0x4E1989C", Offset = "0x4E1989C", VA = "0x4E1989C")]
    public void Initialized(
      PlayerUnitCharacterType beforeUnitChara,
      Style afterUnit,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60115D7")]
    [Address(RVA = "0x4E19DAC", Offset = "0x4E19DAC", VA = "0x4E19DAC")]
    private void EmptySlot()
    {
    }

    [Token(Token = "0x60115D8")]
    [Address(RVA = "0x4E19F40", Offset = "0x4E19F40", VA = "0x4E19F40")]
    public void CallSignalReceiverAction00()
    {
    }

    [Token(Token = "0x60115D9")]
    [Address(RVA = "0x4E1A0D4", Offset = "0x4E1A0D4", VA = "0x4E1A0D4")]
    public void CallSignalReceiverAction01()
    {
    }

    [Token(Token = "0x60115DA")]
    [Address(RVA = "0x4E19E28", Offset = "0x4E19E28", VA = "0x4E19E28")]
    private void CheckPararaUp(int value01, int value02, string text)
    {
    }

    [Token(Token = "0x60115DB")]
    [Address(RVA = "0x4E1A06C", Offset = "0x4E1A06C", VA = "0x4E1A06C")]
    private IEnumerator WaitLoopAnim00() => (IEnumerator) null;

    [Token(Token = "0x60115DC")]
    [Address(RVA = "0x4E1A200", Offset = "0x4E1A200", VA = "0x4E1A200")]
    private IEnumerator WaitLoopAnim01() => (IEnumerator) null;

    [Token(Token = "0x60115DD")]
    [Address(RVA = "0x4E1A2B8", Offset = "0x4E1A2B8", VA = "0x4E1A2B8")]
    public BossResultUnitSlot()
    {
    }
  }
}
