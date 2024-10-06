-- このluaスクリプトは、PT7_05_01_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",-48.667,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力

PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:ノワール、頼みがある
	Talk(Actor001,"CHRNAME_KAY","speech","L","PT7_05_01_0010001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:想像はついてる。いつもの討伐依頼だろ<br>それで今日の相手はバルバロイか？ローマ軍か？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","PT7_05_01_0010002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:
	Talk(Actor001,"CHRNAME_KAY","speech","L","PT7_05_01_0010003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ケイ★★:ソールズベリー平原で<br>実戦を想定した訓練をやることになってな
	Talk(Actor001,"CHRNAME_KAY","speech","L","PT7_05_01_0010004")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0046")
-- ▲直接出力

	--★★ノワール★★:なるほど<br>その訓練相手になれってことか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","PT7_05_01_0010005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:末端とはいえ貴公も円卓の騎士だ<br>練兵にはうってつけと思ってな
	Talk(Actor001,"CHRNAME_KAY","speech","L","PT7_05_01_0010006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:いつも一言余計なんだよ…<br>まあいいよ、すぐ行ってくる
	Talk(Actor002,"CHRNAME_NOIR","speech","L","PT7_05_01_0010007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
