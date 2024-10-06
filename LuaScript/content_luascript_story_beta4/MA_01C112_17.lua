-- このluaスクリプトは、MA_01C112_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
lookat_weight(Actor002, 1.0, 0, 0.5, 0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:本当にランスロットさんは<br>スノードンにいるんでしょうか？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C112_170002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:さぁな。どっかの誰かみてぇに<br>森で迷子にでもなってたりしてなぁ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_170003")

	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:ま、銀卓騎士団の連中が躍起になってさがしても<br>手掛かりひとつ見つからねぇんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_170004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:なにかしらあったのは間違いねぇだろうな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_170006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★クラリス★★:<ruby=シルバタブラナイツ>銀卓騎士団</ruby>がランスロットさんを<br>さがしてるんです？どうして？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C112_170007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力

	--★★モルドレッド★★:さぁ、なんでだろうな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_170009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:どうも、連中にとって<br>最強騎士は特別な存在らしいぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_170010")

-- ▼直接出力
lookat_delay_weight(Actor004, 1.0, 0, 0.5, 0.2,1.0)
keep_ik_lookat(Actor004,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C112_170011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor003, 0.9, 0, 0.5, 0.2,1.0)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…先を急ごう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C112_170012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
