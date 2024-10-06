-- このluaスクリプトは、CO_101011_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ノワールってばいつも難しいカオしてるわねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうか？自分ではそんなつもりはないんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01010003")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:そんなんじゃツキも逃げて行っちゃうわよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうだどこかにパーッと遊びに行かない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_01010008","CO_101011_01010009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:んー…たまにはいいかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01010011")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:オッケー！<br>ノワールもたまにはノリがいいのね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（俺って普段、そんなにノリが悪いのか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101011_01010013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:どこに行こうかしら…うーん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あ、そうだ！<br>あそこにしよう！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:んー、今日はいいややめとくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01010017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ほら、また難しいカオして！さっき言ったばっかりじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010018")

	PlayAction(Actor002,"to Finger")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:だいたい、女の子から遊びに誘われて断るとかありえないんだから、フツー
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010019")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ほらいいからわたしに着いてきて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01010020")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、おい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01010021")

	goto Block1end

::Block1end::
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ1_2")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
