// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.NoDuelActionLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F6")]
  public class NoDuelActionLogic : ActionLogicBase
  {
    [Token(Token = "0x600E3F5")]
    [Address(RVA = "0x477EFE8", Offset = "0x477EFE8", VA = "0x477EFE8")]
    public NoDuelActionLogic(
      ActionContext context,
      TargetPair activatorPair,
      TargetPair mainTargetPair,
      List<TargetPair> targets)
    {
    }

    [Token(Token = "0x600E3F6")]
    [Address(RVA = "0x477F07C", Offset = "0x477F07C", VA = "0x477F07C", Slot = "4")]
    public override ActionResult Execute() => (ActionResult) null;

    [Token(Token = "0x600E3F7")]
    [Address(RVA = "0x477F160", Offset = "0x477F160", VA = "0x477F160", Slot = "5")]
    public override ActionResult ExecutePreEffect() => (ActionResult) null;

    [Token(Token = "0x600E3F8")]
    [Address(RVA = "0x477F244", Offset = "0x477F244", VA = "0x477F244", Slot = "6")]
    public override ActionResult ExecutePostEffect() => (ActionResult) null;
  }
}
