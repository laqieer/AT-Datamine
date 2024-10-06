// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.AdditionalParameterModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Common
{
  [Token(Token = "0x20035C6")]
  public abstract class AdditionalParameterModelBase
  {
    [Token(Token = "0x400EA08")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x1700465E")]
    public AdditionalParameterType Reinforce
    {
      [Token(Token = "0x60152A9"), Address(RVA = "0x4D86E0C", Offset = "0x4D86E0C", VA = "0x4D86E0C")] get
      {
        return (AdditionalParameterType) null;
      }
      [Token(Token = "0x60152AA"), Address(RVA = "0x4D86E14", Offset = "0x4D86E14", VA = "0x4D86E14")] protected set
      {
      }
    }

    [Token(Token = "0x1700465F")]
    public AdditionalParameterType Resist
    {
      [Token(Token = "0x60152AB"), Address(RVA = "0x4D86E1C", Offset = "0x4D86E1C", VA = "0x4D86E1C")] get
      {
        return (AdditionalParameterType) null;
      }
      [Token(Token = "0x60152AC"), Address(RVA = "0x4D86E24", Offset = "0x4D86E24", VA = "0x4D86E24")] protected set
      {
      }
    }

    [Token(Token = "0x17004660")]
    public AdditionalParameterType Slay
    {
      [Token(Token = "0x60152AD"), Address(RVA = "0x4D86E2C", Offset = "0x4D86E2C", VA = "0x4D86E2C")] get
      {
        return (AdditionalParameterType) null;
      }
      [Token(Token = "0x60152AE"), Address(RVA = "0x4D86E34", Offset = "0x4D86E34", VA = "0x4D86E34")] protected set
      {
      }
    }

    [Token(Token = "0x17004661")]
    public AdditionalParameterType ResistSlay
    {
      [Token(Token = "0x60152AF"), Address(RVA = "0x4D86E3C", Offset = "0x4D86E3C", VA = "0x4D86E3C")] get
      {
        return (AdditionalParameterType) null;
      }
      [Token(Token = "0x60152B0"), Address(RVA = "0x4D86E44", Offset = "0x4D86E44", VA = "0x4D86E44")] protected set
      {
      }
    }

    [Token(Token = "0x60152B1")]
    [Address(RVA = "0x4D86E4C", Offset = "0x4D86E4C", VA = "0x4D86E4C")]
    protected AdditionalParameterModelBase()
    {
    }
  }
}
