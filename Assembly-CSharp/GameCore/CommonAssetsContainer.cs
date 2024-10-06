// Decompiled with JetBrains decompiler
// Type: GameCore.CommonAssetsContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BAD")]
  public class CommonAssetsContainer : SingletonMonoBehaviour<CommonAssetsContainer>
  {
    [Token(Token = "0x400354A")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner cachedSpawner;

    [Token(Token = "0x170009A3")]
    public BattleAssetsContainer BattleCommon
    {
      [Token(Token = "0x60042B1"), Address(RVA = "0x363BD8C", Offset = "0x363BD8C", VA = "0x363BD8C")] get
      {
        return (BattleAssetsContainer) null;
      }
      [Token(Token = "0x60042B2"), Address(RVA = "0x363BD94", Offset = "0x363BD94", VA = "0x363BD94")] private set
      {
      }
    }

    [Token(Token = "0x170009A4")]
    public AssetCachedSpawner CommonCachedSpawner
    {
      [Token(Token = "0x60042B3"), Address(RVA = "0x363BD9C", Offset = "0x363BD9C", VA = "0x363BD9C")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x60042B4")]
    [Address(RVA = "0x363BDA4", Offset = "0x363BDA4", VA = "0x363BDA4", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60042B5")]
    [Address(RVA = "0x363BE04", Offset = "0x363BE04", VA = "0x363BE04")]
    public void Start()
    {
    }

    [Token(Token = "0x60042B6")]
    [Address(RVA = "0x363C0FC", Offset = "0x363C0FC", VA = "0x363C0FC")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x60042B7")]
    [Address(RVA = "0x363C18C", Offset = "0x363C18C", VA = "0x363C18C")]
    public CommonAssetsContainer()
    {
    }
  }
}
