// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.ILocationCollectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x200194E")]
  public interface ILocationCollectData
  {
    [Token(Token = "0x1700171E")]
    int AreaID { [Token(Token = "0x6009027")] get; }

    [Token(Token = "0x1700171F")]
    int BackGroundID { [Token(Token = "0x6009028")] get; }

    [Token(Token = "0x17001720")]
    int PlacementID { [Token(Token = "0x6009029")] get; }

    [Token(Token = "0x17001721")]
    int CameraFieldID { [Token(Token = "0x600902A")] get; }

    [Token(Token = "0x17001722")]
    int TransitionAreaID { [Token(Token = "0x600902B")] get; }

    [Token(Token = "0x17001723")]
    int EnvironmentalSoundID { [Token(Token = "0x600902C")] get; }

    [Token(Token = "0x17001724")]
    int MinimapID { [Token(Token = "0x600902D")] get; }

    [Token(Token = "0x17001725")]
    int UniqueObjectSettingLabel { [Token(Token = "0x600902E")] get; }

    [Token(Token = "0x17001726")]
    int MovableRouteID { [Token(Token = "0x600902F")] get; }

    [Token(Token = "0x17001727")]
    int MovableSettingID { [Token(Token = "0x6009030")] get; }

    [Token(Token = "0x17001728")]
    int IntroductionTableID { [Token(Token = "0x6009031")] get; }

    [Token(Token = "0x17001729")]
    bool IsIndoor { [Token(Token = "0x6009032")] get; }

    [Token(Token = "0x6009033")]
    FreeMapAreaBGMData CreateBGMData();
  }
}
