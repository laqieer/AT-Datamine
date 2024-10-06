-- このluaスクリプトは、MA_01A112_51.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",110,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
hotdog = setup_prop_object(10102001)
hotdog_offset = {0,0,0,0,0,0}
on_parent(hotdog,Actor002, "Loc_weapon_constrint_R", hotdog_offset)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to EatIdle")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116030)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしの成長、見てよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:どう！？<br>これどう！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510004")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:かぶりついて食べるこのジャンクフードに<br>以前のわたしは苦戦を強いられてたわけだけど！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ソースが溢れそうなこの雑多な盛り付けのコレ<br>服を汚さずに食べられるよーになったわ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_510007","MA_01A112_510008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ふふっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_510010")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:笑うな！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A112_510011")

	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:嘲り笑うな！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A112_510013")

	close_cutin()
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Appl")
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごいぞギネヴィア！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_510015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:もっと褒め称えなさい！<br>崇め奉りなさい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510016")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:わたし！ギネヴィアは！<br>今日！このときをもって！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510017")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:食べ歩きができるようなったのよーっ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A112_510018")

	close_cutin()
	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
off_parent(hotdog)
off_active(hotdog)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:もう怖いものはないわ！<br>高級料理からB級料理までね！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ぜんぶ喰らい尽くしてやるんだから！<br>わーっはっはっはっはっ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ戦いが終わったら<br>なにを食べたい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_510022")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ご馳走、プレゼントしてくれるの！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:なんでもいいけどね～っ！<br>甘いものでも、しょっぱいものでも！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それじゃあご馳走のし甲斐がないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_510025")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:あなたとなら<br>なんでもいいの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510026")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:食べづらくてもこの通り<br>美味しくいただけたわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:もう怖いものなんてないよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_510030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102001)
hotdog_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(116030)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
