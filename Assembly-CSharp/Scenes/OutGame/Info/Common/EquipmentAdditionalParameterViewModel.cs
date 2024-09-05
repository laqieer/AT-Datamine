// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.EquipmentAdditionalParameterViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Info.Common
{
  [Token(Token = "0x20035C5")]
  public class EquipmentAdditionalParameterViewModel
  {
    [Token(Token = "0x1700465C")]
    public AdditionalParameterView View
    {
      [Token(Token = "0x60152A1"), Address(RVA = "0x4D86938", Offset = "0x4D86938", VA = "0x4D86938")] get
      {
        return (AdditionalParameterView) null;
      }
      [Token(Token = "0x60152A2"), Address(RVA = "0x4D86940", Offset = "0x4D86940", VA = "0x4D86940")] private set
      {
      }
    }

    [Token(Token = "0x1700465D")]
    public AdditionalParameterModel Model
    {
      [Token(Token = "0x60152A3"), Address(RVA = "0x4D86948", Offset = "0x4D86948", VA = "0x4D86948")] get
      {
        return (AdditionalParameterModel) null;
      }
      [Token(Token = "0x60152A4"), Address(RVA = "0x4D86950", Offset = "0x4D86950", VA = "0x4D86950")] private set
      {
      }
    }

    [Token(Token = "0x60152A5")]
    [Address(RVA = "0x4D86958", Offset = "0x4D86958", VA = "0x4D86958")]
    public void Set(AdditionalParameterModel model, AdditionalParameterView view)
    {
    }

    [Token(Token = "0x60152A6")]
    [Address(RVA = "0x4D86960", Offset = "0x4D86960", VA = "0x4D86960")]
    public void OnChange()
    {
    }

    [Token(Token = "0x60152A7")]
    [Address(RVA = "0x4D86998", Offset = "0x4D86998", VA = "0x4D86998")]
    private static void SetAdditionalParameters(
      AdditionalParameterView view,
      AdditionalParameterType additionalParameterType)
    {
    }

    [Token(Token = "0x60152A8")]
    [Address(RVA = "0x4D86E04", Offset = "0x4D86E04", VA = "0x4D86E04")]
    public EquipmentAdditionalParameterViewModel()
    {
    }
  }
}
