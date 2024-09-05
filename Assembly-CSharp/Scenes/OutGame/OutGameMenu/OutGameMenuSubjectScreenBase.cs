// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuSubjectScreenBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A2C")]
  public class OutGameMenuSubjectScreenBase : MonoBehaviour
  {
    [Token(Token = "0x400FEB8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup rootCanvasGroup;
    [Token(Token = "0x400FEB9")]
    [FieldOffset(Offset = "0x20")]
    protected Transform childParentTransform;
    [Token(Token = "0x400FEBA")]
    [FieldOffset(Offset = "0x28")]
    public bool isDirection;
    [Token(Token = "0x400FEBB")]
    [FieldOffset(Offset = "0x29")]
    public bool isOperationPossible;
    [Token(Token = "0x400FEBC")]
    [FieldOffset(Offset = "0x30")]
    public OutGameMenuOperationPossible operationPossibleEvent;
    [Token(Token = "0x400FEBD")]
    [FieldOffset(Offset = "0x38")]
    public OutGameMenuOnBackScene onBackSceneEvent;
    [Token(Token = "0x400FEBE")]
    [FieldOffset(Offset = "0x40")]
    protected bool hasLeft;

    [Token(Token = "0x6016DC6")]
    [Address(RVA = "0x2C5B588", Offset = "0x2C5B588", VA = "0x2C5B588", Slot = "4")]
    public virtual void Initialize(ChangeSubjectScreenParameter param = null)
    {
    }

    [Token(Token = "0x6016DC7")]
    [Address(RVA = "0x2C5B58C", Offset = "0x2C5B58C", VA = "0x2C5B58C", Slot = "5")]
    public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016DC8")]
    [Address(RVA = "0x2C5B614", Offset = "0x2C5B614", VA = "0x2C5B614", Slot = "6")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x6016DC9")]
    [Address(RVA = "0x2C5B618", Offset = "0x2C5B618", VA = "0x2C5B618", Slot = "7")]
    public virtual void Open(OutGameMenuSubScene.OutGameMenuID id)
    {
    }

    [Token(Token = "0x6016DCA")]
    [Address(RVA = "0x2C5B61C", Offset = "0x2C5B61C", VA = "0x2C5B61C", Slot = "8")]
    public virtual void Close(OutGameMenuSubScene.OutGameMenuID id)
    {
    }

    [Token(Token = "0x6016DCB")]
    [Address(RVA = "0x2C5B620", Offset = "0x2C5B620", VA = "0x2C5B620", Slot = "9")]
    public virtual void OnBackSubScene()
    {
    }

    [Token(Token = "0x6016DCC")]
    [Address(RVA = "0x2C5B624", Offset = "0x2C5B624", VA = "0x2C5B624")]
    public void SetChildParentTransform(Transform parent)
    {
    }

    [Token(Token = "0x6016DCD")]
    [Address(RVA = "0x2C5B62C", Offset = "0x2C5B62C", VA = "0x2C5B62C")]
    public bool GetHasLeft() => new bool();

    [Token(Token = "0x6016DCE")]
    [Address(RVA = "0x2C5B634", Offset = "0x2C5B634", VA = "0x2C5B634")]
    public void SetCanvasEnabled(bool isEnabled)
    {
    }

    [Token(Token = "0x6016DCF")]
    [Address(RVA = "0x2C55AB8", Offset = "0x2C55AB8", VA = "0x2C55AB8")]
    public OutGameMenuSubjectScreenBase()
    {
    }
  }
}
