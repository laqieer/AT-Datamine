-- このluaスクリプトは、CO_101035_0604.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
PlayActionDirect(Actor002,"to Kneeling")
set_rot(Actor001,{0,-65,0})
set_rot(Actor002,{0,-140,0})
karedo = setup_prop_object(10130003)
set_pos(karedo,{-1.9,0,-0.4})
set_rot(karedo,{0,150,0})
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,karedo)
set_common_look_at(Actor003,Actor002)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★リリアーナ★★:よかった少し呼吸が落ち着いたみたいです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06040002")

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:あの…このことは他の皆さんには内緒にしておいてくれませんか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06040003")

-- ▼直接出力
setup_small_camera_start(Camera003)
Hide(Actor002)
Appear(Actor004)
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クレア★★:敵国の人間…それも兵士よ？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Sad")

	--★★リリアーナ2★★:ずいぶん酷い目に遭ったみたいですし…これ以上酷い目に遭って欲しくないから…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101035_06040005")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…わかったその気持ち、わからないでもないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06040006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:うん、言わない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06040007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…ディナタンにだけは話してもいいか？<br>あいつが畑に来ることもあるだろうし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06040008")


	--★★ノワール★★:なにより、衛生兵としての経験があるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06040009")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リリアーナ2★★:はい、もちろんです
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101035_06040011")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130003)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
