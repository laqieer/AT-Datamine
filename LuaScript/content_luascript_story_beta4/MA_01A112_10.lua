-- このluaスクリプトは、MA_01A112_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera002 = SetTemplate("Actor002",11,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0,0,0,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:ようこそ、先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:先輩『<ruby=あだばな>徒花</ruby>』って知ってますか
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:徒花…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100006")


	--★★エレイン★★:咲いたとしても<br>実を結ばずに終わってしまう花のことです
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:…私それ、自分のことだと思ってたんです<br>今となっては笑ってしまいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:『美姫』などと呼ばれて調子付き<br>兄をGSしてしまったと自己嫌悪に酔い…
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100009")


	--★★エレイン★★:見せかけだけで結果を伴えない──徒花と
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100011")


	--★★エレイン★★:…イタい女ですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100012")

	open_select_window_tag(Actor001,"Normal","MA_01A112_100014","MA_01A112_100015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…俺もキミと似ているところが<br>あるのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も父の恰好を模して<br>ぶかぶかの金コートを着た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100019")

	change_face(Actor001,"Sad")

	--★★ノワール★★:見せかけばかり似せても<br>本当のことはなにひとつわかっていなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100020")


	--★★エレイン★★:でも変わった
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100021")


	--★★エレイン★★:変われたんですよね、先輩は
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:あまり自己否定を繰り返さなくていい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100024")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは自分をキズつける<br>周りもキズつけるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100025")


	--★★エレイン★★:…きっとそうです<br>お兄ちゃんも苦しめている
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100026")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:でも、もう徒花でもいい
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100028")


	--★★エレイン★★:先輩と摘んだ徒花が国葬で燃えて散って<br>それが誰かの慰めになりました
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:ギネヴィアさんと眺めた徒花が心にずっと残って<br>それが私を衝き動かしました
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100030")


	--★★エレイン★★:花弁が焦がされ消えるまで<br>少しだけでも強く燃えられるならと
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100031")


	--★★エレイン★★:だから──
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100032")


	--★★エレイン★★:私のこと、見てくれますか。先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100034")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_100035")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
lookat_delay_weight(Actor002,0.7,0.03,0.7,0,0.7)
-- ▲直接出力

	--★★エレイン★★:今だけは、見てくれますか。先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100037")


	--★★エレイン★★:今だけは、目をそらさないでいてくれますか
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A112_100039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
