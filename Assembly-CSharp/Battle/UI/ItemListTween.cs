// Decompiled with JetBrains decompiler
// Type: Battle.UI.ItemListTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023E6")]
  [RequireComponent(typeof (UITweenGroup))]
  public class ItemListTween : TweenWrapper
  {
    [Token(Token = "0x4009948")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private string showListName;
    [Token(Token = "0x4009949")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    private string hideListName;
    [Token(Token = "0x400994A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HideInInspector]
    private string showConfirmName;
    [Token(Token = "0x400994B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HideInInspector]
    private string hideConfirmName;

    [Token(Token = "0x600DBFF")]
    [Address(RVA = "0x2152E2C", Offset = "0x2152E2C", VA = "0x2152E2C")]
    public void Show(bool asap = false)
    {
    }

    [Token(Token = "0x600DC00")]
    [Address(RVA = "0x2152EE0", Offset = "0x2152EE0", VA = "0x2152EE0")]
    public void Hide(bool asap = false)
    {
    }

    [Token(Token = "0x600DC01")]
    [Address(RVA = "0x2152F94", Offset = "0x2152F94", VA = "0x2152F94")]
    public void ShowConfirm(bool asap = false)
    {
    }

    [Token(Token = "0x600DC02")]
    [Address(RVA = "0x2153048", Offset = "0x2153048", VA = "0x2153048")]
    public void HideConfirm(bool asap = false)
    {
    }

    [Token(Token = "0x600DC03")]
    [Address(RVA = "0x21530FC", Offset = "0x21530FC", VA = "0x21530FC", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600DC04")]
    [Address(RVA = "0x2153100", Offset = "0x2153100", VA = "0x2153100")]
    public ItemListTween()
    {
    }
  }
}
