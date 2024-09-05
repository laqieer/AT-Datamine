// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamNameChangePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200082B")]
  public class TeamNameChangePopup : MonoBehaviour
  {
    [Token(Token = "0x40026E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40026E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x40026E2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x40026E3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TMP_InputField inputField;
    [Token(Token = "0x40026E4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI placeholder;
    [Token(Token = "0x40026E5")]
    [FieldOffset(Offset = "0x40")]
    private string inputText;
    [Token(Token = "0x40026E6")]
    [FieldOffset(Offset = "0x48")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x40026E7")]
    [FieldOffset(Offset = "0x50")]
    private Action closeAction;
    [Token(Token = "0x40026E8")]
    [FieldOffset(Offset = "0x58")]
    private bool isTeamEdit;
    [Token(Token = "0x40026E9")]
    [FieldOffset(Offset = "0x59")]
    private bool callAPI;
    [Token(Token = "0x40026EA")]
    [FieldOffset(Offset = "0x60")]
    private RichTextTagEraser tagEraser;

    [Token(Token = "0x170006ED")]
    private RichTextTagEraser TagEraser
    {
      [Token(Token = "0x6002F00"), Address(RVA = "0x3E6AEA0", Offset = "0x3E6AEA0", VA = "0x3E6AEA0")] get
      {
        return (RichTextTagEraser) null;
      }
    }

    [Token(Token = "0x6002F01")]
    [Address(RVA = "0x3E6AF3C", Offset = "0x3E6AF3C", VA = "0x3E6AF3C")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6002F02")]
    [Address(RVA = "0x3E6B0F0", Offset = "0x3E6B0F0", VA = "0x3E6B0F0")]
    public void SetData(Action closeAction, bool isTeamEdit)
    {
    }

    [Token(Token = "0x6002F03")]
    [Address(RVA = "0x3E6B100", Offset = "0x3E6B100", VA = "0x3E6B100")]
    private void OnDecisionButtonAction()
    {
    }

    [Token(Token = "0x6002F04")]
    [Address(RVA = "0x3E6B518", Offset = "0x3E6B518", VA = "0x3E6B518")]
    public void Open(OrganizationTeam team)
    {
    }

    [Token(Token = "0x6002F05")]
    [Address(RVA = "0x3E6B2F8", Offset = "0x3E6B2F8", VA = "0x3E6B2F8")]
    public void Close(Action closeAction)
    {
    }

    [Token(Token = "0x6002F06")]
    [Address(RVA = "0x3E6B674", Offset = "0x3E6B674", VA = "0x3E6B674")]
    public void OnValueChange()
    {
    }

    [Token(Token = "0x6002F07")]
    [Address(RVA = "0x3E6B698", Offset = "0x3E6B698", VA = "0x3E6B698")]
    public void OnEndEdit()
    {
    }

    [Token(Token = "0x6002F08")]
    [Address(RVA = "0x3E6B418", Offset = "0x3E6B418", VA = "0x3E6B418")]
    private void PalyAlert(string text)
    {
    }

    [Token(Token = "0x6002F09")]
    [Address(RVA = "0x3E6B49C", Offset = "0x3E6B49C", VA = "0x3E6B49C")]
    protected IEnumerator ConnectAPIDeckNameEdit(Action closeAction, string newName)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002F0A")]
    [Address(RVA = "0x3E6B6E0", Offset = "0x3E6B6E0", VA = "0x3E6B6E0")]
    public TeamNameChangePopup()
    {
    }

    [Token(Token = "0x200082C")]
    [Serializable]
    private class ErrorMessage : JsonSerializable
    {
      [Token(Token = "0x40026EB")]
      [FieldOffset(Offset = "0x10")]
      public string error_code;
      [Token(Token = "0x40026EC")]
      [FieldOffset(Offset = "0x18")]
      public List<string> args;

      [Token(Token = "0x6002F0E")]
      [Address(RVA = "0x3E6B7E4", Offset = "0x3E6B7E4", VA = "0x3E6B7E4")]
      public ErrorMessage()
      {
      }
    }
  }
}
