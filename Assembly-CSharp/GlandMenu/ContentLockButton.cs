// Decompiled with JetBrains decompiler
// Type: GlandMenu.ContentLockButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x2000950")]
  public class ContentLockButton : MonoBehaviour
  {
    [Token(Token = "0x4002B2A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentLockController.LockIconType targetType;
    [Token(Token = "0x4002B2B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Animator showingEnableAnim;
    [Token(Token = "0x4002B2C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject showingEffectObj;
    [Token(Token = "0x4002B2D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayableDirector unlockAnim;
    [Token(Token = "0x4002B2E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayableDirector unlockResetAnim;
    [Token(Token = "0x4002B2F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject disableButton;
    [Token(Token = "0x4002B30")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject lockIcon;
    [Token(Token = "0x4002B31")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4002B32")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI text;
    [Token(Token = "0x4002B33")]
    [FieldOffset(Offset = "0x60")]
    private bool isUnlockEffectEnd;

    [Token(Token = "0x17000767")]
    public ContentLockController.LockIconType TargetType
    {
      [Token(Token = "0x600347F"), Address(RVA = "0x3632390", Offset = "0x3632390", VA = "0x3632390")] get
      {
        return new ContentLockController.LockIconType();
      }
    }

    [Token(Token = "0x17000768")]
    public bool IsLock
    {
      [Token(Token = "0x6003480"), Address(RVA = "0x3632398", Offset = "0x3632398", VA = "0x3632398")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003481"), Address(RVA = "0x3632608", Offset = "0x3632608", VA = "0x3632608")] set
      {
      }
    }

    [Token(Token = "0x6003482")]
    [Address(RVA = "0x363239C", Offset = "0x363239C", VA = "0x363239C")]
    private bool GetLockFlg() => new bool();

    [Token(Token = "0x6003483")]
    [Address(RVA = "0x3632610", Offset = "0x3632610", VA = "0x3632610")]
    private void SetLockFlf(bool isFlg)
    {
    }

    [Token(Token = "0x6003484")]
    [Address(RVA = "0x3632B28", Offset = "0x3632B28", VA = "0x3632B28")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6003485")]
    [Address(RVA = "0x3632CB4", Offset = "0x3632CB4", VA = "0x3632CB4")]
    public IEnumerator PlayEffect() => (IEnumerator) null;

    [Token(Token = "0x6003486")]
    [Address(RVA = "0x3632D44", Offset = "0x3632D44", VA = "0x3632D44")]
    public void OnFinishUnlockEffect()
    {
    }

    [Token(Token = "0x6003487")]
    [Address(RVA = "0x363307C", Offset = "0x363307C", VA = "0x363307C")]
    public IEnumerator PlayUnlockViewToaster() => (IEnumerator) null;

    [Token(Token = "0x6003488")]
    [Address(RVA = "0x363310C", Offset = "0x363310C", VA = "0x363310C")]
    public void OnFinishUnlockEffectNext()
    {
    }

    [Token(Token = "0x6003489")]
    [Address(RVA = "0x3632E14", Offset = "0x3632E14", VA = "0x3632E14")]
    private void UnlockViewToaster(Action onFinishCallback)
    {
    }

    [Token(Token = "0x600348A")]
    [Address(RVA = "0x3633194", Offset = "0x3633194", VA = "0x3633194")]
    public void OnClickToLockingAction()
    {
    }

    [Token(Token = "0x600348B")]
    [Address(RVA = "0x36335B4", Offset = "0x36335B4", VA = "0x36335B4")]
    private void ShowToaster(string message, Action callback)
    {
    }

    [Token(Token = "0x600348C")]
    [Address(RVA = "0x3633614", Offset = "0x3633614", VA = "0x3633614")]
    private void ShowToaster(string title, string message, Action callback)
    {
    }

    [Token(Token = "0x600348D")]
    [Address(RVA = "0x36336E4", Offset = "0x36336E4", VA = "0x36336E4")]
    public bool UnlockCheck() => new bool();

    [Token(Token = "0x600348E")]
    [Address(RVA = "0x3633728", Offset = "0x3633728", VA = "0x3633728")]
    private bool IsUnlockEvent() => new bool();

    [Token(Token = "0x600348F")]
    [Address(RVA = "0x36337D0", Offset = "0x36337D0", VA = "0x36337D0")]
    private bool IsUnlockGuild() => new bool();

    [Token(Token = "0x6003490")]
    [Address(RVA = "0x36338BC", Offset = "0x36338BC", VA = "0x36338BC")]
    private bool IsUnlockArena() => new bool();

    [Token(Token = "0x6003491")]
    [Address(RVA = "0x3633A00", Offset = "0x3633A00", VA = "0x3633A00")]
    private bool IsUnlockChart() => new bool();

    [Token(Token = "0x6003492")]
    [Address(RVA = "0x3633A08", Offset = "0x3633A08", VA = "0x3633A08")]
    private bool IsUnlockStoryShop() => new bool();

    [Token(Token = "0x6003493")]
    [Address(RVA = "0x3633F24", Offset = "0x3633F24", VA = "0x3633F24")]
    private bool IsUnlockMain() => new bool();

    [Token(Token = "0x6003494")]
    [Address(RVA = "0x3634010", Offset = "0x3634010", VA = "0x3634010")]
    private bool IsUnlockMain2() => new bool();

    [Token(Token = "0x6003495")]
    [Address(RVA = "0x36344CC", Offset = "0x36344CC", VA = "0x36344CC")]
    public void SetLockType(ContentLockController.LockIconType lockIconType)
    {
    }

    [Token(Token = "0x6003496")]
    [Address(RVA = "0x36340C0", Offset = "0x36340C0", VA = "0x36340C0")]
    private bool IsOpenArena() => new bool();

    [Token(Token = "0x6003497")]
    [Address(RVA = "0x36344D4", Offset = "0x36344D4", VA = "0x36344D4")]
    public ContentLockButton()
    {
    }
  }
}
