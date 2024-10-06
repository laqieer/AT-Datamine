// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.EnvironmentPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000989")]
  public class EnvironmentPanelController
  {
    [Token(Token = "0x4002C5C")]
    [FieldOffset(Offset = "0x10")]
    private readonly TextField _environmentIdTextField;
    [Token(Token = "0x4002C5D")]
    [FieldOffset(Offset = "0x18")]
    private readonly DropdownField _environmentIdDropDown;
    [Token(Token = "0x4002C5E")]
    [FieldOffset(Offset = "0x20")]
    private readonly Toggle _enableObliviaeBgToggle;
    [Token(Token = "0x4002C5F")]
    [FieldOffset(Offset = "0x28")]
    private readonly DropdownField _obliviaeBgEnumDropDown;
    [Token(Token = "0x4002C60")]
    [FieldOffset(Offset = "0x30")]
    private readonly DuelDebugDataContainer _dataContainer;
    [Token(Token = "0x4002C61")]
    [FieldOffset(Offset = "0x38")]
    private readonly VisualElement _instance;
    [Token(Token = "0x4002C62")]
    [FieldOffset(Offset = "0x40")]
    private List<string> sceneNameList;

    [Token(Token = "0x6003634")]
    [Address(RVA = "0x353441C", Offset = "0x353441C", VA = "0x353441C")]
    public void Show()
    {
    }

    [Token(Token = "0x6003635")]
    [Address(RVA = "0x353301C", Offset = "0x353301C", VA = "0x353301C")]
    public void Hide()
    {
    }

    [Token(Token = "0x6003636")]
    [Address(RVA = "0x3532B60", Offset = "0x3532B60", VA = "0x3532B60")]
    public EnvironmentPanelController(
      DuelDebugDataContainer dataContainer,
      VisualElement visualElement)
    {
    }

    [Token(Token = "0x6003637")]
    [Address(RVA = "0x35344F8", Offset = "0x35344F8", VA = "0x35344F8")]
    public void CollectSceneNames()
    {
    }

    [Token(Token = "0x6003638")]
    [Address(RVA = "0x3534654", Offset = "0x3534654", VA = "0x3534654")]
    private void InitializeDropDown(DropdownField dropdownField, List<string> options)
    {
    }

    [Token(Token = "0x6003639")]
    [Address(RVA = "0x3534680", Offset = "0x3534680", VA = "0x3534680")]
    private void InitializeDropDown(DropdownField dropDown, System.Type enumType)
    {
    }

    [Token(Token = "0x600363A")]
    [Address(RVA = "0x3534720", Offset = "0x3534720", VA = "0x3534720")]
    public void SyncToDataContainer()
    {
    }
  }
}
