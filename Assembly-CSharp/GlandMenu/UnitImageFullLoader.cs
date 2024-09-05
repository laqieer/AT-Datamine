// Decompiled with JetBrains decompiler
// Type: GlandMenu.UnitImageFullLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x2000969")]
  public class UnitImageFullLoader : MonoBehaviour
  {
    [Token(Token = "0x4002BA7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x4002BA8")]
    [FieldOffset(Offset = "0x20")]
    private int targetStyleId;

    [Token(Token = "0x6003528")]
    [Address(RVA = "0x3524018", Offset = "0x3524018", VA = "0x3524018")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003529")]
    [Address(RVA = "0x3524038", Offset = "0x3524038", VA = "0x3524038")]
    public void Load(AssetCachedSpawner assetCachedSpawner, int nextStyleId)
    {
    }

    [Token(Token = "0x600352A")]
    [Address(RVA = "0x3524180", Offset = "0x3524180", VA = "0x3524180")]
    public UnitImageFullLoader()
    {
    }
  }
}
