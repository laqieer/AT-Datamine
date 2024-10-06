-- このluaスクリプトは、EA_066_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-116,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	Camera002 = SetTemplate("Actor002",205,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
set_pos(Actor001,{ 4, 0, -19.74})
set_pos(Actor002,{ 0.15, 0, -18.45})
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head", 0)
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor001)
wait_time( 0.1)
PlayActionDirect(Actor001,"to Wlk")
slidemove( Actor001, 1.2, 0, -17.9, 1.2)
se_play("SE_ADV_MA_01100_11_Jail_Foot")
wait_time( 1.2)
PlayActionDirect( Actor001,"to Std_Loop")
wait_time( 0.4)
-- ▲直接出力

	--★★ヴォールス★★:…行くのか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140003")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
wait_time(0.5)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002, 45, 0.6)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002, 0.45, 0.4, 0.85, 0.2, 1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ああ。世界中を旅してまわりたいんだ<br>俺の中で生きている彼女といっしょに
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140004")

-- ▼直接出力
voice_play("VO_101024_sp_0001_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:ノワール…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ノワール★★:…ごめん。こんなこと言われても困るよな<br>分かってるのに
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140006")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:いいんだ。それより…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ヴォールス★★:それより、俺になにかできることは無いか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140008")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:…！本当、あんたって義理堅いな<br>ランスロットに聞いていた通りだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ヴォールス★★:？ランスロットがなにか？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:どういう繋がりなんだって聞いたことがあるんだあんた達、仲が良さそうに見えたから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140011")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ノワール★★:確か、あんたがいた海賊団がバルバロイに襲われたとき助けたのが出会いで――
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:ああ。居場所を失った俺にランスロットはこの学園を紹介してくれた
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140013")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:案外、あんたと俺<br>入学経緯が似てるかもな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140014")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ヴォールス★★:俺はランスロットに剣を向けた覚えはないぞ？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140016")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:知ってる
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140018")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…入学してからは<br>本当、色々なことがあったよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140019")

	change_face(Actor001,"Normal")

	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140020")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0022_1")
-- ▲直接出力

	--★★ノワール★★:………なぁもし、旅に出ることがあったら
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140021")


	--★★ノワール★★:いろんな国のコインを集めてくれないか異国のコインを、たくさん
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140022")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ヴォールス★★:コイン…？構わないが、どうして
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0140023")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:手土産にしたいんだ<br>コインがたくさんあればきっと
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140024")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:リッチな気持ちになれるだろ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_066_0140026")

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
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
