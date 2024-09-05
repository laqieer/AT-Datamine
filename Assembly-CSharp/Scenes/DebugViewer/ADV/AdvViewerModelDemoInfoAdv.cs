// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelDemoInfoAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FCC")]
  public class AdvViewerModelDemoInfoAdv : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CC4A")]
    [FieldOffset(Offset = "0x20")]
    protected AdvViewerModelDemoInfoAdv.EventNamePath selectPath;
    [Token(Token = "0x400CC4B")]
    [FieldOffset(Offset = "0x28")]
    protected int selectId;

    [Token(Token = "0x17003F05")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012AE9"), Address(RVA = "0x42A1AA8", Offset = "0x42A1AA8", VA = "0x42A1AA8")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F06")]
    public AdvViewerModelDemoInfoAdv.EventNamePath RootPath
    {
      [Token(Token = "0x6012AEA"), Address(RVA = "0x42A1AB0", Offset = "0x42A1AB0", VA = "0x42A1AB0")] get
      {
        return (AdvViewerModelDemoInfoAdv.EventNamePath) null;
      }
      [Token(Token = "0x6012AEB"), Address(RVA = "0x42A1AB8", Offset = "0x42A1AB8", VA = "0x42A1AB8")] private set
      {
      }
    }

    [Token(Token = "0x17003F07")]
    public BindingParam<IEnumerable<string>> SelectList
    {
      [Token(Token = "0x6012AEC"), Address(RVA = "0x42A1AC0", Offset = "0x42A1AC0", VA = "0x42A1AC0")] get
      {
        return (BindingParam<IEnumerable<string>>) null;
      }
    }

    [Token(Token = "0x17003F08")]
    public BindingParam<bool> EnablePlay
    {
      [Token(Token = "0x6012AED"), Address(RVA = "0x42A1AC8", Offset = "0x42A1AC8", VA = "0x42A1AC8")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012AEE")]
    [Address(RVA = "0x4299710", Offset = "0x4299710", VA = "0x4299710")]
    public AdvViewerModelDemoInfoAdv(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012AEF")]
    [Address(RVA = "0x42A2044", Offset = "0x42A2044", VA = "0x42A2044")]
    public void OnClear()
    {
    }

    [Token(Token = "0x6012AF0")]
    [Address(RVA = "0x42A20E4", Offset = "0x42A20E4", VA = "0x42A20E4")]
    public void OnBack()
    {
    }

    [Token(Token = "0x6012AF1")]
    [Address(RVA = "0x42A2184", Offset = "0x42A2184", VA = "0x42A2184")]
    public bool SetSelect(string select) => new bool();

    [Token(Token = "0x6012AF2")]
    [Address(RVA = "0x42A2324", Offset = "0x42A2324", VA = "0x42A2324")]
    private void TransitionOut()
    {
    }

    [Token(Token = "0x6012AF3")]
    [Address(RVA = "0x42A23F8", Offset = "0x42A23F8", VA = "0x42A23F8")]
    public void Play()
    {
    }

    [Token(Token = "0x6012AF4")]
    [Address(RVA = "0x42A2588", Offset = "0x42A2588", VA = "0x42A2588", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012AF5")]
    [Address(RVA = "0x42A258C", Offset = "0x42A258C", VA = "0x42A258C", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x2002FCD")]
    public class EventNamePath
    {
      [Token(Token = "0x400CC4E")]
      [FieldOffset(Offset = "0x10")]
      public Dictionary<string, AdvViewerModelDemoInfoAdv.EventNamePath> Child;
      [Token(Token = "0x400CC4F")]
      [FieldOffset(Offset = "0x18")]
      public AdvViewerModelDemoInfoAdv.EventNamePath Parent;
      [Token(Token = "0x400CC50")]
      [FieldOffset(Offset = "0x20")]
      public Dictionary<string, int> EventNameDictionary;

      [Token(Token = "0x6012AF8")]
      [Address(RVA = "0x42A1B90", Offset = "0x42A1B90", VA = "0x42A1B90")]
      public void SetEventPath(string eventPath, int id)
      {
      }

      [Token(Token = "0x6012AF9")]
      [Address(RVA = "0x42A1FCC", Offset = "0x42A1FCC", VA = "0x42A1FCC")]
      public IEnumerable<string> GetList() => (IEnumerable<string>) null;

      [Token(Token = "0x17003F09")]
      public int MenuLength
      {
        [Token(Token = "0x6012AFA"), Address(RVA = "0x42A26B8", Offset = "0x42A26B8", VA = "0x42A26B8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6012AFB")]
      [Address(RVA = "0x42A1AD0", Offset = "0x42A1AD0", VA = "0x42A1AD0")]
      public EventNamePath()
      {
      }
    }
  }
}
