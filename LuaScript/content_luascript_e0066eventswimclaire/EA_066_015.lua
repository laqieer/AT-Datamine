-- このluaスクリプトは、EA_066_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",160,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_005)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
set_pos(Actor002, {-0.79, 0.074, 4.51})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Std_Loop")
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
Appear(Actor002)
IN_WALK(Actor002, CharaPos112011_01_005)
voice_play("VO_101025_sp_0002_1")
-- ▲直接出力

	--★★クレア★★:旅に出るのね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.3)
turn(Actor001,0,-70,0,0.2)
wait_time(0.2)
PlayAction(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:クレア
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:今その服に着替えたのは円卓の騎士の誇りを<br>忘れぬように自分を戒めるため
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150006")

	PlayAction(Actor002,"to  Std_No")

	--★★クレア★★:そんなこと、皆があなたを知っている<br>この場所に残るなら必要ないものね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:名推理だ。だが、いざここを出るとなると<br>どこへ行けばいいものか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クレア★★:やりたいことが思いつかないなら<br>趣味を再開してみるもいいんじゃない？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150009")


	--★★ヴォールス★★:趣味…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:世界中に眠る伝説級の武具探し<br>海賊時代のあなたのライフワーク
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:…！
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クレア★★:バルバロイが消えた今こそ<br>再開する頃合いじゃないかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0046")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ヴォールス★★:…そうだな。それも悪くないかもしれん
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:わたしも行くわ。あなたの探し物に付き合えば<br>世界中の事件に出会えると思うから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150015")

	PlayAction(Actor002,"to Std_Loop")
	change_face(Actor002,"Smile")

	--★★クレア★★:それに…<br>わたしはあなたのキラーズだから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150016")


	--★★クレア★★:あなたが抱えているその気持ちも<br>分け合っていきたいと思ってる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150017")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:重くて下ろせない荷物なら、なおさら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0150018")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ヴォールス★★:そうか<br>…ありがとう
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150019")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn(Actor001,0,15,0,0.3)
wait_time(0.5)

PlayPartVoiceDirect("ヴォールス","0011")
PlayAction(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ヴォールス★★:それじゃあ、行こうか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0150021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
