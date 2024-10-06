// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.DialogStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.ProceedCondition;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D8A")]
  public class DialogStatus
  {
    [Token(Token = "0x17003CD5")]
    public DialogStatus.ButtonStatus PositiveButton
    {
      [Token(Token = "0x6011CE3"), Address(RVA = "0x3F9FA14", Offset = "0x3F9FA14", VA = "0x3F9FA14")] get
      {
        return (DialogStatus.ButtonStatus) null;
      }
      [Token(Token = "0x6011CE4"), Address(RVA = "0x3F9FA1C", Offset = "0x3F9FA1C", VA = "0x3F9FA1C")] set
      {
      }
    }

    [Token(Token = "0x17003CD6")]
    public DialogStatus.ButtonStatus CloseButton
    {
      [Token(Token = "0x6011CE5"), Address(RVA = "0x3F9FA24", Offset = "0x3F9FA24", VA = "0x3F9FA24")] get
      {
        return (DialogStatus.ButtonStatus) null;
      }
      [Token(Token = "0x6011CE6"), Address(RVA = "0x3F9FA2C", Offset = "0x3F9FA2C", VA = "0x3F9FA2C")] set
      {
      }
    }

    [Token(Token = "0x17003CD7")]
    public DialogStatus.ButtonStatus RemoveButton
    {
      [Token(Token = "0x6011CE7"), Address(RVA = "0x3F9FA34", Offset = "0x3F9FA34", VA = "0x3F9FA34")] get
      {
        return (DialogStatus.ButtonStatus) null;
      }
      [Token(Token = "0x6011CE8"), Address(RVA = "0x3F9FA3C", Offset = "0x3F9FA3C", VA = "0x3F9FA3C")] set
      {
      }
    }

    [Token(Token = "0x17003CD8")]
    public bool ShowProgress
    {
      [Token(Token = "0x6011CE9"), Address(RVA = "0x3F9FA44", Offset = "0x3F9FA44", VA = "0x3F9FA44")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011CEA"), Address(RVA = "0x3F9FA4C", Offset = "0x3F9FA4C", VA = "0x3F9FA4C")] set
      {
      }
    }

    [Token(Token = "0x6011CEB")]
    [Address(RVA = "0x3F9F5F4", Offset = "0x3F9F5F4", VA = "0x3F9F5F4")]
    public DialogStatus()
    {
    }

    [Token(Token = "0x2002D8B")]
    public class ButtonStatus
    {
      [Token(Token = "0x17003CD9")]
      public string Text
      {
        [Token(Token = "0x6011CEC"), Address(RVA = "0x3F9FB60", Offset = "0x3F9FB60", VA = "0x3F9FB60")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6011CED"), Address(RVA = "0x3F9FB68", Offset = "0x3F9FB68", VA = "0x3F9FB68")] set
        {
        }
      }

      [Token(Token = "0x17003CDA")]
      public bool Active
      {
        [Token(Token = "0x6011CEE"), Address(RVA = "0x3F9FB70", Offset = "0x3F9FB70", VA = "0x3F9FB70")] get
        {
          return new bool();
        }
        [Token(Token = "0x6011CEF"), Address(RVA = "0x3F9FB78", Offset = "0x3F9FB78", VA = "0x3F9FB78")] set
        {
        }
      }

      [Token(Token = "0x14000158")]
      public event Action OnClick
      {
        [Token(Token = "0x6011CF0"), Address(RVA = "0x3F9E6D0", Offset = "0x3F9E6D0", VA = "0x3F9E6D0")] add
        {
        }
        [Token(Token = "0x6011CF1"), Address(RVA = "0x3F9FB84", Offset = "0x3F9FB84", VA = "0x3F9FB84")] remove
        {
        }
      }

      [Token(Token = "0x17003CDB")]
      public IFreeMapProceedCondition ProceedCondition
      {
        [Token(Token = "0x6011CF2"), Address(RVA = "0x3F9FC20", Offset = "0x3F9FC20", VA = "0x3F9FC20")] get
        {
          return (IFreeMapProceedCondition) null;
        }
        [Token(Token = "0x6011CF3"), Address(RVA = "0x3F9FC28", Offset = "0x3F9FC28", VA = "0x3F9FC28")] set
        {
        }
      }

      [Token(Token = "0x6011CF4")]
      [Address(RVA = "0x3F9FA58", Offset = "0x3F9FA58", VA = "0x3F9FA58")]
      public ButtonStatus()
      {
      }
    }
  }
}
