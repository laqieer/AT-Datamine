// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.ParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Common
{
  [Token(Token = "0x20035CF")]
  public class ParameterView
  {
    [Token(Token = "0x400EA48")]
    private const string RangeParamLabel = "range";
    [Token(Token = "0x400EA4A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, ParameterValueTypeNumeric> numericDic;

    [Token(Token = "0x1700469E")]
    public EquipmentParametersUI ParametersUI
    {
      [Token(Token = "0x6015331"), Address(RVA = "0x4D89FCC", Offset = "0x4D89FCC", VA = "0x4D89FCC")] private get
      {
        return (EquipmentParametersUI) null;
      }
      [Token(Token = "0x6015332"), Address(RVA = "0x4D89FD4", Offset = "0x4D89FD4", VA = "0x4D89FD4")] set
      {
      }
    }

    [Token(Token = "0x6015333")]
    [Address(RVA = "0x4D89FDC", Offset = "0x4D89FDC", VA = "0x4D89FDC")]
    public void AddValueParameter(string name, int value)
    {
    }

    [Token(Token = "0x6015334")]
    [Address(RVA = "0x4D8A168", Offset = "0x4D8A168", VA = "0x4D8A168")]
    public void AddPercentParameter(string name, float value)
    {
    }

    [Token(Token = "0x6015335")]
    [Address(RVA = "0x4D8A248", Offset = "0x4D8A248", VA = "0x4D8A248")]
    public void AddRangeparameter(int min, int max, int rangeTypeID)
    {
    }

    [Token(Token = "0x6015336")]
    [Address(RVA = "0x4D8A0B4", Offset = "0x4D8A0B4", VA = "0x4D8A0B4")]
    private ParameterValueTypeNumeric GetNumericInstance(string key)
    {
      return (ParameterValueTypeNumeric) null;
    }

    [Token(Token = "0x6015337")]
    [Address(RVA = "0x4D8A360", Offset = "0x4D8A360", VA = "0x4D8A360")]
    public ParameterView()
    {
    }
  }
}
