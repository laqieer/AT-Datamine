-- このluaスクリプトは、MA_01C900_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",35,CharaPos110041_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
noirpos = {0.93, 0, -4.719,   35}
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.5)
set_common_look_at(Actor001,Actor002,1.5)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor001,Actor002)
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:皇帝ルーシャス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020002")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★皇帝ルーシャス★★:ここは風通しがよいな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:だが屋上にしては高さがない<br>先を見通すには低すぎる
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:絶対にひとつはケチをつけないと<br>気が済まないタイプか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★皇帝ルーシャス★★:この学園には苦労させられている<br>これくらい言っても罰は当たるまいよ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera002)
turn_lookat_position(Actor002,CharaPos006[1],CharaPos006[2],CharaPos006[3],0.8)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, true)
wait_time(1.0)
SkipOffsetCamera(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★皇帝ルーシャス★★:さて…余と少し話をしていくか？
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020008")

	open_select_window_tag(Actor001,"Normal","MA_01C900_020009","MA_01C900_020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…やめておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020012")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★皇帝ルーシャス★★:そうか<br>それは残念
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな。少し話そうか<br>…聞きたいこともある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020015")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:魔女が話していたことについてか
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_end(Camera001)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:――穢れた血は為政者が作り出したもの
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:その穢れは誰にとっての穢れかという話だ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:国の歴史は侵略の歴史<br>連綿と続いてきたそれを王は学ぶ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020022")

	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:為政者にとって都合の悪い存在は<br>悪とされ、歴史の闇に葬られていく
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020023")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:バルバロイも、そういうものだと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:それは後の世が決めることだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020025")

	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:余は続いてきた歴史こそ守るべきものだと考える<br>偉大なるローマを守ることは王の義務
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020026")

	change_face(Actor002,"Anger")

	--★★皇帝ルーシャス★★:故にローマの繁栄に影を落とすものは<br>排除せねばならぬ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020027")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★皇帝ルーシャス★★:だが…もし自身がそうだとしたら
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020029")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★皇帝ルーシャス★★:続いてきた歴史そのものに<br>疑問を感じることもあるかもしれん
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★皇帝ルーシャス★★:今まで流れてきた血は本当に正しかったか<br>現状に固執することで失われるものはないか
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020032")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★皇帝ルーシャス★★:穢れを排除し続けた無菌の楽園に<br>はたして未来はあるのか――と
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…わからない<br>それで仲間を――皆の思いを裏切るなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020034")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★皇帝ルーシャス★★:わかる必要などない<br>王とは孤独なものよ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020035")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★皇帝ルーシャス★★:王の孤独など理解するものではない
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020036")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★皇帝ルーシャス★★:それとも、理解できたら許せるのか？
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C900_020038")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020039")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight_reset(Actor001,0.7)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001,noirpos[1],noirpos[2],noirpos[3],0.3)
wait_time(0.3)
slidemove(Actor001,noirpos[1],noirpos[2],noirpos[3],1.0)
wait_time(1.0)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.0)
PlayActionDirect(Actor001,"to  Std_Sad01")
change_face(Actor001,"Normal")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:でも…それでも俺は…わかりたい<br>アーサーの『本当』の思いを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_020040")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
noirpos = {0.93, 0, -4.719,   35}
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
