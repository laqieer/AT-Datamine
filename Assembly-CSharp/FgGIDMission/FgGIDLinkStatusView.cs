// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDLinkStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage.FgGID;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A0")]
  internal class FgGIDLinkStatusView : MonoBehaviour, ILinkStatusView
  {
    [Token(Token = "0x4006DFA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4006DFB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image linkStatusImage;
    [Token(Token = "0x4006DFC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite linkedSprite;
    [Token(Token = "0x4006DFD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Sprite notLinkedSprite;
    [Token(Token = "0x4006DFE")]
    [FieldOffset(Offset = "0x38")]
    private ILinkStatusPresenter presenter;

    [Token(Token = "0x17001788")]
    public ILinkStatusPresenter Presenter
    {
      [Token(Token = "0x600922F"), Address(RVA = "0x4D0F708", Offset = "0x4D0F708", VA = "0x4D0F708", Slot = "4")] set
      {
      }
    }

    [Token(Token = "0x6009230")]
    [Address(RVA = "0x4D0F7AC", Offset = "0x4D0F7AC", VA = "0x4D0F7AC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009231")]
    [Address(RVA = "0x4D0F840", Offset = "0x4D0F840", VA = "0x4D0F840")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009232")]
    [Address(RVA = "0x4D0F8EC", Offset = "0x4D0F8EC", VA = "0x4D0F8EC", Slot = "6")]
    public void SetIsLinked(bool isLinked)
    {
    }

    [Token(Token = "0x6009233")]
    [Address(RVA = "0x4D0F920", Offset = "0x4D0F920", VA = "0x4D0F920", Slot = "5")]
    public void SetUserDataIsValid(bool isValid)
    {
    }

    [Token(Token = "0x6009234")]
    [Address(RVA = "0x4D0F950", Offset = "0x4D0F950", VA = "0x4D0F950")]
    public FgGIDLinkStatusView()
    {
    }
  }
}
