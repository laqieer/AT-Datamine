-- このluaスクリプトは、EA_072_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_008)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0017_1")
-- ▲直接出力

	--★★ノワール★★:帰郷早々災難だな、ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101031_sp_0001_1")
-- ▲直接出力

	--★★ラヴェイン★★:君こそ幸先は<br>よろしくなさそうですね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…なにがあったんだ？<br>なぜ、カレドニアの残党が今頃…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130004")


	--★★ラヴェイン★★:あの兵たちが…<br>信じがたい話をしていました
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130005")


	--★★ラヴェイン★★:「カレドニア王ライエンスが蘇った」と
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なん、だって………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130008")


	--★★ラヴェイン★★:そのライエンスの指揮で<br>動いていると…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0029")
-- ▲直接出力

	--★★ノワール★★:…！？<br>そんなはずは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ライエンスは…<br>だって、あいつは俺たちが──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ラヴェイン★★:ひそかに生き延びていた可能性は…？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…あり得ない<br>致命傷だったはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130013")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0008")
-- ▲直接出力

	--★★ラヴェイン★★:………ですがその、ライエンス──<br>を、名乗る者が引き連れたカレドニア残党軍は…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130014")


	--★★ラヴェイン★★:戦後の混乱に乗じて<br>アントニヌス・ウォールに陣取ったそうです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、次の狙いは──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130016")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0007")
-- ▲直接出力

	--★★ラヴェイン★★:ええ。キャメリアードを制圧し<br>そのあと学園へ攻め入る計画でしょうね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130017")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:………通り道だ。行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130018")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ラヴェイン★★:私はログレスへ報せを出します
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130019")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:円卓の騎士は各地に散っていますから<br>応援は期待できませんが──
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:平気だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor001,1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,188,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101031_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:ノワール君
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130023")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:平気だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0130024")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0002")
-- ▲直接出力

	--★★ラヴェイン★★:ノワール君、かつて私が<br>君に言ったこと…覚えていますか
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130025")


	--★★ラヴェイン★★:問題は、喪ったことではありません
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130026")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ラヴェイン★★:責任に囚われ続けることはありません<br>悲しみばかりに目を向け続けることもない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","EA_072_0130029")


	--★★テロップ★★:すべて、覚えてる
	Talk(Actor003,"","simple","N","EA_072_0130030")


	--★★テロップ★★:キャメリアード──キミの故郷
	Talk(Actor003,"","simple","N","EA_072_0130031")


	--★★テロップ★★:はじめて、キミの涙を見た場所 
	Talk(Actor003,"","simple","N","EA_072_0130032")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Painful2")
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
