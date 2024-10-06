-- このluaスクリプトは、MA_01C110_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_004)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
turn_chara(Actor001,110,0)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:大丈夫か、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:大丈夫だよ、兄さん<br>兄さんこそ大丈夫？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050003")

	open_select_window_tag(Actor001,"Normal","MA_01C110_050004","MA_01C110_050005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺のことなら心配無用だ<br>野宿なら慣れてるからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:でも歩いても歩いても<br>この森から出られない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050008")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:ここどこなんだろう…？<br>知っている気もするけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050009")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私、少し疲れちゃった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:少し疲れたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:無理しないで、兄さん<br>もう何時間も歩き通しだもん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050013")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:私も少し疲れちゃった<br>…でも、がんばるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050014")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★ディナタン★★:学園が襲われて、アーサー様に異変が起きて<br>…私たちだけがこの森に飛ばされた…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050016")

	PlayAction(Actor002,"to  Std_No")

	--★★ディナタン★★:あれから何日経ったのかもわかんない<br>兄さんはわかる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…わからない<br>夜も昼もわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050018")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さん、ちゃんと眠った？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050020")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…わかんない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺もだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:でもこんなに歩いているのに<br>私たちお腹も空かない…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050023")


	--★★ディナタン★★:気づいたらこの森にいて…<br>それで…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050024")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:とにかく脱出して<br>学園に戻らないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:学園…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050026")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…そっか、そうだね<br>私たち、戻らなきゃ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:みんな大丈夫かな…<br>がんばろう、兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050028")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…あ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050030")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:コート、ほつれてる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:繕ってあげるから脱いで、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050032")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:できた！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…母さんに似てきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050035")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力

	--★★ディナタン★★:そーう？<br>母さんほど上手には縫えてないけどね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050036")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…あれ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ねえ、声が聞こえない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050038")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:声だって？<br>どこから？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:あっちのほう…ほら
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…歌？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_050041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:そう、歌が聞こえる…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_050042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
