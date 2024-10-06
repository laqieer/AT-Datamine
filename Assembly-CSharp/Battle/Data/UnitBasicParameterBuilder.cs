// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitBasicParameterBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200271E")]
  public class UnitBasicParameterBuilder
  {
    [Token(Token = "0x400A74D")]
    [FieldOffset(Offset = "0x10")]
    private WeakReference<UnitParameterData> unitParamRef;
    [Token(Token = "0x400A74E")]
    [FieldOffset(Offset = "0x18")]
    private List<WeakReference<AccessoryData>> accessoryRefs;

    [Token(Token = "0x170033C0")]
    private UnitParameterData unitParam
    {
      [Token(Token = "0x600F309"), Address(RVA = "0x1F9C0E4", Offset = "0x1F9C0E4", VA = "0x1F9C0E4")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600F30A")]
    [Address(RVA = "0x1F9C148", Offset = "0x1F9C148", VA = "0x1F9C148")]
    public UnitBasicParameterBuilder SetUnitParameter(UnitParameterData unitParam)
    {
      return (UnitBasicParameterBuilder) null;
    }

    [Token(Token = "0x600F30B")]
    [Address(RVA = "0x1F9C1D0", Offset = "0x1F9C1D0", VA = "0x1F9C1D0")]
    public UnitBasicParameterBuilder AddAccessory(AccessoryData acc)
    {
      return (UnitBasicParameterBuilder) null;
    }

    [Token(Token = "0x600F30C")]
    [Address(RVA = "0x1F9C2C8", Offset = "0x1F9C2C8", VA = "0x1F9C2C8")]
    public UnitBasicParameterBuilder AddAccessories(IReadOnlyList<AccessoryData> accs)
    {
      return (UnitBasicParameterBuilder) null;
    }

    [Token(Token = "0x600F30D")]
    [Address(RVA = "0x1F9C59C", Offset = "0x1F9C59C", VA = "0x1F9C59C")]
    public UnitBasicParameterBuilder ResetAccessories() => (UnitBasicParameterBuilder) null;

    [Token(Token = "0x600F30E")]
    [Address(RVA = "0x1F9C608", Offset = "0x1F9C608", VA = "0x1F9C608")]
    public UnitBasicParameterBuilder Reset() => (UnitBasicParameterBuilder) null;

    [Token(Token = "0x600F30F")]
    [Address(RVA = "0x1F9C610", Offset = "0x1F9C610", VA = "0x1F9C610")]
    public ICorrectableParameter<IBasicParameter> Build()
    {
      return (ICorrectableParameter<IBasicParameter>) null;
    }

    [Token(Token = "0x600F310")]
    [Address(RVA = "0x1F9C6D8", Offset = "0x1F9C6D8", VA = "0x1F9C6D8")]
    private void AddAccessoryOffsets(BasicParameter offset)
    {
    }

    [Token(Token = "0x600F311")]
    [Address(RVA = "0x1F9C8B4", Offset = "0x1F9C8B4", VA = "0x1F9C8B4")]
    public static UnitBasicParameterBuilder CreateTemplateBuilder(UnitParameterData unit)
    {
      return (UnitBasicParameterBuilder) null;
    }

    [Token(Token = "0x600F312")]
    [Address(RVA = "0x1F9C930", Offset = "0x1F9C930", VA = "0x1F9C930")]
    public UnitBasicParameterBuilder()
    {
    }
  }
}
