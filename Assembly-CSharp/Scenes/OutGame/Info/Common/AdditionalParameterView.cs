// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.AdditionalParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Common
{
  [Token(Token = "0x20035CE")]
  public class AdditionalParameterView
  {
    [Token(Token = "0x400EA47")]
    [FieldOffset(Offset = "0x18")]
    private List<AdditionalParameterCategoryUI> instances;

    [Token(Token = "0x1700469D")]
    public AdditionalParametersUI AdditionalParametersUI
    {
      [Token(Token = "0x601532C"), Address(RVA = "0x4D89DCC", Offset = "0x4D89DCC", VA = "0x4D89DCC")] private get
      {
        return (AdditionalParametersUI) null;
      }
      [Token(Token = "0x601532D"), Address(RVA = "0x4D89DD4", Offset = "0x4D89DD4", VA = "0x4D89DD4")] set
      {
      }
    }

    [Token(Token = "0x601532E")]
    [Address(RVA = "0x4D89DDC", Offset = "0x4D89DDC", VA = "0x4D89DDC")]
    public AdditionalParameterCategoryUI GetInstance(int index)
    {
      return (AdditionalParameterCategoryUI) null;
    }

    [Token(Token = "0x601532F")]
    [Address(RVA = "0x4D86BB0", Offset = "0x4D86BB0", VA = "0x4D86BB0")]
    public AdditionalParameterCategoryUI CreateInstance() => (AdditionalParameterCategoryUI) null;

    [Token(Token = "0x6015330")]
    [Address(RVA = "0x4D89F50", Offset = "0x4D89F50", VA = "0x4D89F50")]
    public AdditionalParameterView()
    {
    }
  }
}
