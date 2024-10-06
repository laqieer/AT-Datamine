-- このluaスクリプトは、PT7_05_02_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-48.667,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
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
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0004")
-- ▲直接出力

	--★★ノワール★★:ケイ<br>俺に用事があるってことだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_05_02_0010001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0007")
-- ▲直接出力

	--★★ケイ★★:先日のソールズベリー平原での訓練が<br>思いのほか生徒たちに好評でな
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_05_02_0010002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_05_02_0010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…はいはい<br>それで、訓練はどこでやってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_05_02_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0008")
-- ▲直接出力

	--★★ケイ★★:アイルランド島にある城だ<br>すでに転移の準備は済ませてある
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_05_02_0010005")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
