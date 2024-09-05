// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelPreHomeEvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x200300E")]
  public class AdvViewerModelPreHomeEvStage : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x17003F6A")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012CA8"), Address(RVA = "0x3FB2F4C", Offset = "0x3FB2F4C", VA = "0x3FB2F4C")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F6B")]
    public BindingParam<IEnumerable<PreHomeEventAdvContentData>> ContentList
    {
      [Token(Token = "0x6012CA9"), Address(RVA = "0x3FB2F54", Offset = "0x3FB2F54", VA = "0x3FB2F54")] get
      {
        return (BindingParam<IEnumerable<PreHomeEventAdvContentData>>) null;
      }
    }

    [Token(Token = "0x17003F6C")]
    public BindingParam<string> ScriptFileName
    {
      [Token(Token = "0x6012CAA"), Address(RVA = "0x3FB2F5C", Offset = "0x3FB2F5C", VA = "0x3FB2F5C")] get
      {
        return (BindingParam<string>) null;
      }
    }

    [Token(Token = "0x6012CAB")]
    [Address(RVA = "0x3FB2F64", Offset = "0x3FB2F64", VA = "0x3FB2F64")]
    public AdvViewerModelPreHomeEvStage(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012CAC")]
    [Address(RVA = "0x3FB3300", Offset = "0x3FB3300", VA = "0x3FB3300")]
    public void Play(int contentId)
    {
    }

    [Token(Token = "0x6012CAD")]
    [Address(RVA = "0x3FB34A0", Offset = "0x3FB34A0", VA = "0x3FB34A0", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012CAE")]
    [Address(RVA = "0x3FB34A4", Offset = "0x3FB34A4", VA = "0x3FB34A4", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012CAF")]
    [Address(RVA = "0x3FB30C0", Offset = "0x3FB30C0", VA = "0x3FB30C0")]
    public IEnumerable<PreHomeEventAdvContentData> GetContentList()
    {
      return (IEnumerable<PreHomeEventAdvContentData>) null;
    }
  }
}
