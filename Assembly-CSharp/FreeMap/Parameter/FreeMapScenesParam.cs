// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.FreeMapScenesParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Parameter
{
  [Token(Token = "0x2001860")]
  public class FreeMapScenesParam
  {
    [Token(Token = "0x4006A32")]
    [FieldOffset(Offset = "0x10")]
    private int cameraFieldID;
    [Token(Token = "0x4006A33")]
    [FieldOffset(Offset = "0x14")]
    private int environmentalSoundID;
    [Token(Token = "0x4006A34")]
    [FieldOffset(Offset = "0x18")]
    private int movableRouteID;
    [Token(Token = "0x4006A35")]
    [FieldOffset(Offset = "0x1C")]
    private int transitionAreaID;
    [Token(Token = "0x4006A36")]
    [FieldOffset(Offset = "0x20")]
    private int uniqueObjectLabel;
    [Token(Token = "0x4006A37")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapAreaBGMData bgm;
    [Token(Token = "0x4006A38")]
    [FieldOffset(Offset = "0x40")]
    private FreeMapAreaSituationData situation;
    [Token(Token = "0x4006A3A")]
    private const string CameraFieldSceneNameFormat = "Camera{0}{1}";
    [Token(Token = "0x4006A3B")]
    private const string MovableScritableNameFormat = "Movable{0}{1}";
    [Token(Token = "0x4006A3C")]
    private const string TransitionAreaSceneNameFormat = "Transition{0}{1}";
    [Token(Token = "0x4006A3D")]
    private const string EnvironmentalSoundObjectNameFormat = "EnvSE{0}{1}";

    [Token(Token = "0x170015C2")]
    public int UniqueObjectLabel
    {
      [Token(Token = "0x60089D0"), Address(RVA = "0x451E09C", Offset = "0x451E09C", VA = "0x451E09C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015C3")]
    public FreeMapAreaBGMData BGM
    {
      [Token(Token = "0x60089D1"), Address(RVA = "0x451E0A4", Offset = "0x451E0A4", VA = "0x451E0A4")] get
      {
        return new FreeMapAreaBGMData();
      }
    }

    [Token(Token = "0x170015C4")]
    public FreeMapAreaSituationData Situation
    {
      [Token(Token = "0x60089D2"), Address(RVA = "0x451E0B8", Offset = "0x451E0B8", VA = "0x451E0B8")] get
      {
        return new FreeMapAreaSituationData();
      }
    }

    [Token(Token = "0x170015C5")]
    public FreeMapBackGroundParam BackGroundParam
    {
      [Token(Token = "0x60089D3"), Address(RVA = "0x451E0C0", Offset = "0x451E0C0", VA = "0x451E0C0")] get
      {
        return new FreeMapBackGroundParam();
      }
    }

    [Token(Token = "0x170015C6")]
    private string backGroundIDString
    {
      [Token(Token = "0x60089D4"), Address(RVA = "0x451E0C8", Offset = "0x451E0C8", VA = "0x451E0C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015C7")]
    public string BackGroundSceneName
    {
      [Token(Token = "0x60089D5"), Address(RVA = "0x451E168", Offset = "0x451E168", VA = "0x451E168")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015C8")]
    public string BackGroundAssetBundleLabel
    {
      [Token(Token = "0x60089D6"), Address(RVA = "0x451E1DC", Offset = "0x451E1DC", VA = "0x451E1DC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015C9")]
    public string PlacementObjectName
    {
      [Token(Token = "0x60089D7"), Address(RVA = "0x451E210", Offset = "0x451E210", VA = "0x451E210")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CA")]
    public string PlacementAssetBundleLabel
    {
      [Token(Token = "0x60089D8"), Address(RVA = "0x451E294", Offset = "0x451E294", VA = "0x451E294")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CB")]
    private string cameraFieldIDString
    {
      [Token(Token = "0x60089D9"), Address(RVA = "0x451E2C8", Offset = "0x451E2C8", VA = "0x451E2C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CC")]
    public string CameraFieldSceneName
    {
      [Token(Token = "0x60089DA"), Address(RVA = "0x451E34C", Offset = "0x451E34C", VA = "0x451E34C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CD")]
    public string CameraFieldAssetBundleLabel
    {
      [Token(Token = "0x60089DB"), Address(RVA = "0x451E3C4", Offset = "0x451E3C4", VA = "0x451E3C4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CE")]
    private string movableRouteIDString
    {
      [Token(Token = "0x60089DC"), Address(RVA = "0x451E3E4", Offset = "0x451E3E4", VA = "0x451E3E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015CF")]
    public string MovableObjectName
    {
      [Token(Token = "0x60089DD"), Address(RVA = "0x451E468", Offset = "0x451E468", VA = "0x451E468")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D0")]
    public string MovableAssetBundleLabel
    {
      [Token(Token = "0x60089DE"), Address(RVA = "0x451E520", Offset = "0x451E520", VA = "0x451E520")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D1")]
    private string transitionAreaIDString
    {
      [Token(Token = "0x60089DF"), Address(RVA = "0x451E59C", Offset = "0x451E59C", VA = "0x451E59C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D2")]
    public string TransitionAreaSceneName
    {
      [Token(Token = "0x60089E0"), Address(RVA = "0x451E620", Offset = "0x451E620", VA = "0x451E620")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D3")]
    public string TransitionAreaAssetBundleLabel
    {
      [Token(Token = "0x60089E1"), Address(RVA = "0x451E6D8", Offset = "0x451E6D8", VA = "0x451E6D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D4")]
    private string environmentalSoundIDString
    {
      [Token(Token = "0x60089E2"), Address(RVA = "0x451E754", Offset = "0x451E754", VA = "0x451E754")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D5")]
    public string EnvironmentalSoundObjectName
    {
      [Token(Token = "0x60089E3"), Address(RVA = "0x451E7D8", Offset = "0x451E7D8", VA = "0x451E7D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D6")]
    public string EnvironmentalSoundAssetBundleLabel
    {
      [Token(Token = "0x60089E4"), Address(RVA = "0x451E890", Offset = "0x451E890", VA = "0x451E890")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60089E5")]
    [Address(RVA = "0x451E920", Offset = "0x451E920", VA = "0x451E920")]
    public FreeMapScenesParam(
      int backGroundID,
      int placementID,
      int cameraFieldID,
      int movableRouteID,
      int transitionAreaID,
      int environmentalSoundID,
      FreeMapAreaBGMData bgm,
      bool isIndoor,
      int uniqueObjectLabel = 0)
    {
    }

    [Token(Token = "0x60089E6")]
    [Address(RVA = "0x451E9BC", Offset = "0x451E9BC", VA = "0x451E9BC")]
    public FreeMapScenesParam(ILocationCollectData data, FreeMapAreaBGMData bgm)
    {
    }

    [Token(Token = "0x60089E7")]
    [Address(RVA = "0x451ED78", Offset = "0x451ED78", VA = "0x451ED78")]
    public FreeMapScenesParam(ILocationCollectData data)
    {
    }
  }
}
