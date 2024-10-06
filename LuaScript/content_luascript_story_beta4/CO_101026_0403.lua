-- このluaスクリプトは、CO_101026_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110271_51","110271_51_h")
Include("content_adv_advsmall_110271_51","Template110271_51_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110271_51_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_001)
	Camera002 = SetTemplate("Actor002",68,CharaPos110271_51_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110271_51_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110271_51_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110271_51_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_008)
	InitializeTemplateRandomCamera110271_51()
	InitializeTemplate110271_51()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor005,"J_Head")
lookat_delay_weight(Actor002,0.8,0.08,0.4,0.2,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110271)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to Bow")
-- ▼直接出力
PlayPartVoice("現代男子", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:先ほどは本当にありがとうございました！
	Talk(Actor005,"NPCNAME_0269","speech","L","CO_101026_04030002")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ボクとしたことが我を忘れてしまったよ<br>酔っ払ったつもりはないのだけどね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030004")

	open_select_window_tag(Actor001,"Normal","CO_101026_04030006","CO_101026_04030007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
lookat_delay_weight_reset(Actor002 , 1)
turn_chara(Actor002,-184,0)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺たちまだ未成年だもん<br>酒は飲めないよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04030009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:やれやれ<br>庶民はジョークのセンスが低くて困る
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030011")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:そのあたりも<br>教えてあげる必要があるようだね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
lookat_delay_weight_reset(Actor002 , 1)
turn_chara(Actor002,-184,0)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:見直した。かっこよかったよ<br>あんたのノブレス・オブリージュ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04030014")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ははっは…ん？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030016")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:見直しただって？<br>それまではボクをどう見ていたんだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030017")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ダニーとジャンに<br>心意気を教えてもらうといいよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030019")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:友達としてのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04030020")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:付き人としてのだ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030021")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:なんにしても今日は失礼したね<br>キミたちを厄介事に巻き込んでしまった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:お詫びのしるしと言ってはなんだが<br>美味しいものが食べられる店に招待しよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030024")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おごってくれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04030025")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:キミは自腹だ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04030026")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:（なんで俺だけ<br>いつもこんなにひどい扱いなんだ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_04030027")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
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
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110271)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110271_51)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
