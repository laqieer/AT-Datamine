-- このluaスクリプトは、MA_01105_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:見繕ってあげる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050003")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:服を。たまには制服以外の服を着るのも<br>いいんじゃない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いいよ<br>ずっとそうだったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050005")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:もったいないよ、兄さん<br>素材はいいんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_050008","MA_01105_050009","MA_01105_050010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:…そ、そうかな？<br>まぁ、整ってるほうだとは自分でも思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050012")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:学園の制服、素材は最高なんだから<br>ランス兄ちゃんが用意してくれたものだし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050013")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:せ、制服？<br>制服の素材の話？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:もちろんそうだけど？<br>なにと勘違いしたの、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かにこれまで戦闘ばかりで<br>身だしなみに気を使ったことなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050018")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:傭兵時代は<br>ふだんでも傭兵団の制服着てたもんね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:たまにはお洒落してみるのも<br>気分転換にいいんじゃない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうだなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンも似たようなものじゃないか<br>いつも制服ばっかり着て
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050023")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:いくら妹だからって<br>女の子にそういうこと言う！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050024")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:見えないところで<br>お洒落してるのよ、私は
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえば？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050026")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Shy")

	--★★ディナタン★★:いくら妹だからって<br>女の子にそういうこと聞く！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050028")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★ディナタン★★:お礼を言って欲しいなあ<br>兄さんのコート、いつも誰が洗ってたか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…だから知らない間に<br>ふわふわになってたのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050031")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:コートは知らない間にふわふわにならないよ<br>私がふわふわにしてたの、ふわふわに洗ったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050032")

	change_face(Actor001,"Smile")

	--★★ノワール★★:…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_050033")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:ああふわふわだなあって思ったら<br>私のこと思い出してね、兄さん？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…私なりのお礼のひとつだから<br>いつも守ってくれてたことへの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だから今日はね<br>似合う服を見繕ってあげたいんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_050036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
