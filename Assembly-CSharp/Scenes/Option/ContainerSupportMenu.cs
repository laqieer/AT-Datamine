// Decompiled with JetBrains decompiler
// Type: Scenes.Option.ContainerSupportMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Option
{
  [Token(Token = "0x2002A69")]
  public class ContainerSupportMenu : MonoBehaviour
  {
    [Token(Token = "0x400B48A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button buttonOfficialSite;
    [Token(Token = "0x400B48B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button buttonHelp;
    [Token(Token = "0x400B48C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button buttonContact;
    [Token(Token = "0x400B48D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button buttonDeleteAccount;
    [Token(Token = "0x400B48E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button buttonAccountRecreate;
    [Token(Token = "0x400B48F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<GameObject> objectsDisableIfDmm;

    [Token(Token = "0x60109B0")]
    [Address(RVA = "0x4C323D4", Offset = "0x4C323D4", VA = "0x4C323D4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60109B1")]
    [Address(RVA = "0x4C325C4", Offset = "0x4C325C4", VA = "0x4C325C4")]
    private void OpenHTMLViewer(string title, string url)
    {
    }

    [Token(Token = "0x60109B2")]
    [Address(RVA = "0x4C3280C", Offset = "0x4C3280C", VA = "0x4C3280C")]
    public void OnOpenOfficialSite()
    {
    }

    [Token(Token = "0x60109B3")]
    [Address(RVA = "0x4C32890", Offset = "0x4C32890", VA = "0x4C32890")]
    public void OnOpenHelp()
    {
    }

    [Token(Token = "0x60109B4")]
    [Address(RVA = "0x4C32914", Offset = "0x4C32914", VA = "0x4C32914")]
    public void OnOpenContact()
    {
    }

    [Token(Token = "0x60109B5")]
    [Address(RVA = "0x4C32BC4", Offset = "0x4C32BC4", VA = "0x4C32BC4")]
    public void OnOpenDeleteAccount()
    {
    }

    [Token(Token = "0x60109B6")]
    [Address(RVA = "0x4C32C24", Offset = "0x4C32C24", VA = "0x4C32C24")]
    public void OnOpenAccountRecreate()
    {
    }

    [Token(Token = "0x60109B7")]
    [Address(RVA = "0x4C325C0", Offset = "0x4C325C0", VA = "0x4C325C0")]
    private void DisableGameObjectsIfDmm()
    {
    }

    [Token(Token = "0x60109B8")]
    [Address(RVA = "0x4C32C84", Offset = "0x4C32C84", VA = "0x4C32C84")]
    public ContainerSupportMenu()
    {
    }
  }
}
