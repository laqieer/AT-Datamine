// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.CirclePrefabAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x200177A")]
  public class CirclePrefabAssetLoader
  {
    [Token(Token = "0x4006810")]
    public const string ABName = "content_freemap_prefabs_actioncircle";
    [Token(Token = "0x4006811")]
    public const string AssetName = "FreeMapActionCircle";

    [Token(Token = "0x17001501")]
    public GameObject Object
    {
      [Token(Token = "0x600850E"), Address(RVA = "0x406A4D0", Offset = "0x406A4D0", VA = "0x406A4D0")] protected set
      {
      }
      [Token(Token = "0x600850F"), Address(RVA = "0x406A4D8", Offset = "0x406A4D8", VA = "0x406A4D8")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001502")]
    public string EffectAssetName
    {
      [Token(Token = "0x6008510"), Address(RVA = "0x406A4E0", Offset = "0x406A4E0", VA = "0x406A4E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001503")]
    public GameObject Effect
    {
      [Token(Token = "0x6008511"), Address(RVA = "0x406A4E8", Offset = "0x406A4E8", VA = "0x406A4E8")] protected set
      {
      }
      [Token(Token = "0x6008512"), Address(RVA = "0x406A4F0", Offset = "0x406A4F0", VA = "0x406A4F0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6008513")]
    [Address(RVA = "0x406A4F8", Offset = "0x406A4F8", VA = "0x406A4F8")]
    public CirclePrefabAssetLoader(string assetName)
    {
    }

    [Token(Token = "0x6008514")]
    [Address(RVA = "0x4067EB0", Offset = "0x4067EB0", VA = "0x4067EB0")]
    public CirclePrefabAssetLoader(FreeMapUICircleParam circleParameter)
    {
    }

    [Token(Token = "0x6008515")]
    [Address(RVA = "0x4068018", Offset = "0x4068018", VA = "0x4068018")]
    public void Load(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008516")]
    [Address(RVA = "0x40688E8", Offset = "0x40688E8", VA = "0x40688E8")]
    public void Release()
    {
    }

    [Token(Token = "0x6008517")]
    [Address(RVA = "0x406A564", Offset = "0x406A564", VA = "0x406A564")]
    private void OwnerObjectLoadCallback(GameObject asset)
    {
    }

    [Token(Token = "0x6008518")]
    [Address(RVA = "0x406A744", Offset = "0x406A744", VA = "0x406A744")]
    private void EffectObjectLoadCallback(GameObject asset)
    {
    }

    [Token(Token = "0x6008519")]
    [Address(RVA = "0x406A61C", Offset = "0x406A61C", VA = "0x406A61C")]
    private void WorkIfLoadedAll()
    {
    }

    [Token(Token = "0x600851A")]
    [Address(RVA = "0x406A7FC", Offset = "0x406A7FC", VA = "0x406A7FC")]
    private void CheckedAlertScalingMode(bool checkChild)
    {
    }
  }
}
