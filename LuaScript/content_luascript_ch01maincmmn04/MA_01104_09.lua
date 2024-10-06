-- このluaスクリプトは、MA_01104_09.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.5,0.5)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.5)
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,0.5,0.5)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:ノワール/それと妹さん…ディナタンちゃん、だっけ？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_090002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あっ/は、はいっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_090003")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ラグネル★★:ケイ先生が呼んでるよ/エントランスまで来てほしいんだって
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_090004")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
