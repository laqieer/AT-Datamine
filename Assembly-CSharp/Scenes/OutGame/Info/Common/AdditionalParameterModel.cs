// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.AdditionalParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Unit;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Info.Common
{
  [Token(Token = "0x20035C7")]
  public class AdditionalParameterModel : AdditionalParameterModelBase
  {
    [Token(Token = "0x60152B2")]
    [Address(RVA = "0x4D86FC4", Offset = "0x4D86FC4", VA = "0x4D86FC4")]
    public void Set(StyleData styleData)
    {
    }

    [Token(Token = "0x60152B3")]
    [Address(RVA = "0x4D87048", Offset = "0x4D87048", VA = "0x4D87048")]
    public void Set(Equipment equipmenet)
    {
    }

    [Token(Token = "0x60152B4")]
    [Address(RVA = "0x4D87064", Offset = "0x4D87064", VA = "0x4D87064")]
    public void Set(StyleData styleData, UnitModel unitModel, StyleParameter styleParam)
    {
    }

    [Token(Token = "0x60152B5")]
    [Address(RVA = "0x4D878EC", Offset = "0x4D878EC", VA = "0x4D878EC")]
    private void AddEquipmentValue(Equipment equipment)
    {
    }

    [Token(Token = "0x60152B6")]
    [Address(RVA = "0x4D88174", Offset = "0x4D88174", VA = "0x4D88174")]
    private void AddAbilityBoardValue(StyleParameter styleParam)
    {
    }

    [Token(Token = "0x60152B7")]
    [Address(RVA = "0x4D882B0", Offset = "0x4D882B0", VA = "0x4D882B0")]
    private void AddAdditionalParameter(
      AdditionalParameterType additionalParameter,
      ElementType element,
      int value)
    {
    }

    [Token(Token = "0x60152B8")]
    [Address(RVA = "0x4D883B0", Offset = "0x4D883B0", VA = "0x4D883B0")]
    private void Clear()
    {
    }

    [Token(Token = "0x60152B9")]
    [Address(RVA = "0x4D87258", Offset = "0x4D87258", VA = "0x4D87258")]
    private void DuplicateAdditionalParameter(AdditionalParameterList additionalParameterList)
    {
    }

    [Token(Token = "0x60152BA")]
    [Address(RVA = "0x4D884C4", Offset = "0x4D884C4", VA = "0x4D884C4")]
    public AdditionalParameterModel()
    {
    }
  }
}
